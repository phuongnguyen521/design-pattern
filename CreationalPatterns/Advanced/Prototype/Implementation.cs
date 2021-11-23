using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Prototype
{
    public class Implementation
    {
        static void Main(string[] args)
        {
            ShallowCopy();
            DeepShallowCopy();
        }

        public static void ShallowCopy()
        {
            Console.WriteLine("Shallow Copy");
            AuthorForShallowCopy origin = new AuthorForShallowCopy()
            {
                Name = "Phuong",
                TwitterAccount = "https://twitter.com",
                Website = "http://tiki.com",
                address = new Address()
                {
                    City = "HCM",
                    State = "Southern area"
                }
            };
            AuthorForShallowCopy copy = (AuthorForShallowCopy)origin.Clone();
            copy.Name = "Mr.Changer";
            copy.TwitterAccount = "https://twitter.com/MrChanger";
            copy.Website = "https://MrChanger.com";
            copy.address.State = "Karnataka";
            copy.address.City = "Manglore";
            Console.WriteLine("Original: ");
            origin.Display();
            Console.WriteLine("Copy: ");
            copy.Display();
        }
        public static void DeepShallowCopy()
        {
            Console.WriteLine("\nDeep Shallow Copy");
            AuthorForDeepShallowCopy origin = new AuthorForDeepShallowCopy()
            {
                Name = "Phuong",
                TwitterAccount = "https://twitter.com",
                Website = "http://tiki.com",
                address = new Address1()
                {
                    City = "HCM",
                    State = "Southern area"
                }
            };
            AuthorForDeepShallowCopy copy = (AuthorForDeepShallowCopy)origin.Clone();
            copy.Name = "Mr.Changer";
            copy.TwitterAccount = "https://twitter.com/MrChanger";
            copy.Website = "https://MrChanger.com";
            copy.address.State = "Karnataka";
            copy.address.City = "Manglore";
            Console.WriteLine("Original: ");
            origin.Display();
            Console.WriteLine("Copy: ");
            copy.Display();
        }
    }
}
