using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Net5.Examen.API.Infrastructure.Data.Contexts;
using Net5.Examen.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Examen.API.Infrastructure.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context;
        private DbSet<Student> _dbSet;
        private readonly ILogger _logger;
        public StudentRepository(
            StudentContext context,
            ILogger<StudentRepository> logger)
        {
            _context = context;
            _dbSet = context.Set<Student>();
            _logger = logger;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            List<string> topics = new List<string> { "C#", ".NET", "logging" };
            _logger.LogWarning("Another message generated by {AuthorName} - Today is {Today:yyyy-MM-dd} and I'm talking about {Topics}", "David", DateTime.Now.Date, topics);
            return await _dbSet.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(Guid studentId)
        {
            return await _dbSet.Where(p => p.StudentId == studentId).FirstOrDefaultAsync();
        }
        public async Task<Student> InsertAsync(Student student)
        {
            _dbSet.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task<Student> UpdateAsync(Guid studentId, Student student)
        {
            Student studentToUpdate = await GetStudentByIdAsync(studentId);
            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.MiddleName = student.MiddleName;
            studentToUpdate.LastNames = student.LastNames;
            studentToUpdate.Age = student.Age;

            _dbSet.Update(studentToUpdate);
            await _context.SaveChangesAsync();

            return studentToUpdate;
        }

        public async Task<Student> DeleteAsync(Guid studentId)
        {
            Student studentToDelete = await GetStudentByIdAsync(studentId);

            _dbSet.Remove(studentToDelete);
            await _context.SaveChangesAsync();
            return studentToDelete;
        }
    }
}
