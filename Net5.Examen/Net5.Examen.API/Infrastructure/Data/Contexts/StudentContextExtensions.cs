using Net5.Examen.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.API.Infrastructure.Data.Contexts
{
    public static class StudentContextExtensions
    {
        public static void EnsureSeeDataForContext(this StudentContext context)
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
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Jose",
                    MiddleName = "Eduardo",
                    LastNames = "Fulano Melgano",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Jorge",
                    MiddleName = "Martin",
                    LastNames = "Gutierrez Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Mario",
                    MiddleName = "Arturo",
                    LastNames = "Perez Falcon",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Tito",
                    MiddleName = "Martin",
                    LastNames = "Nieves Castillo",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Alondra",
                    MiddleName = "Maria",
                    LastNames = "Vasquez Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Maria",
                    MiddleName = "Ortencia",
                    LastNames = "Rubio Martinez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Lalo",
                    MiddleName = "Lenin",
                    LastNames = "Malca Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Sara",
                    MiddleName = "Doris",
                    LastNames = "Lopez Sanchez",
                    Age = 25
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();


        }
    }
}
