using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Estrogen
    {
        public int Id { get; set; }
        public decimal EstrogenResult { get; set; }
        public String DocName { get; set; }
        public bool isEstrogen { get; set; }
    }
}
