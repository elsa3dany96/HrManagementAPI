using HrManagement.Core.IRepo;
using HrManagement.Core.Models;
using HrManagement.Core.ViewModels;
using HrManagement.EF.Data;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.Empliment
{
    public class EmployeeRepo : MainRepo<Employee>, IEmployeeRepo
    {
        public EmployeeRepo(ApplicationDbContext context) : base(context) { }
        public Employee MapEmployeeToVEmployee(VEmployee vemployee)
        {
            using var dataStream = new MemoryStream();
            vemployee.IDImg.CopyTo(dataStream);

          return   new()
          {
                      fingerprint = vemployee.fingerprint,
                      FristName = vemployee.fristName,
                      LastName = vemployee.lastName,
                      IDPerson = vemployee.iDPerson,
                      Address = vemployee.address,
                      City = vemployee.city,
                      Age = vemployee.age,
                      Position = vemployee.position,
                      Salary = vemployee.salary,
                      MasterIDPerson = vemployee.MasterIDPerson != null ? vemployee.MasterIDPerson : "NoOne",
                      IDImg = dataStream.ToArray()

          };

        }
    }
}
