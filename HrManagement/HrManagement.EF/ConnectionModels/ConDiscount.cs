using HrManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.EF.ConnectionModels
{
    public class ConDiscount : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .HasOne(p => p.ComeLate)
                .WithOne(p => p.Discount)
                .HasForeignKey<Discount>(p => p.comeLateId)
                .HasPrincipalKey<ComeLate>(p => p.Id);

            builder
                .HasOne(p => p.disAttend)
                .WithOne(p => p.Discount)
                .HasForeignKey<Discount>(p => p.disAttendId)
                .HasPrincipalKey<Disattend>(p => p.Id);

            builder
                .HasOne(p => p.disRegister)
                .WithOne(p => p.Discount)
                .HasForeignKey<Discount>(p => p.disRegisterId)
                .HasPrincipalKey<DisRegister>(p => p.Id);

            builder
               .HasOne(p => p.wentEarly)
               .WithOne(p => p.Discount)
               .HasForeignKey<Discount>(p => p.wentEarlyId)
               .HasPrincipalKey<WentEarly>(p => p.Id);



        }
    }
}
