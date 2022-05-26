using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Advanced.Adapter
{
    public interface IEnglishTarget
    {
        public void send(string words);
    }
}
