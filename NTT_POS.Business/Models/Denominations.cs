﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Denominations
    {
        public int DenominationId { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
