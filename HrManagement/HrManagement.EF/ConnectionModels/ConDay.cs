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
    public class ConDay : IEntityTypeConfiguration<Day>
    {
        public void Configure(EntityTypeBuilder<Day> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .HasOne(p => p.ComeLate)
                .WithOne(p => p.Day)
                .HasForeignKey<ComeLate>(p => p.DayId)
                .HasPrincipalKey<Day>(p => p.Id);

            builder
               .HasOne(p => p.Disattend)
               .WithOne(p => p.Day)
               .HasForeignKey<Disattend>(p => p.DayId)
               .HasPrincipalKey<Day>(p => p.Id);

            builder
               .HasOne(p => p.DisRegister)
               .WithOne(p => p.Day)
               .HasForeignKey<DisRegister>(p => p.DayId)
               .HasPrincipalKey<Day>(p => p.Id);

            builder
               .HasOne(p => p.ExtraTime)
               .WithOne(p => p.Day)
               .HasForeignKey<ExtraTime>(p => p.DayId)
               .HasPrincipalKey<Day>(p => p.Id);

            builder
               .HasOne(p => p.WentEarly)
               .WithOne(p => p.Day)
               .HasForeignKey<WentEarly>(p => p.DayId)
               .HasPrincipalKey<Day>(p => p.Id);



        }
    }
}
