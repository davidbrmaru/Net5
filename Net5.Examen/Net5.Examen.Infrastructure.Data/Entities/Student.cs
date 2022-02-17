using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.Data.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastNames { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

    }
}
