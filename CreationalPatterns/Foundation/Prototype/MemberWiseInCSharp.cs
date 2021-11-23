using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Foundation.Prototype
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-6.0
    class MemberWiseInCSharp
    {
        static void Main(string[] args)
        {
            //Create an instance of Person and assign values to its fields
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1._idInfor = new IdInfor(6565);

            //Perform a shallow copy of p1 and assign it to p2
            Person p2 = p1.ShallowCopy();

            //Display values of p1, p2
            Console.WriteLine("Orginal values of p1 and p2");
            Console.WriteLine("\tp1 instance values:");
            DisplayValues(p1);
            Console.WriteLine("\tp2 instance values:");
            DisplayValues(p2);

            //Make a deep copy of p1 and assign it to p3
            Person p3 = p1.DeepCopy();
            p1.Name = "George";
            p1.Age = 39;
            p1._idInfor.IdNumber = 8641;
            Console.WriteLine("\nValues of p1, p2, and p3 after changes to p1");
            Console.WriteLine("\tp1 instance values:");
            DisplayValues(p1);
            Console.WriteLine("\n\tp2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("\n\tp3 instance values:");
            DisplayValues(p3);

        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine($"\tName: {p.Name}, Age: {p.Age}\n\tValue: {p._idInfor.IdNumber}");
        }
    }

    public class IdInfor
    {
        public int IdNumber;

        public IdInfor(int idNumber)
        {
            IdNumber = idNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfor _idInfor;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other._idInfor = new IdInfor(_idInfor.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }
}
