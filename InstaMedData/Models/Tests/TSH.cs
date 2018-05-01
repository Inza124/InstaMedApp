using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class TSH
    {
        public int Id { get; set; }
        public double TSHResult { get; set; }
        public string DocName { get; set; }
        public string Type { get; set; }
        public TSH()
        {
            Type = "TSH";
        }
    }
}
