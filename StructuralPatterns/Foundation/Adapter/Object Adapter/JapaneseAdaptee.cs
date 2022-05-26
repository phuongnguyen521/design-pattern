using System;

namespace StructuralPatterns.Advanced.Adapter
{
    public class JapaneseAdaptee
    {
        public void receive(string words)
        {
            Console.WriteLine("Retrieving words from Adapter");
            Console.WriteLine(words);
        }
    }
}
