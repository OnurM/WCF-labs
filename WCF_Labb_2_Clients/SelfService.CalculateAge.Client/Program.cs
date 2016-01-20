using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.CalculateAge.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new CalculateAgeClient();
            var x = DateTime.Now;
            Console.Write("Enter your age (YYYY/MM/DD): ");
            var age = Console.ReadLine();
            var parsedAge = DateTime.TryParse(age, out x) ? DateTime.Parse(age) : x;

            Console.WriteLine($"Du är {host.CalculateAge(parsedAge)} år gammal");
            Console.ReadKey();
        }
    }
}
