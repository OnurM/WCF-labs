using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8080/SelfService.CalculateAge");

            var selfServiceHost = new ServiceHost(typeof(CalculateAgeService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint(typeof (ICalculateAge), new WSHttpBinding(), "CalculateAgeService");
                var sMBehavior = new ServiceMetadataBehavior() {HttpGetEnabled = true};
                selfServiceHost.Description.Behaviors.Add(sMBehavior);

                selfServiceHost.Open();
                Console.WriteLine("Tjänsten är nu igång och körs..");
                Console.WriteLine($"{Environment.NewLine} Tryck på valfri knapp för att stänga ned tjänsten");
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Ett kommunikationsfel har uppstått: {exc.Message}");
                Console.ReadKey();
            }
            finally
            {
                selfServiceHost.Close();
            }
        }
    }
}
