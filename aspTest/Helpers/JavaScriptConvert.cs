using aspTest.Models.Bases;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace aspTest.Helpers
{

    public static class JavaScriptConvert
    {
        public static IHtmlString SerializeObject(List<CountryCodeModelBase> CCMBList)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            var last = CCMBList.Last();
            string serializedValues = "[ ";
            foreach (var item in CCMBList)
            {
                if (!String.IsNullOrEmpty(item.Language))
                {
                    serializedValues += " { \"label\": \"" + item.Language + "\", \"value\":" + Math.Round( item.Percentage ,2)+ " } ";
                }
                if (item != last) serializedValues += " , ";

            }
            serializedValues += " ]";
            return new HtmlString(serializedValues);
        }
    }
}