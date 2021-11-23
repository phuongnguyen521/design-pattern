using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Prototype
{
    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
    }

    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string Website { get; set; }
        public Address address { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nTwitter Account: {TwitterAccount}" +
                $"\nWebsite: {Website}\nCity: {address.City}" +
                $"\nState:{address.State}");
        }
    }

    public class Address1 : ICloneable
    {
        public string State { get; set; }
        public string City { get; set;}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class AuthorForDeepShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string Website { get; set; }
        public Address1 address { get; set; }
        public object Clone()
        {
            AuthorForDeepShallowCopy obj = (AuthorForDeepShallowCopy)this.MemberwiseClone();
            obj.address = (Address1)this.address.Clone();
            return obj;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nTwitter Account: {TwitterAccount}" +
                $"\nWebsite: {Website}\nCity: {address.City}" +
                $"\nState:{address.State}");
        }
    }


}
