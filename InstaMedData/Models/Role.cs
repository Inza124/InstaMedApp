using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Role
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int AccesLevel { get; set; }

        public ApplicationUser User { get; set; }
    }
}
