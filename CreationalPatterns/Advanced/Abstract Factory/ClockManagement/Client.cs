using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Abstract_Factory.ClockManagement
{
    public class Client
    {
        IAnalogWatches analog;
        IDigitalWatches digital;
        public Client(IAbstractFactory factory)
        {
            analog = factory.GetAnalogWatch();
            digital = factory.GetDigitalWatch();
        }

        public void GetSpecificationOfAnalogWatch()
        => analog.GetWatchesDetail();
        public void GetSpecificationOfDigitalWatch()
        => digital.GetWatchesDetail();
    }
}
