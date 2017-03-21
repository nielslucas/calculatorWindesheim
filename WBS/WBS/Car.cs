//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WBS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Nullable<int> BuildYear { get; set; }
        public Nullable<int> GastankLit { get; set; }
        public string ChassisColorPrimary { get; set; }
        public string ChassisColorSecondary { get; set; }
        public Nullable<int> Tires { get; set; }
        public string TireType { get; set; }
        public Nullable<int> HorsePower { get; set; }
        public string LicensePlate { get; set; }
        public Nullable<int> Seats { get; set; }
        public string SeatsColor { get; set; }
        public Nullable<System.DateTime> LastMaintenanceDate { get; set; }
        public Nullable<int> ParkingLocation { get; set; }
        public Nullable<byte> Manual { get; set; }
        public Nullable<byte> Maintenance { get; set; }
        public Nullable<int> Kilometers { get; set; }
        public Nullable<int> GPSLongtitude { get; set; }
        public Nullable<int> GPSLatitude { get; set; }
        public Nullable<int> Owner { get; set; }
        public Nullable<int> FleetID { get; set; }
    
        public virtual Fleet Fleet { get; set; }
        public virtual Person Person { get; set; }
    }
}
