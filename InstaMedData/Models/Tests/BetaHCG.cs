using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class BetaHCG
    {
        public int Id { get; set; }
        public decimal BetaHCGResult { get; set; }
        public String DocName { get; set; }
        public bool isBeta { get; set; }
    }
}
