using System;

namespace CreationalPatterns.Foundation.Builder
{
    //https://www.dofactory.com/net/builder-design-pattern
    class Implementation
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder1 = new ConcreteBuidler1();
            Builder builder2 = new ConcreteBuidler2();

            director.Construct(builder1);
            Product p1 = builder1.GetProduct();
            p1.Show();

            director.Construct(builder2);
            Product p2 = builder2.GetProduct();
            p2.Show();

            Console.ReadKey();
        }
    }
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
