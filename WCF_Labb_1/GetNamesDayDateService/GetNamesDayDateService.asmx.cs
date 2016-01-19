using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GetNamesDayDateService
{
    /// <summary>
    /// Summary description for GetNamesDayDateService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetNamesDayDateService : System.Web.Services.WebService
    {
        private Dictionary<string, string> _namesDayDictionary;

        
        public GetNamesDayDateService()
        {
            SetupNamesDayDictionary();
        }


        [WebMethod]
        public void SetupNamesDayDictionary()
        {
            _namesDayDictionary = new Dictionary<string,string>();

            using (var reader = new StreamReader(@"C:\Users\Onur\Documents\Visual Studio 2015\Projects\WCF\WCF-labs\WCF_Labb_1\GetNamesDayDateService\Namnsdagar.txt"))
            {

                while (reader.Peek() >= 0)
                {
                    var str = reader.ReadLine();

                    if (str != null)
                    {
                        var strArray = str.Split(new[] { ":", ",", "\n"}, StringSplitOptions.RemoveEmptyEntries);

                        switch (strArray.Length)
                        {
                            case 2:
                                if (!_namesDayDictionary.ContainsKey(strArray[1]))
                                    _namesDayDictionary.Add(strArray[1].ToLower(), strArray[0]);
                                break;
                            case 3:
                                if (!_namesDayDictionary.ContainsKey(strArray[1]))
                                    _namesDayDictionary.Add(strArray[1].ToLower(), strArray[0]);

                                if (!_namesDayDictionary.ContainsKey(strArray[2]))
                                    _namesDayDictionary.Add(strArray[2].ToLower(), strArray[0]);
                                break;
                            case 4:
                                if (!_namesDayDictionary.ContainsKey(strArray[1]))
                                    _namesDayDictionary.Add(strArray[1].ToLower(), strArray[0]);

                                if (!_namesDayDictionary.ContainsKey(strArray[2]))
                                    _namesDayDictionary.Add(strArray[2].ToLower(), strArray[0]);

                                if (!_namesDayDictionary.ContainsKey(strArray[3]))
                                    _namesDayDictionary.Add(strArray[3].ToLower(), strArray[0]);
                                break;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public string GetNamesDayDateByName(string name)
        {
            return _namesDayDictionary.ContainsKey(name.ToLower())
                ? _namesDayDictionary[name.ToLower()]
                : "Namnet du angav finns inte i kalendern";
        }

    }
}
