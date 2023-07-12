using HrManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.ConnectionModels
{
    public class ConDisRegister : IEntityTypeConfiguration<DisRegister>
    {
        public void Configure(EntityTypeBuilder<DisRegister> builder)
        {
            builder
                 .HasKey(p => p.Id);
            builder
                .HasOne(p => p.Day)
                .WithOne(p => p.DisRegister)
                .HasForeignKey<DisRegister>(p => p.DayId)
                .HasPrincipalKey<Day>(p => p.Id);
            builder
                .HasOne(p => p.Discount)
                .WithOne(p => p.disRegister)
                .HasForeignKey<DisRegister>(p => p.discountId)
                .HasPrincipalKey<Discount>(p => p.Id);
        }
    }
}
