using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    class GPSCoordinates
    {    
        public int GPSLongtitude { get; set; } // gpslocatie/tracking LO
        public int GPSLatitude { get; set; }   // gpslocatie/tracking LA

        private int getRandomint(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void GetGPSLocation()
        {
            GPSLongtitude = getRandomint(-10000000, 10000000);
            GPSLatitude = getRandomint(-1000000, 10000000);
        }

    }
}
