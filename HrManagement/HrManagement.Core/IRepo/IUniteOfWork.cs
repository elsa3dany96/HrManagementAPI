using HrManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.IRepo
{
    public interface IUniteOfWork:IDisposable
    {
        IEmployeeRepo EmployeeRepo { get; }
        IMainRepo<ComeLate> ComeLateRepo { get; }
        IMainRepo<Disattend> DisattendRepo { get; }
        IMainRepo<Discount> DiscountRepo { get; }
        IMainRepo<DisRegister> DisRegisterRepo { get; }
        IMainRepo<ExtraTime> ExtraTimeRepo { get; }
        IMainRepo<Ponus> PonusRepo { get; }
        IMainRepo<WentEarly> WentEarly { get; }
        IMainRepo<Day> Day { get; }
        IMainRepo<InformationAtendAndLeaving> InformationAtendAndLeaving { get; }
        Task<int> SaveAllAsync();
        int SaveAll();

    }
}
