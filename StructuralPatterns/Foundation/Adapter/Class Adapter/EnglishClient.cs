using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Advanced.Adapter
{
    //https://viblo.asia/p/adapter-pattern-part1-class-adapter-4P856Rn35Y3
    //https://gpcoder.com/4483-huong-dan-java-design-pattern-adapter/
    class EnglishClient
    {
        static void Main(string[] args)
        {
            IEnglishTarget target = new TranslatorEtoVAdapter();
            target.send("Hello");
        }
    }
}
