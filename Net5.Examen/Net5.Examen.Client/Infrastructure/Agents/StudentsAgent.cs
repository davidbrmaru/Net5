using Net5.Examen.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5.Examen.Client.Infrastructure.Agents
{
    public class StudentsAgent
    {
        private StudentsHttpClient _client;
        public StudentsAgent(StudentsHttpClient client)
        {
            _client = client;
        }

        public async Task<List<StudentViewModel>> GetStudentsAsync()
        {
            return await _client.GetStudentsAsync();
        }
    }
}
