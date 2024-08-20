using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectB3_API.Domain.Models
{
    public class Investment
    {
        public decimal InitialValue { get; set; }
        public int Months { get; set; }
    }

    public class InvestmentResult
    {
        public decimal NetValue { get; set; }
        public decimal GrossValue { get; set; }
    }
}