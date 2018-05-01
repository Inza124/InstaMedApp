using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstaMedData.Models
{
    public class TestTypeCategory
    {
        public int Id { get; set; }

        public String Category { get; set; }

        public int NameId { get; set; }

        public TestTypeCategory()
        {

        }
        public TestTypeCategory(int CatId, String Cat, int namid)
        {
            Id = CatId;
            Category = Cat;
            NameId = namid;
        }
    }
}
