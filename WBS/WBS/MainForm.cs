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
    public partial class MainForm : Form
    {
        //Car car = new Car("BMW", "whatever", 1009, 500, "Red", "Yellow", 5, "sport", 50, "ADSL3", 4, "Purple", 20, 54, true, false, 200);
        //Person person = new Person("Pietje", "Tikkeltje 12", "Jantjestraat", 4, "2-2-2012", "anders", 061956789, 11, new Car());

        //List<Car> cars = new List<Car>();
        //List<Person> persons = new List<Person>();

        WBSEntities1 db = new WBSEntities1();

        public MainForm()
        {
            InitializeComponent();
            foreach (Car car in db.Cars)
            {
                ListCar(car);
            }

            foreach (Person person in db.Persons)
            {
                ListPerson(person);
            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            CarEditForm form = new CarEditForm(db);
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(db);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LVCars.Items.Clear();
            foreach (Car car in db.Cars)
            {
                ListCar(car);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LVPersons.Items.Clear();
            foreach (Person person in db.Persons)
            {
                ListPerson(person);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVPersons.SelectedItems[0].Name, out outcome);
            Person person = db.Persons.Find(outcome);
            PersonEditForm form = new PersonEditForm(person, db);
            form.Show();
        }
        public void ListCar(Car car)
        {
            
            string[] mycar = { car.Brand, car.Model, car.BuildYear.ToString(), car.Kilometers.ToString(), car.GastankLit.ToString(), car.LicensePlate, car.ChassisColorPrimary, car.ChassisColorSecondary, car.Tires.ToString(), car.Seats.ToString(), car.HorsePower.ToString(), car.ParkingLocation.ToString(), car.LastMaintenanceDate.Value.ToShortDateString(), car.GPSLatitude.ToString(), car.GPSLongtitude.ToString(), car.Owner.ToString() };

            ListViewItem carlist = new ListViewItem(mycar);
            carlist.Name = car.id.ToString();
            LVCars.Items.Add(carlist);
        }
        //public void ListCar(List<Car> cars) ///function - Laurens
        //{
        //    listView1.Items.Clear();


        //    foreach (Car car in cars)
        //    {
        //        String carOwner = "";
        //        if (car.Owner != null)
        //        {
        //            carOwner = car.Owner.ToString();
        //        }
        //        string[] mycar = { car.Brand, car.Model, car.BuildYear.ToString(), car.Kilometers.ToString(), car.GastankLit.ToString(), car.LicensePlate, car.ChassisColorPrimary, car.ChassisColorSecondary, car.Tires.ToString(), car.Seats.ToString(), car.HorsePower.ToString(), car.ParkingLocation.ToString(), car.LastMaintenanceDate.Value.ToShortDateString(), car.GPSLatitude.ToString(), car.GPSLongtitude.ToString(), carOwner };

        //        ListViewItem carlist = new ListViewItem(mycar); //TEST// - Laurens
        //        listView1.Items.Add(carlist);
        //    }
        // }
        public void ListPerson(Person person) ///function - Laurens
        {
            
                string carLicensePlate = "";
                var car = (from cars in db.Cars
                           where cars.Owner == person.id
                           select cars);
                if (car.Count() > 0)
                {
                    carLicensePlate = car.First().LicensePlate;
                }
                string[] myperson = { person.Name, person.HomeAddress, person.WorkAddress, person.Age.ToString(), person.Birthday.ToString(), person.Gender, person.PhoneNumber.ToString(), person.CustomerNumber.ToString(), person.DriversLicense.ToString(), person.BankAccountNumber, person.MoneyOwed.ToString(), carLicensePlate };

                ListViewItem personlist = new ListViewItem(myperson.ToArray<String>());
                personlist.Name = person.id.ToString();
                LVPersons.Items.Add(personlist);
            
        }
        //public void ListPerson(List<Person> persons) ///function - Laurens
        //{
        //    LVPersons.Items.Clear();
        //    foreach (Person person in persons)
        //    {
        //        string carLicensePlate = "";
        //        var car = (from cars in db.Cars
        //                   where cars.Owner == person.id
        //                   select cars);
        //        if (car.Count() > 0)
        //        {
        //            carLicensePlate = car.First().LicensePlate;
        //        }
        //        string[] myperson = { person.Name, person.HomeAddress, person.WorkAddress, person.Age.ToString(), person.Birthday.ToString(), person.Gender, person.PhoneNumber.ToString(), person.CustomerNumber.ToString(), person.DriversLicense.ToString(), person.BankAccountNumber, person.MoneyOwed.ToString(), carLicensePlate };

        //        ListViewItem personlist = new ListViewItem(myperson);
        //        personlist.Name = person.id.ToString();
        //        LVPersons.Items.Add(personlist);
        //    }
        //}
        private void button3_Click(object sender, EventArgs e)//Name filter - Laurens
        {
            var personquery = from persons in db.Persons
                              orderby persons.Name
                              select persons;

            LVPersons.Items.Clear();
            foreach (Person person in personquery.ToList())
            {
                ListPerson(person);
            }
            

        }

        private void button5_Click(object sender, EventArgs e)//Brand Car - Laurens
        {
            var caronquery = from crs in db.Cars
                             orderby crs.Brand
                             select crs;
            LVCars.Items.Clear();
            foreach (Car car in caronquery.ToList())
            {
                ListCar(car);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Licenseplate - Laurens
        {

            var caronquery = from crs in db.Cars
                                 //where crs.LicensePlate.Substring(0,1).ToCharArray()[0] >'e' 
                             orderby crs.LicensePlate
                             select crs;
            LVCars.Items.Clear();
            foreach (Car car in caronquery.ToList())
            {
                ListCar(car);
            }
        }

        private void button6_Click(object sender, EventArgs e)//parkinglocation - Laurens
        {
            var caronquery = from crs in db.Cars
                             orderby crs.LicensePlate
                             select crs;
            LVCars.Items.Clear();
            foreach (Car car in caronquery.ToList())
            {
                ListCar(car);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVCars.SelectedItems[0].Name, out outcome);
            Car car = db.Cars.Find(outcome);
            CarEditForm form = new CarEditForm(car, db);
            form.Show();
        }
        private void button14_Click_1(object sender, EventArgs e)// exit button - Laurens
        {
            Application.Exit();
        }
        /////////////////////////TRASH///////////////////////////
        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVCars.SelectedItems[0].Name, out outcome);
            Car car = db.Cars.Find(outcome);
            db.Cars.Remove(car);
            db.SaveChanges();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVPersons.SelectedItems[0].Name, out outcome);
            Person person = db.Persons.Find(outcome);
            db.Persons.Remove(person);
            db.SaveChanges();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LVCars.Items.Clear();
            foreach (Car car in db.Cars)
            {
                ListCar(car);
            }
            LVPersons.Items.Clear();
            foreach (Person person in db.Persons)
            {
                ListPerson(person);
            }
        }
    }
}

