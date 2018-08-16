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
            Console.WriteLine(service.GetJson());
            Console.ReadKey();
        }
    }
}
