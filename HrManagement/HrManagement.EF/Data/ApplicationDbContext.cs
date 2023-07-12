using HrManagement.Core.Models;
using HrManagement.EF.ConnectionModels;
using HrManagement.EF.Empliment;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            new ConEmployee().Configure(builder.Entity<Employee>());
            new ConDay().Configure(builder.Entity<Day>());
            new ConDiscount().Configure(builder.Entity<Discount>());
            new ConPonus().Configure(builder.Entity<Ponus>());
            new ConComeLate().Configure(builder.Entity<ComeLate>());
            new ConDisRegister().Configure(builder.Entity<DisRegister>());
            new ConExtraTime().Configure(builder.Entity<ExtraTime>());
            new ConPonus().Configure(builder.Entity<Ponus>());
            new ConWentEarly().Configure(builder.Entity<WentEarly>());
        }
        public DbSet<ComeLate> ComeLates { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Disattend> Disattends { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DisRegister> DisRegisters { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExtraTime> ExtraTimes { get; set; }
        public DbSet<Ponus> Ponus { get; set; }
        public DbSet<WentEarly> WentEarlys { get; set; }
        public DbSet<FireHireDate> FireHireDates { get; set; }
        public DbSet<InformationAtendAndLeaving> InformationAtendAndLeaving { get; set; }
        
    }
}
