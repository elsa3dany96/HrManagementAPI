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
    public class ConDisattend : IEntityTypeConfiguration<Disattend>
    {
        public void Configure(EntityTypeBuilder<Disattend> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .HasOne(p => p.Discount)
                .WithOne(p => p.disAttend)
                .HasForeignKey<Disattend>(p => p.discountId)
                .HasPrincipalKey<Discount>(p => p.Id);
            builder
                .HasOne(p => p.Day)
                .WithOne(p => p.Disattend)
                .HasForeignKey<Disattend>(p => p.DayId)
                .HasPrincipalKey<Day>(p => p.Id);
        }
    }
}
