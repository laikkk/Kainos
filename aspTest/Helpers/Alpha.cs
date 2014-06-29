using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspTest.Helpers
{

    public static class Alpha
    {
        static string host = "ec2-54-225-101-124.compute-1.amazonaws.com",
                      port = "5432",
                      user = "mmmwsvrkwfstit",
                      password = "vlliFqilBOUVyWVY-FZfV50Wa3",
                      database = "ddehqcgsacci3g";

        static public string COUNTRIES_SELECT = "SELECT c.continent as \"Continent\", " +
                                                         "c.name as \"Country\", " +
                                                         "cl.language as \"Language\",  " +
                                                         "c.population as \"Population\", " +
                                                         "cl.percentage as \"Official_Language_Use_%\", " +
                                                         "cl.percentage*c.population as \"Official_Language_Population_Use\", " +
                                                         "c.code as \"Code\" " +
                                                    "FROM country c " +
                                                    "JOIN countryLanguage cl " +
                                                    "ON c.code = cl.countrycode " +
                                                    "WHERE cl.isofficial = true " +
                                                    "ORDER BY c.continent ASC, c.name ASC, cl.percentage DESC;";

        static public string GROUPED_COUNTRIES_SELECT = "SELECT DISTINCT  cl.language ," +
                                                                            "(SELECT SUM(co.population) FROM country co LEFT JOIN countryLanguage cll ON co.code = cll.countrycode WHERE  cll.language = cl.language) as SUM_PEPOLE_USING_ONE_LANGUAGE, " +
                                                                            "(SELECT SUM(population) FROM country) as \"SUM_All_POPULATION\" " +
                                                                        "FROM country c " +
                                                                        "JOIN countryLanguage cl " +
                                                                        "ON c.code = cl.countrycode " +
                                                                        "ORDER BY SUM_PEPOLE_USING_ONE_LANGUAGE DESC, cl.language ASC";

        static public string COUNTRY_CODE_PREPARED_SELECT = "SELECT c.code, c.name, cl.language, cl.percentage, SUM(cl.percentage) " +
                                                                    "FROM country c " +
                                                                    "JOIN countryLanguage cl " +
                                                                    "ON c.code = cl.countrycode " +
                                                                    "WHERE c.code = :countryCode " +
                                                                    "GROUP BY c.code, c.name, cl.language, cl.percentage";


        static public string CONNECTION_STRING = String.Format("Server=" + host + ";Port=" + port + ";User Id=" + user + ";Password=" + password + ";Database=" + database + ";Protocol=3;SSL=true;SslMode=Require");

    }
}