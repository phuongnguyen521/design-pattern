using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Builder
{
    //https://www.tutorialspoint.com/design_pattern/builder_pattern.htm
    class DirectoryMeals
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new VegBurger());
            meal.addItem(new Coke());
            return meal;
        }
        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new ChickenBurger());
            meal.addItem(new Pepsi());
            return meal;
        }
    }

    class Implementation
    {
        static void Main(string[] args)
        {
            DirectoryMeals meals = new DirectoryMeals();
            Meal vegMeal = meals.prepareVegMeal();
            Console.WriteLine("\tVeg Meal");
            vegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {vegMeal.GetCost()}");

            Meal NonVegMeal = meals.prepareNonVegMeal();
            Console.WriteLine("\n\tNon Veg Meal");
            NonVegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {NonVegMeal.GetCost()}");
        }
    }
}
