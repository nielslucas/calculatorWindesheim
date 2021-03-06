﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public partial class Car
    {
        public List<int> KMaddedssincelastride = new List<int>();
        //public string Brand { get; set; } //merk
        //public string Model { get; set; } // merk
        //public int BuildYear { get; set; } //bouwjaar, duh
        //public int GastankLit { get; set; }//benzinestand liters
        //public string ChassisColorPrimary { get; set; } //kleur
        //public string ChassisColorSecondary { get; set; } // optionele tweede kleur
        //public int Tires { get; set; } // hoeveelheid banden
        //public string TireType { get; set; } //tractor, sport, winter, zomer, auto.
        //public int HorsePower { get; set; } //PK
        //public string LicensePlate { get; set; } //kentekenplaat
        //public int Seats { get; set; } //stoelen
        //public string SeatsColor { get; set; }//stoelkleur
        //public int LastMaintenanceDate { get; set; } // onderhoudsdatum                        
        //public int ParkingLocation { get; set; }//parkeerspot
        //public bool Manual { get; set; } //manual or not(automatic)
        //public bool Maintenance { get; set; } // maintenance
        //public int Kilometers { get; set; }//km stand, zie  private kilometers
        public GPSCoordinates GpsCoords = new GPSCoordinates();
       
        /////////////////////////////////////////////////////////////////////////
        public Car() { }

        public Car(string brand,string model,int buildYear,int gasTankLit,string chassisColorPrimary,string chassisColorSecondary,int tires,string tireType,int horsePower,string licensePlate, int seats, string seatsColor, DateTime lastMaintanceData, int parkingLocation,bool manual,bool maintance, int kilometers) {
            Brand = brand;
            Model = model;
            BuildYear = buildYear;
            GastankLit = gasTankLit;
            ChassisColorPrimary = chassisColorPrimary;
            ChassisColorSecondary = chassisColorSecondary;
            Tires = tires;
            TireType = tireType;
            HorsePower = horsePower;
            LicensePlate = licensePlate;
            Seats = seats;
            SeatsColor = seatsColor;
            LastMaintenanceDate = lastMaintanceData;
            ParkingLocation = parkingLocation;
            Manual = Convert.ToByte(manual);
            Maintenance = Convert.ToByte(maintance);
            Kilometers = kilometers;
            GpsCoords.GetGPSLocation();
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
    }
}

