using ADSDomainModel;
using GalileoServiceAgent.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GalileoServiceAgent.Proxies
{
    public class DeviceProxi
    {
        public static async Task<EventDevice> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProviderConfig.Host);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/Temperature/");
                if (response.IsSuccessStatusCode)
                {
                    EventDevice eventDevice = await response.Content.ReadAsAsync<EventDevice>();
                    return eventDevice;
                }

                return new EventDevice();
            }
        }
    }
}
