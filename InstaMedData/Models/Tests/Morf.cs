﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstaMedData.Models
{
    public class Morf
    {
        public int Id { get; set; }
        public String DocName { get; set; }
        [DisplayName("Erytrocyty")]
        public decimal RBCResult { get; set; }
        [DisplayName("Leukocyty")]
        public decimal WBCResult{ get; set; }
        [DisplayName("Hemoglobina")]
        public decimal HBResult { get; set; }
        [DisplayName("Hematokryt")]
        public decimal HTResult { get; set; }
        [DisplayName("Średnia objętość krwinki czerwonej")]
        public decimal MCVResult { get; set; }
        [DisplayName("Średnia masa Hb w krwince")]
        public decimal MCHResult { get; set; }
        [DisplayName("Średnie stężenie Hb w krwince")]
        public decimal MCHCResult { get; set; }
        [DisplayName("płytki krwi")]
        public decimal Plt { get; set; }
        public bool isMorf { get; set; }
    }
}
