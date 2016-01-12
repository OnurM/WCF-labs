using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1.asmx
{
    /// <summary>
    /// Summary description for weather
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Weather : System.Web.Services.WebService
    {

        private readonly string[] _weatherConditions =  {"Sunny","Rainy","Windy","Snowing"};

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetWeatherCondition()
        {
            var random = new Random();
            return _weatherConditions[random.Next(0, 4)];
        }
    }
}
