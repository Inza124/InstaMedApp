using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstaMedData.Models
{
    public class Temp
    {
        [Key]
        public int PrimId { get; set; }

        public int Id { get; set; }

        public bool isDone { get; set; }

        public Temp()
        {

        }

        public Temp(int id)
        {
            Id = id;
            isDone = false;
        }
    }
}
