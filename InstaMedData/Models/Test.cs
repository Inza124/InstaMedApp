using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Test
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public DateTime Date { get; set; }
        public String Status { get; set; }
        public int TestType{ get; set; }

        public Result TestResult { get; set; }
        public ApplicationUser TestUser { get; set; }
    }
}
