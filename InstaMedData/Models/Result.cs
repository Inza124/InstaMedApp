using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Result
    {
        public int Id { get; set; }
        public String DoctorName { get; set; }

        public Visit visit { get; set; }
        public TSH TSHTest { get; set; }
        //public Glucose GlucoseTest { get; set; }
        //public BetaHCG  BetaHCGTest{ get; set; }
        //public USG USGTest { get; set; }

    }
}
