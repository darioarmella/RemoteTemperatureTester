using ADSDomainModel;
using GalileoServiceAgent.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalileoServiceAgent.Service
{
    public class DeviceService
    {
        private DeviceProxi _deviceProxi;

        public DeviceService()
        {
            _deviceProxi = new DeviceProxi();
        }

        //public EventDevice Get()
        //{
        //    _deviceProxi.Get();
        //}
    }
}
