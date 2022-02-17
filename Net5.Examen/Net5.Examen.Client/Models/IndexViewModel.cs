using System.Collections.Generic;

namespace Net5.Examen.Client.Models
{
    public class IndexViewModel
    {
        public List<StudentViewModel> Students { get; set; }
        public string PageTitle { get; set; }
        public string UserName { get; set; }
    }
}
