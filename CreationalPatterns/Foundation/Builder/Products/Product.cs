using System;
using System.Collections.Generic;

namespace CreationalPatterns.Foundation.Builder
{
    class Product
    {
        private List<string> _parts = new List<string>();
        public void Add (string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts ------");
            _parts.ForEach(parts => Console.WriteLine(parts));
        }
    }
}
