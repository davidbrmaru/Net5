using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Net5.Examen.API.Controllers;
using Net5.Examen.API.Infrastructure.Data.Contexts;
using Net5.Examen.API.Infrastructure.Data.Entities;
using Net5.Examen.API.Infrastructure.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Examen.TestNUnit
{
    [TestFixture]
    public class StudentControllerTest
    {
        private DbContextOptions<StudentContext> _dbContextOptions = new DbContextOptionsBuilder<StudentContext>()
        .UseInMemoryDatabase(databaseName: "MemoryDb")
        .Options;

        private StudentRepository _studentRepository;
        private StudentsController _controller;

        [OneTimeSetUp]
        public void Setup()
        {
            SeedDb();
            _studentRepository = new StudentRepository(new StudentContext(_dbContextOptions), null);
            _controller = new StudentsController(_studentRepository, null);
        }

        [Test]
        public async Task GetStudentsAsync()
        {
            var result = await _controller.GetStudentsAsync();
            var students = result.As<IEnumerable<Student>>();
            students.Should().NotBeNullOrEmpty();
            students.Count().Should().Be(9);
            //Assert.AreEqual(5, result.Count());
        }
        [Test]
        public async Task GetAsync()
        {
            var result = await _controller.GetAsync(new Guid("f57706c5-da12-4cc2-af30-d28152705046"));
            var student = result.As<Student>();
            student.Should().NotBeNull();
            student.FirstName.Should().Be("David");
        }

        private void SeedDb()
        {
            using var context = new StudentContext(_dbContextOptions);

            List<Student> students = new List<Student>
            {
                new Student()
                {
                    StudentId = new Guid("f57706c5-da12-4cc2-af30-d28152705046"),
                    FirstName = "David",
                    MiddleName = "Brando",
                    LastNames = "Mautino Rubio",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("5066be97-42d9-41c6-85a8-23add678db56"),
                    FirstName = "Jose",
                    MiddleName = "Eduardo",
                    LastNames = "Fulano Melgano",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("20655f73-3990-4386-b264-1585eeafb47b"),
                    FirstName = "Jorge",
                    MiddleName = "Martin",
                    LastNames = "Gutierrez Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("e74fe909-50f3-4925-b808-bc54531ec5f3"),
                    FirstName = "Mario",
                    MiddleName = "Arturo",
                    LastNames = "Perez Falcon",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("09aaa638-c9e0-498d-a1d2-444167cd244c"),
                    FirstName = "Tito",
                    MiddleName = "Martin",
                    LastNames = "Nieves Castillo",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("92fd82f4-155c-40c8-88be-6637f726da26"),
                    FirstName = "Alondra",
                    MiddleName = "Maria",
                    LastNames = "Vasquez Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("0327c2c7-95a0-4890-92b8-539c287b3b80"),
                    FirstName = "Maria",
                    MiddleName = "Ortencia",
                    LastNames = "Rubio Martinez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("12378393-7b3b-43f3-a606-4f78a8bc4440"),
                    FirstName = "Lalo",
                    MiddleName = "Lenin",
                    LastNames = "Malca Sanchez",
                    Age = 25
                },
                new Student()
                {
                    StudentId = new Guid("78421872-6de8-461f-a261-58b7b2756e7a"),
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