using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Data.Configurations
{
    internal class Std_CourseConfigurations : IEntityTypeConfiguration<Std_Course>
    {
        public void Configure(EntityTypeBuilder<Std_Course> builder)
        {
            builder
                .HasKey(sc => new { sc.Stud_id, sc.Course_id });
            builder
                .Property(sc => sc.Grarde)
                .HasDefaultValue(0)
                .IsRequired();
        }
    }
}
