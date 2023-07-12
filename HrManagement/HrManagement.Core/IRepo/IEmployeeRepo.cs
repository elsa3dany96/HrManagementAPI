using HrManagement.Core.Models;
using HrManagement.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.IRepo
{
    public interface IEmployeeRepo:IMainRepo<Employee>
    {
        Employee MapEmployeeToVEmployee(VEmployee vemployee);
    }
}
