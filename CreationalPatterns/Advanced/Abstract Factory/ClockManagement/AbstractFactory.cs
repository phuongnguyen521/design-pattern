using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Abstract_Factory.ClockManagement
{
    public interface IAbstractFactory
    {
        IAnalogWatches GetAnalogWatch();
        IDigitalWatches GetDigitalWatch();
    }

    public class CASIO : IAbstractFactory
    {
        public IAnalogWatches GetAnalogWatch()
        {
            return new CasioMTP("E321B", "Male","44.7 mm", "Mineral","Analog", null, "Stainless Steel", "10 mm","Pin","5 ATM",null, "China", "Japan", "CASIO", 10);
        }

        public IDigitalWatches GetDigitalWatch()
        {
            return new CasioAE("1AVDF", "Male", "43.5 mm", "Plastic", "Digital", "25 mm", "Plastic", "13.5 mm", "Pin", "10 ATM", null, "China", "Japan", "CASIO", 11);
        }
    }

    public class SKMEI : IAbstractFactory
    {
        public IAnalogWatches GetAnalogWatch()
        {
            return new WomanSkmei("SK-1220","Woman", "33.9 mm", "Mineral", "Analog", "21.7 mm", "Stainless Steel", "11.6 mm", "Pin", "3 ATM", null, "China", "CHina", "SKMEI", 5);
        }

        public IDigitalWatches GetDigitalWatch()
        {
            return new ChildSkmei("1484BURD", "Child", "38 mm", "Plastic", "Digital", "22 mm", "Stainless Steel", "15 mm", "Pin", "5 ATM", null, "China", "CHina", "SKMEI", 4);
        }
    }
}
