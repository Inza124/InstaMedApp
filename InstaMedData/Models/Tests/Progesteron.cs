using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Progesteron
    {
        public int Id { get; set; }
        public decimal ProgesteronResult { get; set; }
        public String DocName { get; set; }
        public bool isProgesteron { get; set; }
    }
}
