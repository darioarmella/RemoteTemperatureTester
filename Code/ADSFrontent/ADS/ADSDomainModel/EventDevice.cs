using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSDomainModel
{
    public class EventDevice
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Location Location { get; set; }
        public Device Device { get; set; }
        public string CustomerIdentification { get; set; }
    }
}
