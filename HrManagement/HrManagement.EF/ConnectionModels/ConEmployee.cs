using HrManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.ConnectionModels
{
    public class ConEmployee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(p =>p.IDPerson);
            builder
                .HasIndex(p => p.fingerprint)
                .IsUnique();       
            builder
                .Property(p=>p.FristName)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(p => p.LastName)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(p => p.IDPerson)
                .HasMaxLength (14)
                .IsRequired();
            builder
                .Property(p=>p.Address)
                .IsRequired();
            builder
                .Property(p=>p.Position)
                .IsRequired();
            builder
                .Property(p=>p.Salary)
                .IsRequired();
            builder
                .Property(p=>p.City)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(p=>p.Address)
                .IsRequired();
            builder
                .HasMany(p => p.Discount)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);

            builder
                .HasMany(p => p.Ponus)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);

            builder
                .HasMany(p => p.WentEarly)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .HasMany(p => p.ComeLate)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .HasMany(p => p.DisRegister)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .HasMany(p => p.Disattend)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .HasMany(p => p.ExtraTime)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .HasMany(p => p.FireHireDate)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeIDPerson)
                .HasPrincipalKey(p => p.IDPerson);
            builder
                .Property(p => p.Age)
                .IsRequired();



        }
    }
}
