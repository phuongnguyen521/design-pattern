using System;

namespace CreationalPatterns.Foundation.Singleton
{
    //https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm
    public class SingletonPatternDemo
    {
        static void Main(string[] args)
        {
            // illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingletonObject object = new SingletonObject();

            //Get the only object available
            SingletonObject singletonObject = SingletonObject.getInstance();
            singletonObject.showMessage();
        }
    }
    class SingletonObject
    {
        //create an object of SingleObject
        private static SingletonObject instance = new SingletonObject();
        //make the constructor private so that this class cannot be
        //instantiated
        private SingletonObject() { }
        //Get the only object available
        public static SingletonObject getInstance() => instance;

        public void showMessage()
        {
            Console.WriteLine("This is message from Singleton Object");
        }
    }
}
