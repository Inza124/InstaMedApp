using System;
using System.Collections.Generic;
using System.Linq;
using InstaMedData.Models;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InstaMedApp.Models
{
    public class TestsViewModel
    {
        public int Id { get; set; }
        [Display(Name =  "Nazwa")]
        public String Name { get; set; }
        [Display(Name =  "Cena")]
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public int NameId { get; set; }
        public TestTypeName testTypeName { get; set; }
        public TestTypeCategory testTypeCategory { get; set; }
    }
}
