using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    class Car
    {
        public List<int> KMaddedssincelastride = new List<int>();

        public string Brand { get; set; } //merk
        public string Model { get; set; } // merk
        public int Buildyear { get; set; } //bouwjaar, duh
        public int GastankLit { get; set; }//benzinestand liters
        public string Chassiscolorprimary { get; set; } //kleur
        public string Chassiscolorsecondary { get; set; } // optionele tweede kleur
        public int Banden { get; set; } // hoeveelheid banden
        public string Bandtype { get; set; } //tractor, sport, winter, zomer, auto.
        public int Horsepower { get; set; } //PK
        public string Licenseplate { get; set; } //kentekenplaat
        public int Seats { get; set; } //stoelen
        public string Seatscolor { get; set; }//stoelkleur
        public int Lastmaintenancedate { get; set; } // onderhoudsdatum
        public int GPShoriz { get; set; }// gpslocatie/tracking HO
        public int GPSvertic { get; set; }// gpslocatie/tracking VE
        public int Parkinglocation { get; set; }//parkeerspot
        public bool Manual { get; set; } //manual or not(automatic)
        public bool Maintenance { get; set; } // maintenance
        public int Kilometers { get; set; }//km stand, zie  private kilometers
    
        /////////////////////////////////////////////////////////////////////////

        public void LocateWithGPS(int hor, int ver)
        {
            GPShoriz = hor;
            GPSvertic = ver;
        }
        public void PlanMaintenance()
        {
            //gepland onderhoud
        }
        public void Addgas()
        {
            // benzine toevoegen
        }
        public void Driven(int DistanceinKilometers)
        {
            Kilometers += DistanceinKilometers;
            KMaddedssincelastride.Add(DistanceinKilometers);

            if (DistanceinKilometers > 1000)
            {
                /// 
            }

            if ((Kilometers / 100) > 100)
            {
                ///
            }
        }

        ///////////////////////////////////////////////////////////////////////////////
    }
}
