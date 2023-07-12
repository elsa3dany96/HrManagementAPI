using HrManagement.Core.IRepo;
using HrManagement.Core.Models;
using HrManagement.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.Empliment
{
    public class UniteOfWork : IUniteOfWork
    {
        private readonly ApplicationDbContext _context;
        public IEmployeeRepo EmployeeRepo { get; private set; }

        public IMainRepo<ComeLate> ComeLateRepo { get; private set; }

        public IMainRepo<Disattend> DisattendRepo { get; private set; }

        public IMainRepo<Discount> DiscountRepo { get; private set; }

        public IMainRepo<DisRegister> DisRegisterRepo { get; private set; }

        public IMainRepo<ExtraTime> ExtraTimeRepo { get; private set; }

        public IMainRepo<Ponus> PonusRepo { get; private set; }

        public IMainRepo<WentEarly> WentEarly { get; private set; }
        public IMainRepo<Day> Day { get; private set; }
        public IMainRepo<InformationAtendAndLeaving> InformationAtendAndLeaving { get; private set; }
        public UniteOfWork(ApplicationDbContext context)
        {
            _context = context;
            EmployeeRepo = new EmployeeRepo(_context);
            ComeLateRepo = new MainRepo<ComeLate>(_context);
            DisattendRepo = new MainRepo<Disattend>(_context);
            DiscountRepo = new MainRepo<Discount>(_context);
            DisRegisterRepo = new MainRepo<DisRegister>(_context);
            ExtraTimeRepo = new MainRepo<ExtraTime>(_context);
            PonusRepo = new MainRepo<Ponus>(_context);
            WentEarly = new MainRepo<WentEarly>(_context);
            Day = new MainRepo<Day>(_context);
            InformationAtendAndLeaving = new MainRepo<InformationAtendAndLeaving>(_context);

        }

        public void Dispose() => _context.Dispose();


        public int SaveAll() => _context.SaveChanges();


        public async Task<int> SaveAllAsync() => await _context.SaveChangesAsync();

    }
}
