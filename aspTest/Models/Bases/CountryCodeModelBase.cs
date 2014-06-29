using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspTest.Models.Bases
{
    public class CountryCodeModelBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public double Percentage { get; set; }
    }
}