using EFCoreAssignment01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Configuration
{
    public class InstuctorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Name)
                    .IsRequired()
                    .HasColumnName("FullName")
                    .HasMaxLength(50);
            builder.Property(x => x.Bouns)
                    .HasColumnType("decimal")
                    .HasMaxLength(18)
                    .HasDefaultValue(0)
                    .HasPrecision(18, 2)
                    .HasColumnName("BounsAmount");
            builder.Property(x => x.Salary).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(200)
                    .HasColumnType("varchar(200)");


            builder.Property(x => x.HoureRate).IsRequired()
                    .HasPrecision(9, 2)
                    .HasColumnType("decimal(9, 2)");




        }
    }
}
