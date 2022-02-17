using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5.Examen.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.Data.Contexts.Configuration
{
    public partial class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasDefaultValueSql("(newid())");

            entity.Property(e=>e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LastNames)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);


        }

        partial void OnConfigurePartial(EntityTypeBuilder<Student> entity);
    }
}
