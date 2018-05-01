using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstaMedData.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public String Status { get; set; }

        public ApplicationUser User { get; set; }
        public List<Temp> TestsId { get; set; }
        public ICollection<Result> TestResults { get; set; }
    }
}
