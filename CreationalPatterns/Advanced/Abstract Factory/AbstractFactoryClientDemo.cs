using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Abstract_Factory
{
    //https://www.c-sharpcorner.com/article/abstract-factory-design-pattern-in-c-sharp/
    class AbstractFactoryClientDemo
    {
        static void Main(string[] args)
        {
            MobileClient mobileClient = new MobileClient(new Nokia());
            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(mobileClient.GetSmartPhoneModelDetails());
            Console.WriteLine(mobileClient.GetNormalPhoneModelDetails());
            mobileClient = new MobileClient(new Samsung());
            Console.WriteLine("********* SAMSUNG **********");
            Console.WriteLine(mobileClient.GetSmartPhoneModelDetails());
            Console.WriteLine(mobileClient.GetNormalPhoneModelDetails());
        }
    }

    class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails() => smartPhone.GetModelDetails();

        public string GetNormalPhoneModelDetails() => normalPhone.GetModelDetails();
    }
}
