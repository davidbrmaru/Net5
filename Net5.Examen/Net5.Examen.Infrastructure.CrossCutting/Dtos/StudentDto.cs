using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.CrossCutting.Dtos
{
    public class StudentDto
    {
        public Guid StudentId { get; set; }
        public string Name { get; set;}
        public int Age { get; set;}
    }
}
