using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public class GPSCoordinates
    {    
        public int GPSLongtitude { get; set; } // gpslocatie/tracking LO
        public int GPSLatitude { get; set; }   // gpslocatie/tracking LA

        private int GetRandomint(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void GetGPSLocation()
        {
            GPSLongtitude = GetRandomint(-10000000, 10000000);
            GPSLatitude = GetRandomint(-1000000, 10000000);
        }

    }
}
