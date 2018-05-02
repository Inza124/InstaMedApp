using System;
using System.Collections.Generic;
using System.Text;

namespace InstaMedData.Models
{
    public class Result
    {
        public int Id { get; set; }
        public String DoctorName { get; set; }
        public String ResultType { get; set; }

        public Visit visit { get; set; }
        public TSH TSHTest { get; set; }
        public T3T4 T3T4Test { get; set; }
        public BetaHCG  BetaHCGTest{ get; set; }
        public USGPiersi USGPiersiTest { get; set; }
        public USGSerca USGSercaTest { get; set; }
        public USGSzyi USGSzyiTest { get; set; }
        public Estrogen EstrogenTest { get; set; }
        public Glukoza GlukozaTest { get; set; }
        public Krzywa KrzywaTest { get; set; }
        public Mocz MoczTest { get; set; }
        public Morf MorfTest { get; set; }
        public Morf5 Morf5Test { get; set; }
        public OGTT OGTTTest { get; set; }
        public Progesteron ProgesteronTest { get; set; }
        public Szpik SzpikTest { get; set; }
        public Testosteron TestosteronTest { get; set; }

    }
}
