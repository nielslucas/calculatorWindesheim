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
        Car Car = new Car("BMW", "whatever", 1009, 500, "Red", "Yellow", 5, "sport", 50, "ADSL3", 4, "Purple", 20, 54, true, false, 200);
        Person Person = new Person("Pietje", "Tikkeltje 12", "Jantjestraat", 4, "2-2-2012", "anders", 061956789, 11, new Car());
        public Hoofdmenu()
        {
            InitializeComponent();
            SetLabels(Car);
            SetLabels(Person);
        }

        public void SetLabels(Car Car)
        {
            label1.Text = Car.Brand;
            label2.Text = Car.Model;
            label3.Text = Car.BuildYear.ToString();
            label4.Text = Car.Kilometers.ToString();
            label5.Text = Car.GastankLit.ToString();
            label6.Text = Car.LicensePlate;
            label7.Text = Car.ChassisColorPrimary;
            label8.Text = Car.ChassisColorSecondary;
            label9.Text = Car.Tires.ToString();
            label10.Text = Car.TireType;
            label11.Text = Car.HorsePower.ToString();
            label12.Text = Car.Seats.ToString();
            label13.Text = Car.SeatsColor;
            label14.Text = Car.ParkingLocation.ToString();
            label15.Text = Car.LastMaintenanceDate.ToString();
        }

        public void SetLabels(Person Person)
        {
            label16.Text = Person.Name;
            label17.Text = Person.HomeAddress;
            label18.Text = Person.WorkAddress;
            label19.Text = Person.Age.ToString();
            label20.Text = Person.BirthDay.ToString();
            label21.Text = Person.Gender;
            label22.Text = Person.PhoneNumber.ToString();
            label23.Text = Person.CustomerNumber.ToString();
            label24.Text = Person.DriversLicense.ToString();
            label25.Text = Person.BankAccountNumber;
            label26.Text = Person.MoneyOwed.ToString();
        }


        private void button1_Click(object sender, System.EventArgs e)
        {   
           
            CarEditForm form = new CarEditForm(Car, this);
        
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(Person, this);
            form.Show();
        }
        //////////////////////////////////////

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                 
        }
    }
}

