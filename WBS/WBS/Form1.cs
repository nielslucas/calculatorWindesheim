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

        private void button1_Click(object sender, EventArgs e)
        {
            car.Brand = textBox1.Text;
            textBox1.Text = car.Brand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car.Model = textBox2.Text;
            textBox2.Text = car.Model;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car.Buildyear = Int32.Parse(textBox3.Text);
            textBox3.Text = car.Buildyear.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            car.Kilometers = Int32.Parse(textBox4.Text);
            textBox4.Text = car.Kilometers.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            car.gastankLit = Int32.Parse(textBox5.Text);
            textBox5.Text = car.gastankLit.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            car.Licenseplate = textBox6.Text;
            textBox6.Text = car.Licenseplate;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            car.Chassiscolorprimary = textBox7.Text;
            textBox7.Text = car.Chassiscolorprimary;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            car.Chassiscolorsecondary = textBox8.Text;
            textBox8.Text = car.Chassiscolorsecondary;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            car.Banden = Int32.Parse(textBox9.Text);
            textBox9.Text = car.Banden.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            car.Bandtype = textBox10.Text;
            textBox10.Text = car.Bandtype;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            car.Horsepower = Int32.Parse(textBox11.Text);
            textBox11.Text = car.Horsepower.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            car.seats = Int32.Parse(textBox12.Text);
            textBox12.Text = car.seats.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            car.seatscolor = textBox13.Text;
            textBox13.Text = car.seatscolor;
        }
        private void button14_Click(object sender, EventArgs e) //checkbox button
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }
            else if (!checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
        }
        private void button15_Click(object sender, EventArgs e) // GPS button, hor + ver(textbox)
        {
            car.LocateWithGPS(Int32.Parse(textBox14.Text), Int32.Parse(textBox15.Text));
            textBox14.Text = car.GPShoriz.ToString();
            textBox15.Text = car.GPSvertic.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            car.parkinglocation = Int32.Parse(textBox16.Text);
            textBox16.Text = car.parkinglocation.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            car.lastmaintenancedate = Int32.Parse(textBox17.Text);
            textBox17.Text = car.lastmaintenancedate.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            car.Driven(Int32.Parse(textBox18.Text));
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


    }
}
