using ADSDomainModel;
using GalileoServiceAgent.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADSService
{
    public class DeviceService
    {
        private DeviceServiceAgent _deviceServiceAgent;

        public DeviceService()
        {
            _deviceServiceAgent = new DeviceServiceAgent();
        }

        public EventDevice Get()
        {
            return _deviceServiceAgent.Get();
        }
    }
}
