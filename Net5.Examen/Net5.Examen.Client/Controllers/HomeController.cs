using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net5.Examen.Client.Infrastructure.Agents;
using Net5.Examen.Client.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Examen.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentsAgent _studentsAgent;

        public HomeController(ILogger<HomeController> logger, StudentsAgent studentsAgent)
        {
            _logger = logger;
            _studentsAgent = studentsAgent;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<Student> students = await _studentsAgent.GetStudentsAsync();
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
