using System;
using System.Threading;

namespace BootcampAppDomainData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching current domanin");
            // use current appDomain, and store some data
            AppDomain domain = System.AppDomain.CurrentDomain;
            Console.WriteLine("Setting appDomain data");
            string name = "MyData";
            string value = "Some data to store";
            domain.SetData(name, value);
            Console.WriteLine("Fetching Domain Data");
            Console.WriteLine("The data found for key {0} is {1}",
                name, domain.GetData(name));
            Console.ReadLine();
        }
    }
}
