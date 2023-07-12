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
    public class ConExtraTime : IEntityTypeConfiguration<ExtraTime>
    {
        public void Configure(EntityTypeBuilder<ExtraTime> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .HasOne(p => p.Day)
                .WithOne(p => p.ExtraTime)
                .HasForeignKey<ExtraTime>(p => p.DayId)
                .HasPrincipalKey<Day>(p => p.Id);
            builder
                .HasOne(p => p.Ponus)
                .WithOne(p => p.ExtraTime)
                .HasForeignKey<ExtraTime>(p => p.ponusId)
                .HasPrincipalKey<Ponus>(p => p.Id);
        }
    }
}
