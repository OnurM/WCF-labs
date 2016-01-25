using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.Hobby
{
    /// <summary>
    /// Summary description for SearchForChampionsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SearchForChampionsService : System.Web.Services.WebService
    {
        private Dictionary<string, string> _champions;

        public SearchForChampionsService()
        {
            _champions = new Dictionary<string, string>();
            SetupDict();
        }
        [WebMethod]
        public void SetupDict()
        {
            //ändra
            using (var reader = new StreamReader(@"C:\Users\Onur\Documents\Visual Studio 2015\Projects\WCF\WCF-labs\WCF_Labb_2_Services\WCF.Hobby\boxning.txt"))
            {

                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();

                    var elements = line?.Split(new[] { ":", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (elements != null && !_champions.ContainsKey(elements[0]))
                        _champions.Add(elements[0], elements[1]);
                }
            }
        }

        [WebMethod]
        public string GetChampionsByYear(string year)
        {
            return _champions.ContainsKey(year)
                ? _champions[year]
                : "Listan innehåller endast vinnare från årtal mellan 1980-1990";
        }
    }
}
