using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSDomainModel
{
    public class Device
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public IEnumerable<Sensor> Sensors {get;set;}
    }
}
