
using Net5.Examen.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5.Examen.API.Infrastructure.Data.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> DeleteAsync(Guid studentId);
        Task<Student> GetStudentByIdAsync(Guid studentId);
        Task<List<Student>> GetStudentsAsync();
        Task<Student> InsertAsync(Student student);
        Task<Student> UpdateAsync(Guid studentId, Student student);
    }
}