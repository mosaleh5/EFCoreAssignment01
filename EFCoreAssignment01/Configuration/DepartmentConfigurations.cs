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
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1 , 1);
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("varchar(50)");
        /*    builder.Property(x => x.InsManagerId)
                   .HasDefaultValue(0);*/

            builder.Property(x => x.HiringDate)
                   .HasDefaultValueSql("GETDATE()");


        }
    }
}
