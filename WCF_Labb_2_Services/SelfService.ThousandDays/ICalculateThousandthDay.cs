using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.ThousandDays
{
    [ServiceContract(Namespace = "http://localhost:8080/SelfService.ThousandDays")]
    interface ICalculateThousandthDay
    {
        [OperationContract]
        DateTime CalculateThousandthDayOfLife(DateTime dateOfBirth);
    }
}
