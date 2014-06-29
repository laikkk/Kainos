using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class GrupedCountriesModelBase
    {
        public string Language;
        public double Population_Use;
        public double Global_Population_Percent_Use;
        public GrupedCountriesModelBase(string Language, double Population_Use, double Global_Population_Percent_Use)
        {
            this.Language = Language;
            this.Population_Use = Population_Use;
            this.Global_Population_Percent_Use = Global_Population_Percent_Use;
        }

        public GrupedCountriesModelBase()
        {
            // TODO: Complete member initialization
        }
    }
}