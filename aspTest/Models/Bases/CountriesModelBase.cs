using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class CountriesModelBase
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public int Population { get; set; }
        public double Official_Language_Use_Percent { get; set; }
        public double Official_Language_Population_Use_People { get; set; }
        public string Code { get; set; }

        public CountriesModelBase(string Continent, string Country, string Language, int Population, double Official_Language_Use_Percent, double Official_Language_Population_Use_People, string Code)
        {
            this.Continent = Continent;
            this.Country = Country;
            this.Language = Language;
            this.Population = Population;
            this.Official_Language_Use_Percent = Official_Language_Use_Percent;
            this.Official_Language_Population_Use_People = Official_Language_Population_Use_People;
            this.Code = Code;
        }

        public CountriesModelBase()
        {
           
        }
    }
}