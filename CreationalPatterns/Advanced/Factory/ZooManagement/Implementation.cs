using System.Collections.Generic;
using CreationalPatterns.Advanced.Factory.ZooManagement.Animals;
using CreationalPatterns.Advanced.Factory.ZooManagement.Zoo;

namespace CreationalPatterns.Advanced.Factory.ZooManagement
{
    class Implementation
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            LeggedAnimal animal = new LeggedAnimal("1", "Snake", 3, "poinous", "can creep", "black and white", false);
            LeggedAnimal animal1 = new LeggedAnimal("2", "Dog", 3, "cute", "can run, can eat", "black and white");
            BidepalAnimal bidepal = new BidepalAnimal("3", "Peguin", 2, "cute", 2, "swim", "black and white", 2);
            BidepalAnimal bidepal1 = new BidepalAnimal("3", "Pigeon", 1, "heroic", 2, "can fly", null, 2);
            LeggedAnimal animal2 = new LeggedAnimal("2", "Cat", 3, "cute", "can run, can eat", "yellow");
            IZooFactory<Animal> zoo = new LeggedFactory();
            zoo.AddAnAnimal(bidepal, list);
            zoo.AddAnAnimal(animal1, list);
            zoo.GetListAnimal(list);
            //LeggedAnimal animal2 = new LeggedAnimal("2", "Cat", 3, "cute", "can run, can eat", "yellow");
            //zoo.UpdateAnimal(animal2, animal1, list);
            //zoo.GetListAnimal(list);
            //zoo.DeleteAnimal(animal, list);
            //zoo.GetListAnimal(list);
            //zoo = new BidepalFactory();
            //zoo.AddAnAnimal(bidepal, list);
            //zoo.AddAnAnimal(bidepal1, list);
            //zoo.GetListAnimal(list);

        }
    }
}
