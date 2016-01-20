using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Hobby.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new SearchForChampionClient();
            Console.Write("Write a year between 1965-2015 to see the heavyweight champion(s) of the year (WBA-title): ");
            Console.WriteLine($"The heavyweight champion(s) were: {host.GetChampionsByYear(Console.ReadLine())}");
            Console.ReadKey();
        }
    }
}
