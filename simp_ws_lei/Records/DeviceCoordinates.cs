using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public class DeviceCoordinates : ICoordinates
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public DeviceCoordinates(string latitude, string longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
