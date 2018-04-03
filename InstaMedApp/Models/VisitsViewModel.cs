using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaMedData.Models;

namespace InstaMedApp.Models
{
    public class VisitsViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Status { get; set; }
        public int UserId { get; set; }
        public List<Test> Tests { get; set; }
        public List<Result> Results { get; set; }
    }
}
