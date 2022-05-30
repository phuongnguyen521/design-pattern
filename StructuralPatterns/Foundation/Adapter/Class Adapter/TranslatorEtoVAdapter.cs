using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Advanced.Adapter
{
    public class TranslatorEtoVAdapter : VietnameseAdaptee, IEnglishTarget
    {
        public void send(string words)
        {
            Console.WriteLine($"Reading words: {words}");
            string englishWords = translate(words);
            Console.WriteLine("Sending words...");
            receive(englishWords);
        }

        private string translate(string englishWords)
        {
            Console.WriteLine("Translated");
            return "Xin Chao";
        }
    }
}
