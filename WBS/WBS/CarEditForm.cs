using System;
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
        List<Car> listCars;

        public CarEditForm()
        {
            InitializeComponent();

        }
        public CarEditForm(List<Car> cars)//add car constructor
        {
            InitializeComponent();
            listCars = cars;
            button19.Hide();
        }
        public CarEditForm(Car car)//edit car constructor
        {
            InitializeComponent();
            AddCar.Hide();
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
            textBox16.Text = this.car.ParkingLocation.ToString();
            textBox17.Text = this.car.LastMaintenanceDate.ToString();
         //   Hoofdmenu = hoofdmenu;
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
                DateTime.Parse(textBox17.Text), //LastMaintence
                Int32.Parse(textBox16.Text), //ParkingLocation
                true,
                false,
                Int32.Parse(textBox4.Text) //KM
                );
            listCars.Add(tempCar);
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

            ///checkbox start - Laurens
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }
            else if (!checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            ///checkbox end
            
            car.GpsCoords.GetGPSLocation();
            textBox14.Text = car.GpsCoords.GPSLatitude.ToString();
            textBox15.Text = car.GpsCoords.GPSLongtitude.ToString();

            int.TryParse(textBox16.Text, out outcome);
            car.ParkingLocation = outcome;
            textBox16.Text = car.ParkingLocation.ToString();


            //int.TryParse(textBox17.Text, out outcome);
            car.LastMaintenanceDate = DateTime.Parse(textBox17.Text);
            textBox17.Text = car.LastMaintenanceDate.ToString();
        
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
        //////////////////////////JUNK//////////////////////////////////// -Laurens

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}

