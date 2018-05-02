using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Glukoza
    {
        public int Id { get; set; }
        public decimal GlukozaResult { get; set; }
        public String DocName { get; set; }
        public bool isGlukoza { get; set; }
    }
}
