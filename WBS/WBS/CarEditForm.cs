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
        Car Car = new Car();
        GPSCoordinates GPSnumbers = new GPSCoordinates();
        public Hoofdmenu Hoofdmenu;
        public CarEditForm()
        {
            InitializeComponent();
            textBox1.Text = Car.Brand;
        }
        public CarEditForm(Car car, Hoofdmenu hoofdmenu)
        {
            InitializeComponent();
            Car = car;
            textBox1.Text = Car.Brand;
            textBox2.Text = Car.Model;
            textBox3.Text = Car.BuildYear.ToString();
            textBox4.Text = Car.Kilometers.ToString();
            textBox5.Text = Car.GastankLit.ToString();
            textBox6.Text = Car.LicensePlate;
            textBox7.Text = Car.ChassisColorPrimary;
            textBox8.Text = Car.ChassisColorSecondary;
            textBox9.Text = Car.Tires.ToString();
            textBox10.Text = Car.TireType;
            textBox11.Text = Car.HorsePower.ToString();
            textBox12.Text = Car.Seats.ToString();
            textBox13.Text = Car.SeatsColor;
            textBox16.Text = Car.ParkingLocation.ToString();
            textBox17.Text = Car.LastMaintenanceDate.ToString();
            Hoofdmenu = hoofdmenu;
            Hoofdmenu.SetLabels(Car);
        }
        private void button19_Click(object sender, EventArgs e)
        {

            int outcome;
            int outcome2; 

            Car.Brand = textBox1.Text;
            textBox1.Text = Car.Brand;

            Car.Model = textBox2.Text;
            textBox2.Text = Car.Model;

            int.TryParse(textBox3.Text, out outcome);
            Car.BuildYear = outcome;
            textBox3.Text = Car.BuildYear.ToString();

            int.TryParse(textBox4.Text, out outcome);
            Car.Kilometers = outcome;
            textBox4.Text = Car.Kilometers.ToString();

            int.TryParse(textBox5.Text, out outcome);
            Car.GastankLit = outcome;
            textBox5.Text = Car.GastankLit.ToString();

            Car.LicensePlate = textBox6.Text;
            textBox6.Text = Car.LicensePlate;

            Car.ChassisColorPrimary = textBox7.Text;
            textBox7.Text = Car.ChassisColorPrimary;

            Car.ChassisColorSecondary = textBox8.Text;
            textBox8.Text = Car.ChassisColorSecondary;

            int.TryParse(textBox9.Text, out outcome);
            Car.Tires = outcome;
            textBox9.Text = Car.Tires.ToString();

            Car.TireType = textBox10.Text;
            textBox10.Text = Car.TireType;

            int.TryParse(textBox11.Text, out outcome);
            Car.HorsePower = outcome;
            textBox11.Text = Car.HorsePower.ToString();

            int.TryParse(textBox12.Text, out outcome);
            Car.Seats = outcome;
            textBox12.Text = Car.Seats.ToString();

            Car.SeatsColor = textBox13.Text;
            textBox13.Text = Car.SeatsColor;
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

            //Laurens update -> GPSCoordinates ->remove input???
            int.TryParse(textBox14.Text, out outcome); //remove?
            int.TryParse(textBox15.Text, out outcome2); //remove?
            GPSnumbers.GetGPSLocation(outcome, outcome2);// replace/remove?
            textBox14.Text = GPSnumbers.GPSLatitude.ToString();
            textBox15.Text = GPSnumbers.GPSLongtitude.ToString();

            //old before update (look up)-Laurens
            // int.TryParse(textBox14.Text, out outcome);
            // int.TryParse(textBox15.Text, out outcome2);
            //car.LocateWithGPS(outcome, outcome2);
            //textBox14.Text = car.GPShoriz.ToString();
            //textBox15.Text = car.GPSvertic.ToString();

            int.TryParse(textBox16.Text, out outcome);
            Car.ParkingLocation = outcome;
            textBox16.Text = Car.ParkingLocation.ToString();


            int.TryParse(textBox17.Text, out outcome);
            Car.LastMaintenanceDate = outcome;
            textBox17.Text = Car.LastMaintenanceDate.ToString();
        }
        ////////////////////////////////////////////////////////////////////

        private void button18_Click(object sender, EventArgs e)/// list button -> km
        {
            label4.Text = ""; int outcome;
            int.TryParse(textBox18.Text, out outcome);
            Car.Driven(outcome);
            int totalDriven = 0;
            foreach (int km in Car.KMaddedssincelastride)
            {

                label4.Text += km.ToString() + "\n";
                totalDriven += km;
            }
            label4.Text += String.Format("\n------\n{0}", totalDriven);
        }

        private void button1_Click(object sender, EventArgs e)/// list button -> km
        {
            //  Hoofdmenu form = new Hoofdmenu(Car);
            //form.Show();
            Hoofdmenu.SetLabels(Car);
        }
        
        //////////////////////////////////////////////////////////////

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

