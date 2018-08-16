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
            CurrencyService service = new CurrencyService();
            Console.WriteLine("Hello World!");
            //Get data from api
            CurrencyRate currency = service.GetCurrencyData();
            Console.WriteLine(currency.Disclaimer);
            foreach (var rate in currency.Rates)
            {
                Console.Write(rate.Key);
                Console.Write(" ");
                Console.WriteLine(rate.Value);
            }
            string input = Console.ReadLine();
            Console.WriteLine("Please write a type currency");
            Console.WriteLine(currency.Rates[input.ToUpper()]);
                

            Console.WriteLine(currency.Rates["DKK"]);

            Console.ReadKey();
        }
    }
}
