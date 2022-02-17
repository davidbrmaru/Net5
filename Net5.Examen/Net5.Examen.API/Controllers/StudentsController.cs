using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net5.Examen.API.ApplicationServices;
using Net5.Examen.Infrastructure.CrossCutting.Dtos;
using System;

namespace Net5.Examen.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ILibraryApplicationService _libraryApplicationService;
        private readonly ILogger _logger;

        public StudentsController(
            ILibraryApplicationService libraryApplicationService,
            ILogger<StudentsController> logger)
        {
            _libraryApplicationService = libraryApplicationService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetStudents([FromQuery] StudentsResourceParameters studentsResourceParameters)
        {
            _logger.LogWarning("Log From GetStudents method");
            _logger.LogInformation("HTTP GET: Called get method of Student Controller");
            return Ok(_libraryApplicationService.GetStudents(studentsResourceParameters));
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent(Guid id)
        {
            _logger.LogWarning("Log From GetStudent");
            return Ok(_libraryApplicationService.GetStudent(id));
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] StudentForCreationDto student)
        {
            _logger.LogWarning("Log From CreateStudents");
            if (student == null)
            {
                return BadRequest();
            }

            var result = _libraryApplicationService.CreateStudent(student);
            return CreatedAtRoute("GetStudent",new {id = result.StudentId}, result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Guid id,[FromBody] StudentForUpdateDto student)
        {
            _logger.LogWarning("Log From UpdateStudent");
            if (student == null)
            {
                return BadRequest();
            }

            var result = _libraryApplicationService.UpdateStudent(id, student);
            
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(Guid id)
        {
            _logger.LogWarning("Log From DeleteStudent");
            var result = _libraryApplicationService.DeleteStudent(id);

            if(result == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
