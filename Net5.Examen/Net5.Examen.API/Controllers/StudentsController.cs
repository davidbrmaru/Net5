using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net5.Examen.API.Infrastructure.Data.Repositories;
using Net5.Examen.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5.Examen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger _logger;

        public StudentsController(
            IStudentRepository studentRepository,
            ILogger<StudentsController> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            _logger.LogWarning("Log From GetStudents method");
            var students = await _studentRepository.GetStudentsAsync();
            _logger.LogInformation("HTTP GET: Called get method of Student Controller");
            return students;
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public async Task<Student> GetAsync(Guid id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Student student)
        {
            var result = await _studentRepository.InsertAsync(student);
            return CreatedAtRoute("GetStudent", new { id = result.StudentId }, result);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] Student student)
        {
            var result = await _studentRepository.UpdateAsync(id, student);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _studentRepository.DeleteAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
