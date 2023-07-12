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
    public class ConComeLate : IEntityTypeConfiguration<ComeLate>
    {
        public void Configure(EntityTypeBuilder<ComeLate> builder)
        {
            builder
                .HasKey(e => e.Id);
            builder
                .HasOne(p => p.Day)
                .WithOne(p => p.ComeLate)
                .HasForeignKey<ComeLate>(p => p.DayId)
                .HasPrincipalKey<Day>(p => p.Id);
            builder
                .HasOne(p => p.Discount)
                .WithOne(p => p.ComeLate)
                .HasForeignKey<ComeLate>(p => p.discountId)
                .HasPrincipalKey<Discount>(p => p.Id);
        }
    }
}
