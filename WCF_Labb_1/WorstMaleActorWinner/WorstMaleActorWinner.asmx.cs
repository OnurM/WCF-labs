using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Web.Services;

namespace WorstMaleActorWinner
{
    /// <summary>
    /// Summary description for WorstMaleActorWinner
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WorstMaleActorWinner : System.Web.Services.WebService
    {
        private Dictionary<string, string> _worstMaleActorsWinners;

        public WorstMaleActorWinner()
        {
            _worstMaleActorsWinners = new Dictionary<string, string>();
            SetupWorstMaleActorWinners();
        }

        [WebMethod]
        public void SetupWorstMaleActorWinners()
        {
            using (var reader = new StreamReader(@"C:\Users\Onur\Documents\Visual Studio 2015\Projects\WCF\WCF-labs\WCF_Labb_1\WorstMaleActorWinner\worstActor.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();

                    var elements = line?.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                    if (elements?.Length > 1 && !_worstMaleActorsWinners.ContainsKey(elements[0]))
                        _worstMaleActorsWinners.Add(elements[0], elements[1]);
                }
            }
        }

        [WebMethod]
        public string GetActorByYear(string year)
        {
            return _worstMaleActorsWinners.ContainsKey(year)
                ? _worstMaleActorsWinners[year]
                : "Listan innehåller endast resultat från 1980-2014";
        }
    }
}
