using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Foundation.Builder.Toys
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();

        Toy GetToy();
    }

    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public Toy GetToy() => toy;

        public void SetBody()
        {
            toy.Body = "Plastic";
        }

        public void SetHead()
        {
            toy.Head = "1";
        }

        public void SetLegs()
        {
            toy.Legs = "2";
        }

        public void SetLimbs()
        {
            toy.Limbs = "4";
        }

        public void SetModel()
        {
            toy.Model = "Toy A";
        }
    }
    public class ToyBBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public Toy GetToy() => toy;

        public void SetBody()
        {
            toy.Body = "Steel";
        }

        public void SetHead()
        {
            toy.Head = "1";
        }

        public void SetLegs()
        {
            toy.Legs = "2";
        }

        public void SetLimbs()
        {
            toy.Limbs = "4";
        }

        public void SetModel()
        {
            toy.Model = "Toy B";
        }
    }
}
