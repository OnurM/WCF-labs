using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services;

namespace AnimatedOscarWinningMovies
{
    /// <summary>
    /// Summary description for AnimatedOscarWinningMovie
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AnimatedOscarWinningMovie : System.Web.Services.WebService
    {
        private Dictionary<string, string> _winningMovies;

        public AnimatedOscarWinningMovie()
        {
            _winningMovies = new Dictionary<string, string>();
            SetupOscarWinningMovies();
        }

        [WebMethod]
        public void SetupOscarWinningMovies()
        {
            using (var reader = new StreamReader(@"C:\Users\Onur\Documents\Visual Studio 2015\Projects\WCF\WCF-labs\WCF_Labb_1\AnimatedOscarWinningMovies\animerad-film.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();

                    if (line != null)
                    {
                        var elements = line.Split(new[] { "\n", ":" }, StringSplitOptions.RemoveEmptyEntries);

                        if (elements.Length > 1 && !_winningMovies.ContainsKey(elements[0]))
                            _winningMovies.Add(elements[0], elements[1]);
                    }
                }
            }
        }

        [WebMethod]
        public string GetMovieByYear(string year)
        {
            return _winningMovies.ContainsKey(year)
                ? _winningMovies[year]
                : "Can only find the movies between 2001-2009";
        }

    }
}
