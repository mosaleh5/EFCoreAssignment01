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
    public class CourseInstConfigurations : IEntityTypeConfiguration<CourseInst>
    {
        public void Configure(EntityTypeBuilder<CourseInst> builder)
        {
            builder.HasKey(x => new {x.InstId ,  x.CourseId });
            builder.Property(x => x.Evaluate)
                   .IsRequired()
                   .HasColumnType("decimal(5,2)")
                   .HasDefaultValue(0.0);

        }
    }
}
