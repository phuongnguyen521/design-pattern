using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Builder
{
    public abstract class Burger : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Wrapper();
        }

        public abstract float price();
    }

    public abstract class Coldrink : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }

    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }

        public override float price()
        {
            return 25.0f;
        }
    }

    public class ChickenBurger : Burger
    {
        public override string name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 50.5f;
        }
    }

    public class Coke : Coldrink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 30.3f;
        }
    }

    public class Pepsi : Coldrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 35.0f;
        }
    }

    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            cost = items.Sum(item => item.price());
            return cost;
        }

        public void ShowItems()
        {
            items.ForEach(item =>
            Console.WriteLine($"Item: {item.name()}\nPacking: {item.packing().Pack()}\nPrice: {item.price()}"));
        }
    }
}
