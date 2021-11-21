using System;

namespace CreationalPatterns.Foundation.Builder.Toys
{
    class DirectorToy
    {
        private IToyBuilder _toyBuilder;
        public DirectorToy(IToyBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }

        public void CreateToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetBody();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetLegs();
        }

        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }

    public class Implementation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------List Of Toys-----------");
            var toyABuilder = new DirectorToy(new ToyABuilder());

            toyABuilder.CreateToy();
            Toy toyA = toyABuilder.GetToy();
            Console.WriteLine($"{toyA.Model}\n{toyA.Head}\n{toyA.Body}" +
                $"\n{toyA.Limbs}\n{toyA.Legs}");

        }
    }
}
