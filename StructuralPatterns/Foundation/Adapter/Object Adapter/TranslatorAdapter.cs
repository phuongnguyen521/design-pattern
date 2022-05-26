using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Advanced.Adapter
{
    public class TranslatorAdapter : IVietnameseTarget
    {
        private JapaneseAdaptee adaptee;

        public TranslatorAdapter(JapaneseAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void send(string words)
        {
            Console.WriteLine($"Reading words: {words}");
            string vietnameseWords = translate(words);
            Console.WriteLine("Sending words...");
            adaptee.receive(words);
        }

        private string translate(string vietnameseWords)
        {
            Console.WriteLine("Translated");
            return "こんにちは";
        }
    }
}
