using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entiteter;
using Servicelag;

namespace ManueltTestProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine("Hello World!");
            CurrencyRate currency = service.GetJson();
            Console.WriteLine(currency.Disclaimer);
            foreach (var rate in currency.Rates)
            {
                Console.Write(rate.Key);
                Console.Write(" ");
                Console.WriteLine(rate.Value);
            }

            Console.WriteLine(currency.Rates["DKK"]);

            Console.ReadKey();
        }
    }
}
