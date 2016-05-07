using ADSDomainModel;
using GalileoServiceAgent.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalileoServiceAgent.Service
{
    public class DeviceServiceAgent
    {
        private DeviceProxi _deviceProxi;

        public DeviceServiceAgent()
        {
            _deviceProxi = new DeviceProxi();
        }

        public EventDevice Get()
        {
            return DeviceProxi.Get().Result;
        }
    }
}
