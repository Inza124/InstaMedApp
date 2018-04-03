using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public String Status { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<Test> Tests { get; set; }
        public ICollection<Result> TestResults { get; set; }
    }
}
