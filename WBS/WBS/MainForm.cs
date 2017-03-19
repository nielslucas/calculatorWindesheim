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
        public MainForm()
        {
            InitializeComponent();
            foreach (Car car in Program.db.Cars)
            {
                ListCar(car);
            }

            foreach (Person person in Program.db.Persons)
            {
                ListPerson(person);
            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Car car = new Car();
            Program.db.Cars.Add(car);
            CarEditForm form = new CarEditForm(car);
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            Program.db.Persons.Add(person);
            PersonEditForm form = new PersonEditForm(person);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LVCars.Items.Clear();
            foreach (Car car in Program.db.Cars)
            {
                ListCar(car);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LVPersons.Items.Clear();
            foreach (Person person in Program.db.Persons)
            {
                ListPerson(person);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (LVPersons.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(LVPersons.SelectedItems[0].Name, out outcome);
                Person person = Program.db.Persons.Find(outcome);
                PersonEditForm form = new PersonEditForm(person);
                form.Show();
            }
        }
        public void ListCar(Car car)
        {
            //bug: does not refresh ownerID after removing owner. Owner still removed in db
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
            var car = (from cars in Program.db.Cars
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
            var personquery = from persons in Program.db.Persons
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
            var caronquery = from crs in Program.db.Cars
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

            var caronquery = from crs in Program.db.Cars
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
            var caronquery = from crs in Program.db.Cars
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
            if (LVCars.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(LVCars.SelectedItems[0].Name, out outcome);
                Car car = Program.db.Cars.Find(outcome);
                CarEditForm form = new CarEditForm(car);
                form.Show();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVCars.SelectedItems[0].Name, out outcome);
            Car car = Program.db.Cars.Find(outcome);
            Program.db.Cars.Remove(car);
            Program.db.SaveChanges();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int outcome = 1;
            int.TryParse(LVPersons.SelectedItems[0].Name, out outcome);
            Person person = Program.db.Persons.Find(outcome);
            var car = from cars in Program.db.Cars
                      where cars.Owner == person.id
                      select cars;
            Car thiscar = car.First();
            this.Owner = null;
            Program.db.Persons.Remove(person);
            Program.db.SaveChanges();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LVCars.Items.Clear();
            foreach (Car car in Program.db.Cars)
            {
                ListCar(car);
            }
            LVPersons.Items.Clear();
            foreach (Person person in Program.db.Persons)
            {
                ListPerson(person);
            }
        }
    }
}

