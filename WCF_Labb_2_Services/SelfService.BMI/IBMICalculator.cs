using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.BMI
{
    [ServiceContract(Namespace = "http://SelfService.BMI")]
    interface IBMICalculator
    {
        [OperationContract]
       double CalculateMyBMI(double heightInMeters, double weight);
    }
}
