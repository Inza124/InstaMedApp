using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstaMedData.Models
{
    public class TestTypeName
    {
        [Key]
        public int NameId { get; set; }

        public String Name { get; set; }

        public int CategoryId{ get; set; }
    }
}
