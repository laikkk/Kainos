using aspTest.Helpers;
using aspTest.Models.Bases;
using aspTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class CountryCodeModel : DataBase
    {

        public List<CountryCodeModelBase> PopulateCountryCodeList(string Code)
        {
            System.Diagnostics.Debug.WriteLine(Alpha.GROUPED_COUNTRIES_SELECT);
            DataTable dt = ExecuteStatment(Alpha.COUNTRY_CODE_PREPARED_SELECT, Code);

            List<CountryCodeModelBase> CountryCodeModel = new List<CountryCodeModelBase>();
            foreach (DataRow dr in dt.Rows)
            {
                CountryCodeModel.Add(new CountryCodeModelBase
                                                            {
                                                                Code = Convert.ToString(dr["code"]),
                                                                Name = Convert.ToString(dr["name"]),
                                                                Language = Convert.ToString(dr["language"]),
                                                                Percentage = Convert.ToDouble(dr["percentage"]),                  
                                                            }
                                    );
            } 
            
            return CountryCodeModel;
        }
    }
}