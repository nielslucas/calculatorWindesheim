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

        private int Randomnumbers(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void GetGPSLocation(int min, int max)
        {
            GPSLongtitude = Randomnumbers(-10000000, 10000000);
            GPSLatitude = Randomnumbers(-10000000, 10000000);
        }

    }
}
