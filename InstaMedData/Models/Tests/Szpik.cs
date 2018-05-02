using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InstaMedData.Models
{
    public class Szpik
    {
        public int Id { get; set; }
        [DisplayName("Erytropoeza")]
        public decimal Erytropoeza { get; set; }
        [DisplayName("Proerytroblasty")]
        public decimal Proerytroblasty { get; set; }
        [DisplayName("Erytroblasty")]
        public decimal Erytroblasty { get; set; }
        public String DocName { get; set; }
        public bool isSzpik { get; set; }
    }
}
