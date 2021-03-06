﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS
{
    public partial class CarEditForm : Form
    {
        Car car = new Car();
        //public MainForm Hoofdmenu;


        public CarEditForm()
        {
            InitializeComponent();

        }

        public CarEditForm(Car car)//edit car constructor
        {
            InitializeComponent();
            //AddCar.Hide();
            this.car = car;
            //this.listCars = cars;
            textBox1.Text = this.car.Brand;
            textBox2.Text = this.car.Model;
            textBox3.Text = this.car.BuildYear.ToString();
            textBox4.Text = this.car.Kilometers.ToString();
            textBox5.Text = this.car.GastankLit.ToString();
            textBox6.Text = this.car.LicensePlate;
            textBox7.Text = this.car.ChassisColorPrimary;
            textBox8.Text = this.car.ChassisColorSecondary;
            textBox9.Text = this.car.Tires.ToString();
            textBox10.Text = this.car.TireType;
            textBox11.Text = this.car.HorsePower.ToString();
            textBox12.Text = this.car.Seats.ToString();
            textBox13.Text = this.car.SeatsColor;
            textBox14.Text = this.car.GPSLatitude.ToString();
            textBox15.Text = this.car.GPSLongtitude.ToString();
            textBox16.Text = this.car.ParkingLocation.ToString();
            if (this.car.LastMaintenanceDate != null)
            {
                DTPMaintenance.Value = this.car.LastMaintenanceDate.Value;
            }
            //   Hoofdmenu = hoofdmenu;

            //Fill fleet DropDownList
            Dictionary<int, string> CarFleetList = new Dictionary<int, string>();

            foreach(Fleet fleet in Program.db.Fleets)
            {
                CarFleetList.Add(fleet.ID, fleet.Name);
            }

            cbFleet.DataSource = new BindingSource(CarFleetList, null);
            cbFleet.ValueMember = "Key";
            cbFleet.DisplayMember = "Value";

            if(car.FleetID != null)
            {
                cbFleet.SelectedValue = car.FleetID;
            }

        }
        //Niels
        private void AddCar_Click(object sender, EventArgs e)
        {
            Car tempCar = new Car(
                textBox1.Text, //brand
                textBox2.Text, //modal
                Int32.Parse(textBox3.Text),//buildyear
                Int32.Parse(textBox5.Text), //Benzine
                textBox7.Text, //chassisPrimary
                textBox8.Text, //ChassisSecondary
                Int32.Parse(textBox9.Text), //Tires
                textBox10.Text, //BandType
                Int32.Parse(textBox11.Text), //HorsePower
                textBox6.Text, //Licenseplate
                Int32.Parse(textBox12.Text), //SeatBets
                textBox13.Text, //SeatColor
                DTPMaintenance.Value, //LastMaintence
                Int32.Parse(textBox16.Text), //ParkingLocation
                true,
                false,
                Int32.Parse(textBox4.Text) //KM
                );
            Program.db.Cars.Add(tempCar);
            Program.db.SaveChanges();
        }
        private void button19_Click(object sender, EventArgs e)
        {

            int outcome;

            car.Brand = textBox1.Text;
            textBox1.Text = car.Brand;

            car.Model = textBox2.Text;
            textBox2.Text = car.Model;

            int.TryParse(textBox3.Text, out outcome);
            car.BuildYear = outcome;
            textBox3.Text = car.BuildYear.ToString();

            int.TryParse(textBox4.Text, out outcome);
            car.Kilometers = outcome;
            textBox4.Text = car.Kilometers.ToString();

            int.TryParse(textBox5.Text, out outcome);
            car.GastankLit = outcome;
            textBox5.Text = car.GastankLit.ToString();

            car.LicensePlate = textBox6.Text;
            textBox6.Text = car.LicensePlate;

            car.ChassisColorPrimary = textBox7.Text;
            textBox7.Text = car.ChassisColorPrimary;

            car.ChassisColorSecondary = textBox8.Text;
            textBox8.Text = car.ChassisColorSecondary;

            int.TryParse(textBox9.Text, out outcome);
            car.Tires = outcome;
            textBox9.Text = car.Tires.ToString();

            car.TireType = textBox10.Text;
            textBox10.Text = car.TireType;

            int.TryParse(textBox11.Text, out outcome);
            car.HorsePower = outcome;
            textBox11.Text = car.HorsePower.ToString();

            int.TryParse(textBox12.Text, out outcome);
            car.Seats = outcome;
            textBox12.Text = car.Seats.ToString();

            car.SeatsColor = textBox13.Text;
            textBox13.Text = car.SeatsColor;

            ///checkbox start
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }
            else if (!checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            ///checkbox end
            if (textBox14.Text == "" && textBox15.Text == "")
            {
                car.GpsCoords.GetGPSLocation();
                textBox14.Text = car.GpsCoords.GPSLatitude.ToString();
                textBox15.Text = car.GpsCoords.GPSLongtitude.ToString();
            }

            car.GPSLongtitude = car.GpsCoords.GPSLongtitude;
            car.GPSLatitude = car.GpsCoords.GPSLatitude;

            int.TryParse(textBox16.Text, out outcome);
            car.ParkingLocation = outcome;
            textBox16.Text = car.ParkingLocation.ToString();

            //int.TryParse(textBox17.Text, out outcome);
            car.LastMaintenanceDate = DTPMaintenance.Value;

            car.FleetID = (int)cbFleet.SelectedValue;

            Program.db.SaveChanges();
            Close();
        }
        /////////////////////////List Driven KM///////////////////////////////////////////

        private void button18_Click(object sender, EventArgs e)/// list button "Driven"
        {
            label4.Text = ""; int outcome;
            int.TryParse(textBox18.Text, out outcome);
            car.Driven(outcome);
            int totalDriven = 0;
            foreach (int km in car.KMaddedssincelastride)
            {

                label4.Text += km.ToString() + "\n";
                totalDriven += km;
            }
            label4.Text += String.Format("\n------\n{0}", totalDriven);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car.GpsCoords.GetGPSLocation();
            textBox14.Text = car.GpsCoords.GPSLatitude.ToString();
            textBox15.Text = car.GpsCoords.GPSLongtitude.ToString();

        }



    }
}

