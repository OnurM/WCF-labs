using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.CalculateThousandthDay.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new CalculateThousandthDayClient();
            Console.Write("Skriv in ditt födelsedagsdatum (ÅÅÅÅ/MM/DD): ");
            var birthDateString = Console.ReadLine();
            var now = DateTime.Now;

            Console.WriteLine($"{Environment.NewLine} Din 1000:e dag kommer att vara: {host.CalculateThousandthDayOfLife(DateTime.TryParse(birthDateString, out now) ? DateTime.Parse(birthDateString) : now).ToShortDateString()}");

            Console.ReadKey();
        }
    }
}
