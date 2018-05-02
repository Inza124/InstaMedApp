using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InstaMedData.Models
{
    public class Mocz
    {
        public int Id { get; set; }
        public String DocName { get; set; }
        [DisplayName("Nabłonki płaskie")]
        public decimal Nablonki { get; set; }
        [DisplayName("Białe krwinki")]
        public decimal KrwB { get; set; }
        [DisplayName("Krwinki Czerwone")]
        public decimal KrwCz { get; set; }
        [DisplayName("Śluz")]
        public string Sluz { get; set; }
        [DisplayName("Bakterie")]
        public string Bakterie { get; set; }
        public bool isMocz { get; set; }
    }
}
