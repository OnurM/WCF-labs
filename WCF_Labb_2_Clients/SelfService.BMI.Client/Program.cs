using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.BMI.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new BMICalculatorClient();
            Console.Write("Var vänlig och skriv in din vikt: ");
            var weight = Console.ReadLine().Replace(".",",");
            Console.Write("Var vänlig och skriv in din längd i meter: ");
            var heightInMeters = Console.ReadLine().Replace(".",",");

            var x = 0.0;

            var doubleHeight = double.TryParse(heightInMeters, out x) ? double.Parse(heightInMeters) : 0.0;

            var doubleWeight = double.TryParse(weight, out x) ? double.Parse(weight) : 0.0;

            Console.WriteLine($"Din BMI är: {host.CalculateMyBMI(doubleHeight, doubleWeight).ToString()}");
            Console.ReadKey();
        }
    }
}
