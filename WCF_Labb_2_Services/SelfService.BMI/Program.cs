using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8080/SelfService.BMI");

            var selfServiceHost = new ServiceHost(typeof (BMICalculatorService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint(typeof (IBMICalculator), new WSHttpBinding(), "BMICalculatorService");
                var sMBehavior = new ServiceMetadataBehavior() {HttpGetEnabled = true};
                selfServiceHost.Description.Behaviors.Add(sMBehavior);


                selfServiceHost.Open();
                Console.WriteLine("Tjästen är nu startad och körs..");

                Console.WriteLine(Environment.NewLine + "Tryck på valfri knapp för att avsluta tjänsten!");
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Ett kommunikationsfel har inträffat: {exc.Message}");
                Console.ReadKey();
            }
            finally
            {
                selfServiceHost.Close();
            }
        }
    }
}
