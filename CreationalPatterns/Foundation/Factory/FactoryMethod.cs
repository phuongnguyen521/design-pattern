using CreationalPatterns.Foundation;
using System;

namespace CreationalPatterns
{
    public class FactoryMethod
    {
        // https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("circle");
            shape1.draw();
            IShape shape2 = shapeFactory.GetShape("rectangle");
            shape2.draw();
            IShape shape3 = shapeFactory.GetShape("square");
            shape3.draw();
        }
    }

    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method");
        }
    }

    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method");
        }
    }

    public class ShapeFactory
    {
        public IShape GetShape(String shapeType)
        {
            if (String.IsNullOrEmpty(shapeType))
                return null;
            if (shapeType.ToLower().Equals("circle"))
                return new Circle();

            if (shapeType.ToLower().Equals("rectangle"))
                return new Rectangle();

            if (shapeType.ToLower().Equals("square"))
                return new Rectangle();

            return null;
        }
    }
}
