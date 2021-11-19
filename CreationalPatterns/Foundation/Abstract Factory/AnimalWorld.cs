using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Foundation.Abstract_Factory
{
    //https://www.dofactory.com/net/abstract-factory-design-pattern
    //https://www.tutorialspoint.com/design_pattern/abstract_factory_pattern.htm
    class Implementation
    {
        static void Main(string[] args)
        {
            AnimalWorld animal = null;
            ContinentFactory continent = new AmericaFactory();
            animal = new AnimalWorld(continent);
            animal.RunFoodChain();

            continent = new AfricaFactory();
            animal = new AnimalWorld(continent);
            animal.RunFoodChain();
        }
    }
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            _carnivore = continentFactory.createCarnivore();
            _herbivore = continentFactory.createHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.eat(_herbivore);
        }
    }

    abstract class ContinentFactory
    {
        public abstract Herbivore createHerbivore();
        public abstract Carnivore createCarnivore();
    }

    class AmericaFactory : ContinentFactory
    {
        public override Carnivore createCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore createHerbivore()
        {
            return new Bison();
        }
    }

    class AfricaFactory : ContinentFactory
    {
        public override Carnivore createCarnivore()
        {
            return new Lion();
        }

        public override Herbivore createHerbivore()
        {
            return new Wildebeest();
        }
    }

    abstract class Herbivore { }
    abstract class Carnivore
    {
        public abstract void eat(Herbivore herbivore);
    }

    class Bison : Herbivore { }
    class Wildebeest : Herbivore { }

    class Lion : Carnivore
    {
        public override void eat(Herbivore herbivore)
        {
            Console.WriteLine( this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    class Wolf : Carnivore
    {
        public override void eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
