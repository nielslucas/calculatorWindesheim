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
    public partial class Hoofdmenu : Form
    {
        Car car = new Car("BMW", "whatever", 1009, 500, "Red", "Yellow", 5, "sport", 50, "ADSL3", 4, "Purple", 20, 54, true, false, 200);
        Person person = new Person("Pietje", "Tikkeltje 12", "Jantjestraat", 4, "2-2-2012", "anders", 061956789, 11, new Car());
        public Hoofdmenu()
        {
            InitializeComponent();
            refreshLabels();
           // SetLabels(Person);
        }

        public void refreshLabels()
        {
            label1.Text = car.Brand; 
            label2.Text = car.Model;
            label3.Text = car.BuildYear.ToString();
            label4.Text = car.Kilometers.ToString();
            label5.Text = car.GastankLit.ToString();
            label6.Text = car.LicensePlate;
            label7.Text = car.ChassisColorPrimary;
            label8.Text = car.ChassisColorSecondary;
            label9.Text = car.Tires.ToString();
            label10.Text = car.TireType;
            label11.Text = car.HorsePower.ToString();
            label12.Text = car.Seats.ToString();
            label13.Text = car.SeatsColor;
            label14.Text = car.ParkingLocation.ToString();
            label15.Text = car.LastMaintenanceDate.ToString();
            label56.Text = car.GpsCoords.GPSLatitude.ToString();
            label57.Text = car.GpsCoords.GPSLongtitude.ToString();
            label16.Text = person.Name;
            label17.Text = person.HomeAddress;
            label18.Text = person.WorkAddress;
            label19.Text = person.Age.ToString();
            label20.Text = person.BirthDay.ToString();
            label21.Text = person.Gender;
            label22.Text = person.PhoneNumber.ToString();
            label23.Text = person.CustomerNumber.ToString();
            label24.Text = person.DriversLicense.ToString();
            label25.Text = person.BankAccountNumber;
            label26.Text = person.MoneyOwed.ToString();
        }
        public void setGPS()
        {
            label56.Text = car.GpsCoords.GPSLatitude.ToString();
            label57.Text = car.GpsCoords.GPSLongtitude.ToString();
        }
        //public void SetLabels(Person Person)
        //{
        //    label16.Text = Person.Name;
        //    label17.Text = Person.HomeAddress;
        //    label18.Text = Person.WorkAddress;
        //    label19.Text = Person.Age.ToString();
        //    label20.Text = Person.BirthDay.ToString();
        //    label21.Text = Person.Gender;
        //    label22.Text = Person.PhoneNumber.ToString();
        //    label23.Text = Person.CustomerNumber.ToString();
        //    label24.Text = Person.DriversLicense.ToString();
        //    label25.Text = Person.BankAccountNumber;
        //    label26.Text = Person.MoneyOwed.ToString();
        //}


        private void button1_Click(object sender, System.EventArgs e)
        {   
           
            CarEditForm form = new CarEditForm(car, this);
        
            form.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(person, this);
            form.Show();
        }
        //////////////////////////////////////

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                 
        }
    }
}

