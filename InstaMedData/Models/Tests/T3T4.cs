using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class T3T4
    {
        public int Id { get; set; }
        public float T3Result { get; set; }
        public float T4Result { get; set; }
        public String DocName { get; set; }
        public string Type { get; set; }

        public T3T4()
        {
            Type = "T3T4";
        }
    }
}
