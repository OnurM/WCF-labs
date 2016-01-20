using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace SelfService.Hobby
{
    class SearchForChampionService : ISearchForChampion
    {

        private Dictionary<string, string> _dict; 
        public SearchForChampionService()
        {
            _dict = new Dictionary<string, string>();
            SetupDict();
        }


        public void SetupDict()
        {
            using (var reader = new StreamReader("~/../../../boxning.txt"))
            {

                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();

                    var elements = line?.Split(new[] { ":", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (elements != null && !_dict.ContainsKey(elements[0]))
                        _dict.Add(elements[0], elements[1]);
                }
            }
        }

        public string GetChampionsByYear(string year)
        {
            return _dict.ContainsKey(year)
                ? _dict[year]
                : "Listan innehåller endast vinnare från årtal mellan 1980-1990";
        }
    }
}
