using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Hobby
{
    [ServiceContract(Namespace = "http://SelfService.Hobby")]
    interface ISearchForChampion
    {
        [OperationContract]
        string GetChampionsByYear(string year);
    }
}
