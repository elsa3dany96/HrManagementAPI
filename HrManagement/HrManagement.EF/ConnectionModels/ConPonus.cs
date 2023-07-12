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
    public class ConPonus : IEntityTypeConfiguration<Ponus>
    {
        public void Configure(EntityTypeBuilder<Ponus> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .HasOne(p => p.ExtraTime)
                .WithOne(p => p.Ponus)
                .HasForeignKey<ExtraTime>(p => p.ponusId)
                .HasPrincipalKey<Ponus>(p => p.Id);


        }
    }
}
