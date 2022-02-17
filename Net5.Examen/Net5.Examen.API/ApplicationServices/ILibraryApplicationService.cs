using Net5.Examen.Infrastructure.CrossCutting.Dtos;
using Net5.Examen.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;

namespace Net5.Examen.API.ApplicationServices
{
    public interface ILibraryApplicationService
    {
        List<StudentDto> GetStudents(StudentsResourceParameters studentsResourceParameters);
        StudentDto GetStudent(Guid studentId);
        StudentDto CreateStudent(StudentForCreationDto student);
        StudentDto UpdateStudent(Guid studentId, StudentForUpdateDto student);

        StudentDto DeleteStudent(Guid studentId);
    }
}