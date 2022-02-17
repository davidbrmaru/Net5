using Microsoft.EntityFrameworkCore;
using Net5.Examen.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.Data.Contexts
{
    public partial class LibraryContext:DbContext
    {
        public LibraryContext()
        {

        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configuration.StudentConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
