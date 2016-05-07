using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace GalileoServiceAgent.Config
{
    public class ProviderConfig
    {
        public static string Host = ConfigurationManager.AppSettings["DeviceHost"];
    }
}
