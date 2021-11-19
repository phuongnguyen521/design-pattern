using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Advanced.Factory.ZooManagement.Animals;

namespace CreationalPatterns.Advanced.Factory.ZooManagement.Zoo
{
                   
    #region Creator
    public interface IZooFactory<T>
    {
        bool checkTypeAnimal(T t);
        void AddAnAnimal(T t, List<T> u);
        void GetListAnimal(List<T> t);

        void UpdateAnimal(T t, T v, List<T> u);
        void DeleteAnimal(T t, List<T> u);
    }
    #endregion

    #region ConcretedCreator
    public class LeggedFactory : IZooFactory<Animal>
    {
        public bool checkTypeAnimal(Animal leggedAnimal) => leggedAnimal is LeggedAnimal;
        public void AddAnAnimal(Animal leggedAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(leggedAnimal))
            {
                animals.Add(leggedAnimal);
            }
        }

        public void DeleteAnimal(Animal leggedAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(leggedAnimal))
                animals.Remove(leggedAnimal);
        }

        public void GetListAnimal(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                LeggedAnimal LeggedAnimal = animal as LeggedAnimal;
                if (LeggedAnimal is not null)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine(LeggedAnimal._legs == 0 ? "Zero Legged Animal" : "Four Legged Animal");
                    LeggedAnimal.Print();
                }
            }
        }

        public void UpdateAnimal(Animal leggedAnimal, Animal oldLeggedAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(leggedAnimal) && checkTypeAnimal(oldLeggedAnimal))
            {
                int index = animals.IndexOf(oldLeggedAnimal);
                if (index > -1)
                    animals[index] = leggedAnimal;
            }
        }
    }
    public class BidepalFactory : IZooFactory<Animal>
    {
        public bool checkTypeAnimal(Animal bidepalAnimal) => bidepalAnimal is BidepalAnimal;
        public void AddAnAnimal(Animal bidepalAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(bidepalAnimal))
            {
                animals.Add(bidepalAnimal);
            }
        }
        public void DeleteAnimal(Animal bidepalAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(bidepalAnimal))
                animals.Remove(bidepalAnimal);
        }

        public void UpdateAnimal(Animal bidepalAnimal, Animal oldBidepalAnimal, List<Animal> animals)
        {
            if (checkTypeAnimal(bidepalAnimal) && checkTypeAnimal(oldBidepalAnimal))
            {
                int index = animals.IndexOf(oldBidepalAnimal);
                if (index > -1)
                    animals[index] = bidepalAnimal;
            }
        }

        public void GetListAnimal(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                BidepalAnimal bidepalAnimal = animal as BidepalAnimal;
                if (bidepalAnimal is not null)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine(bidepalAnimal._color is not null ? "Bidepal and Flightless Animal" : "Bidepal and Flying Animal");
                    bidepalAnimal.Print();
                }
            }
        }
    }
    #endregion

}
