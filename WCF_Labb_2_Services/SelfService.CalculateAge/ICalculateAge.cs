using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.CalculateAge
{
    [ServiceContract(Namespace = "http://localhost:8080/SelfService.CalculateAge")]
    interface ICalculateAge
    {
        [OperationContract]
        int CalculateAge(DateTime dateOfBirth);
    }
}
