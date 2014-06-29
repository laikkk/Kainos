using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;
using aspTest.Helpers;

namespace aspTest.Models
{
    public class CountryModel : DataBase
    {

        public List<CountriesModelBase> PopulateCountriesList() {
            System.Diagnostics.Debug.WriteLine(Alpha.COUNTRIES_SELECT);
            DataTable dt = ExecuteQuery(Alpha.COUNTRIES_SELECT);

            List<CountriesModelBase> CountriesModel = new List<CountriesModelBase>();
            foreach (DataRow dr in dt.Rows)
            {
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["continent"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["name"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["language"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["population"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["percentage"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["Official Language Population Use"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["code"]));
                CountriesModel.Add(new CountriesModelBase
                                                        {
                                                            Continent = Convert.ToString(dr["Continent"]),
                                                            Country = Convert.ToString(dr["Country"]),
                                                            Language = Convert.ToString(dr["Language"]),
                                                            Population = Convert.ToInt32(dr["Population"]),
                                                            Official_Language_Use_Percent = Math.Round(Convert.ToDouble(dr["Official_Language_Use_%"]),2),
                                                            Official_Language_Population_Use_People = Math.Floor(Convert.ToDouble(dr["Official_Language_Population_Use"])),
                                                            Code = Convert.ToString(dr["Code"])
                                                        }
                                    );
            }
            return CountriesModel;
        }

    }
}