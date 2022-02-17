using System;

namespace Net5.Examen.Client.Models
{
    public class StudentViewModel
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastNames { get; set; }
        public int Age { get; set; }
    }
}
