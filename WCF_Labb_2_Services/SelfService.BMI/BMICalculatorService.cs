using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.BMI
{
    public class BMICalculatorService : IBMICalculator
    {
        public double CalculateMyBMI(double heightInMeters, double weight)
        {
            return weight / (heightInMeters * heightInMeters);
        }
    }
}
