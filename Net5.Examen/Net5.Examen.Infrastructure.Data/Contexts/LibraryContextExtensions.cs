using Net5.Examen.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.Data.Contexts
{
    public static class LibraryContextExtensions
    {
        public static void EnsureSeeDataForContext(this LibraryContext context)
        {
            context.Students.RemoveRange(context.Students);
            context.SaveChanges();

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "David",
                    MiddleName = "Brando",
                    LastNames = "Mautino Rubio",
                    DateOfBirth = new DateTimeOffset(new DateTime(1995,8,5))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Jose",
                    MiddleName = "Eduardo",
                    LastNames = "Fulano Melgano",
                    DateOfBirth = new DateTimeOffset(new DateTime(1996,10,5))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Jorge",
                    MiddleName = "Martin",
                    LastNames = "Gutierrez Sanchez",
                    DateOfBirth = new DateTimeOffset(new DateTime(1997,3,20))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Mario",
                    MiddleName = "Arturo",
                    LastNames = "Perez Falcon",
                    DateOfBirth = new DateTimeOffset(new DateTime(1980,4,10))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Tito",
                    MiddleName = "Martin",
                    LastNames = "Nieves Castillo",
                    DateOfBirth = new DateTimeOffset(new DateTime(1996,1,26))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Alondra",
                    MiddleName = "Maria",
                    LastNames = "Vasquez Sanchez",
                    DateOfBirth = new DateTimeOffset(new DateTime(1980,12,20))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Maria",
                    MiddleName = "Ortencia",
                    LastNames = "Rubio Martinez",
                    DateOfBirth = new DateTimeOffset(new DateTime(1998,8,15))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Lalo",
                    MiddleName = "Lenin",
                    LastNames = "Malca Sanchez",
                    DateOfBirth = new DateTimeOffset(new DateTime(1987,10,20))
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Sara",
                    MiddleName = "Doris",
                    LastNames = "Lopez Sanchez",
                    DateOfBirth = new DateTimeOffset(new DateTime(2000,4,1))
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();


        }
    }
}
