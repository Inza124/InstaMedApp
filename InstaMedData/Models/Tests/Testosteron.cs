using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Testosteron
    {
        public int Id { get; set; }
        public decimal TestosteronFree { get; set; }
        public decimal TestosteronAll { get; set; }
        public String DocName { get; set; }
        public bool isTestosteron { get; set; }
    }
}
