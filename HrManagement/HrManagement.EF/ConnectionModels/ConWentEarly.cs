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
    public class ConWentEarly : IEntityTypeConfiguration<WentEarly>
    {
        public void Configure(EntityTypeBuilder<WentEarly> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
               .HasOne(p => p.Day)
               .WithOne(p => p.WentEarly)
               .HasForeignKey<WentEarly>(p => p.DayId)
               .HasPrincipalKey<Day>(p => p.Id);
            builder
               .HasOne(p => p.Discount)
               .WithOne(p => p.wentEarly)
               .HasForeignKey<WentEarly>(p => p.discountId)
               .HasPrincipalKey<Discount>(p => p.Id);
        }
    }
}
