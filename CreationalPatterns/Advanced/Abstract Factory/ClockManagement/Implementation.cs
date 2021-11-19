using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Abstract_Factory.ClockManagement
{
    class Implementation
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = new CASIO();
            Client client = new Client(factory);
            Console.WriteLine("******CASIO******");
            client.GetSpecificationOfAnalogWatch();
            client.GetSpecificationOfDigitalWatch();

            factory = new SKMEI();
            client = new Client(factory);
            Console.WriteLine("******SKMEI******");
            client.GetSpecificationOfAnalogWatch();
            client.GetSpecificationOfDigitalWatch();
        }
    }
}
