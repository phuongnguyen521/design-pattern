using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Advanced.Adapter
{
    public class VietnameseAdaptee
    {
        public void receive(string words)
        {
            Console.WriteLine("Retrieving words from adaptee");
            Console.WriteLine(words);
        }
    }
}
