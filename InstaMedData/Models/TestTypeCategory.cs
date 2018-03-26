using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstaMedData.Models
{
    public class TestTypeCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public String Category { get; set; }

        public int NameId { get; set; }
    }
}
