using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Abstract_Factory
{
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }

    class Nokia : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }

    class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
