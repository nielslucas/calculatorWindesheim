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
    public partial class Form1 : Form
    {
        Car car = new Car();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = car.Brand;
        }
        private void button19_Click(object sender, EventArgs e)
        {

            int outcome;
            int outcome2;

            car.Brand = textBox1.Text;
            textBox1.Text = car.Brand;

            car.Model = textBox2.Text;
            textBox2.Text = car.Model;

            int.TryParse(textBox3.Text, out outcome);
            car.Buildyear = outcome;
            textBox3.Text = car.Buildyear.ToString();

            int.TryParse(textBox4.Text, out outcome);
            car.Kilometers = outcome;
            textBox4.Text = car.Kilometers.ToString();

            int.TryParse(textBox5.Text, out outcome);
            car.GastankLit = outcome;
            textBox5.Text = car.GastankLit.ToString();

            car.Licenseplate = textBox6.Text;
            textBox6.Text = car.Licenseplate;

            car.Chassiscolorprimary = textBox7.Text;
            textBox7.Text = car.Chassiscolorprimary;

            car.Chassiscolorsecondary = textBox8.Text;
            textBox8.Text = car.Chassiscolorsecondary;

            int.TryParse(textBox9.Text, out outcome);
            car.Banden = outcome;
            textBox9.Text = car.Banden.ToString();

            car.Bandtype = textBox10.Text;
            textBox10.Text = car.Bandtype;

            int.TryParse(textBox11.Text, out outcome);
            car.Horsepower = outcome;
            textBox11.Text = car.Horsepower.ToString();

            int.TryParse(textBox12.Text, out outcome);
            car.Seats = outcome;
            textBox12.Text = car.Seats.ToString();

            car.Seatscolor = textBox13.Text;
            textBox13.Text = car.Seatscolor;
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
            int.TryParse(textBox14.Text, out outcome);
            int.TryParse(textBox15.Text, out outcome2);
            car.LocateWithGPS(outcome, outcome2);
            textBox14.Text = car.GPShoriz.ToString();
            textBox15.Text = car.GPSvertic.ToString();

            int.TryParse(textBox16.Text, out outcome);
            car.Parkinglocation = outcome;
            textBox16.Text = car.Parkinglocation.ToString();


            int.TryParse(textBox17.Text, out outcome);
            car.Lastmaintenancedate = outcome;
            textBox17.Text = car.Lastmaintenancedate.ToString();
        }
        ////////////////////////////////////////////////////////////////////

        private void button18_Click(object sender, EventArgs e)/// list button -> km
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

