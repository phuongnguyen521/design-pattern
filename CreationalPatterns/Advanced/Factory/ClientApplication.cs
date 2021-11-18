using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Factory
{
    //https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/
    //https://www.dofactory.com/net/factory-method-design-pattern
    class ClientApplication
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the type card you would like to visit: ");
            String card = Console.ReadLine();
            switch (card.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlantinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            if (factory is not null)
            {
                CreditCard creditCard = factory.GetCreditCard();
                Console.WriteLine("\nyour card detail are below: \n");
                Console.WriteLine($"Card Type: {creditCard.CardType}\nCredit Limit: {creditCard.CreditLimit}\nAnnual Charge: {creditCard.AnnualCharge}");
            }
            Console.ReadKey();
        }
    }
}
