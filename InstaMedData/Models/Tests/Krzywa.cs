using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Krzywa
    {
        public int Id { get; set; }
        public decimal FirstGlu { get; set; }
        public decimal SecondGlu { get; set; }
        public decimal ThirdGlu { get; set; }
        public String DocName { get; set; }
        public bool isKrzywa { get; set; }
    }
}
