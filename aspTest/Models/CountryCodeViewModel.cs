using aspTest.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class CountryCodeViewModel
    {
 
        public List<CountryCodeModelBase> CCMB { get; private set; }

        public CountryCodeViewModel(List<CountryCodeModelBase> ccmb)
        {
            CCMB = ccmb;
        }

      

       
    }
}