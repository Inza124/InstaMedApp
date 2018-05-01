using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class TSH
    {
        public int Id { get; set; }
        public decimal TSHResult { get; set; }
        public string DocName { get; set; }
        public bool isTSH { get; set; }
    }
}
