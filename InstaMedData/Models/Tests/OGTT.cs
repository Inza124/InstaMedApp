using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class OGTT
    {
        public int Id { get; set; }
        public decimal FirstGlu { get; set; }
        public decimal SecondGlu { get; set; }
        public decimal ThirdGlu { get; set; }
        public String DocName { get; set; }
        public bool isOGTT { get; set; }
    }
}
