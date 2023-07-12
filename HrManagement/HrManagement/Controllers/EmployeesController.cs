using HrManagement.Core.IRepo;
using HrManagement.Core.Models;
using HrManagement.Core.ViewModels;
using HrManagement.EF.ConnectionModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace HrManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUniteOfWork _uniteOfWork;
        public EmployeesController(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] VEmployee model)
        {
            if (ModelState.IsValid)
            {
                var checkIfEmployeeInDataIdPerson = await _uniteOfWork.EmployeeRepo.FindThis(model.iDPerson);
                var checkIfEmployeeInDataFingerPrint = await _uniteOfWork.EmployeeRepo.GetOneBy(p => p.fingerprint == model.fingerprint);

                if (checkIfEmployeeInDataIdPerson == null && checkIfEmployeeInDataFingerPrint == null)
                {
                    var Result = await _uniteOfWork.EmployeeRepo.CreateAync(_uniteOfWork.EmployeeRepo.MapEmployeeToVEmployee(model));

                    try
                    {
                        var CountSaved = await _uniteOfWork.SaveAllAsync();
                        if (CountSaved > 0)
                        {
                            return Ok(Result);
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
                else { return BadRequest($"We already have an employee with ID {(checkIfEmployeeInDataIdPerson == null ? checkIfEmployeeInDataFingerPrint.IDPerson : checkIfEmployeeInDataIdPerson.IDPerson)}"); };



            }
            else
            {
                return BadRequest(ModelState);
            }


            return BadRequest();
        }
        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetEmployee(string id, byte v)
        {

            var ResultEmployee = await _uniteOfWork.EmployeeRepo.GetOneBy(p => p.IDPerson == id, new Expression<Func<Employee, object>>[]
            {
                p=>p.ComeLate,
                p=>p.Disattend,
                p=>p.DisRegister,
                p=>p.Discount,
                p=>p.ExtraTime,
                p=>p.FireHireDate,
                p=>p.Ponus,
                p=>p.WentEarly,
                p=>p.Days
            });
            if (ResultEmployee != null)
            {
                
                return Ok(ResultEmployee);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut, Route("{id}")]
        public async Task<IActionResult> AttendEmployee(string id)
        {
            
            var check = await _uniteOfWork.EmployeeRepo.GetOneBy(p => p.fingerprint == id ,new Expression<Func<Employee, object>>[]
            {
                p=>p.Days
            });

            if (check != null)
            {
                if(check.Days.LastOrDefault().Attend == null)
                {
                    
                        check.Days.LastOrDefault().Attend = DateTime.Now;
                    
                    

                    var TimeInfo = await _uniteOfWork.InformationAtendAndLeaving.GetOneBy(p => p.Attend != null);

                    if(TimeInfo.Attend.TimeOfDay < DateTime.Now.TimeOfDay)
                    {

                        check.Days.LastOrDefault().ComeLate = new ComeLate()
                        {
                            Employee = check,
                            Day = check.Days.LastOrDefault(),
                        };
                    }
                    await _uniteOfWork.SaveAllAsync();
                    return Ok("Welcome...");

                }
                else if(check.Days.LastOrDefault().Went == null)
                {
                    check.Days.LastOrDefault().Went = DateTime.Now;
                    var TimeInfo = await _uniteOfWork.InformationAtendAndLeaving.GetOneBy(p => p.Leaving != null);

                    if (TimeInfo.Leaving.TimeOfDay > DateTime.Now.TimeOfDay)
                    {

                        check.Days.LastOrDefault().WentEarly = new WentEarly()
                        {
                            Employee = check,
                            Day = check.Days.LastOrDefault(),
                            
                        };
                    }
                    
                    await _uniteOfWork.SaveAllAsync();
                    return Ok("Good Bye <3...");

                }
                else
                {
                    return BadRequest("We are waitting u tomorrow :D");
                }
                
            }
            return Ok();
        }
   


    }
}
