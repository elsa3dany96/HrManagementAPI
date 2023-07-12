using HrManagement.Core.IRepo;
using HrManagement.Core.Models;
using HrManagement.EF.Empliment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly IUniteOfWork _uniteOfWork;

        public RulesController(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> SetTime([FromForm] InformationAtendAndLeaving model)
        {
          var result = await _uniteOfWork.InformationAtendAndLeaving.CreateAync(model);
            await _uniteOfWork.SaveAllAsync();
            return Ok(result);
        }
        [HttpPost,Route("{id}")]
        public async Task<IActionResult> changetime([FromForm] InformationAtendAndLeaving model)
        {
            var result = await _uniteOfWork.InformationAtendAndLeaving.GetOneBy(p=>p.Leaving != null);
            result.Attend =model.Attend;    
            result.Leaving = model.Leaving;
            await _uniteOfWork.SaveAllAsync();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            return Ok(await _uniteOfWork.InformationAtendAndLeaving.GetOneBy(p => p.Leaving != null)) ;
        }
    }
}
