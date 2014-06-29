using aspTest.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class GroupedCountriesModel : DataBase
    {
        public List<GrupedCountriesModelBase> PopulateGroupedCountriesList()
        {
            System.Diagnostics.Debug.WriteLine(Alpha.GROUPED_COUNTRIES_SELECT);
            DataTable dt = ExecuteQuery(Alpha.GROUPED_COUNTRIES_SELECT);

            List<GrupedCountriesModelBase> GrupedCountriesModel = new List<GrupedCountriesModelBase>();
            foreach (DataRow dr in dt.Rows)
            {
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["continent"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["name"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["language"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["population"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["percentage"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["Official Language Population Use"]));
                //System.Diagnostics.Debug.WriteLine(Convert.ToString(dr["code"]));
                GrupedCountriesModel.Add(new GrupedCountriesModelBase
                                                                {                    
                                                                    Language = Convert.ToString(dr["Language"]),
                                                                    Population_Use = Math.Floor(Convert.ToDouble(dr["SUM_PEPOLE_USING_ONE_LANGUAGE"])),
                                                                    Global_Population_Percent_Use = Math.Round((Convert.ToDouble(dr["SUM_PEPOLE_USING_ONE_LANGUAGE"]) / Convert.ToDouble(dr["SUM_All_POPULATION"]))*100, 2)                   
                                                                }
                                    );
            }
            return GrupedCountriesModel;
        }
    }
}