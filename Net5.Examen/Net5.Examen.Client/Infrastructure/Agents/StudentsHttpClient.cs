using Microsoft.Extensions.Configuration;
using Net5.Examen.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Net5.Examen.Client.Infrastructure.Agents
{
    public class StudentsHttpClient
    {
        private HttpClient _httpClient;
        private string studentsApiUrl = "";
        public StudentsHttpClient(HttpClient httpClient, IConfiguration configuration)
        {
            studentsApiUrl = configuration.GetSection("StudentUrl").Value;
            InitializeClient(httpClient);
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Student>>("");
        }
        private void InitializeClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(studentsApiUrl);
            _httpClient = httpClient;
        }
    }
}
