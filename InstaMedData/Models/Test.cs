using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstaMedData.Models
{
    public class Test
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        
        public TestTypeName testTypeName { get; set; }
        public TestTypeCategory testTypeCategory { get; set; }
    }
}
