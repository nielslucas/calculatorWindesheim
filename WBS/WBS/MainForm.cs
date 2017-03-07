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
        Car car = new Car("BMW", "whatever", 1009, 500, "Red", "Yellow", 5, "sport", 50, "ADSL3", 4, "Purple", 20, 54, true, false, 200);
        Person person = new Person("Pietje", "Tikkeltje 12", "Jantjestraat", 4, "2-2-2012", "anders", 061956789, 11, new Car());

        List<Car> cars = new List<Car>();
        List<Person> persons = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
            ListCar();
            ListPerson();
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            CarEditForm form = new CarEditForm(car, this, cars);
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(person, this, persons);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Car car in cars)
            {
                string[] carData = { car.Brand, car.Model, car.BuildYear.ToString(), car.Kilometers.ToString(), car.GastankLit.ToString(), car.LicensePlate, car.ChassisColorPrimary, car.ChassisColorSecondary, car.Tires.ToString(), car.Seats.ToString(), car.HorsePower.ToString(), car.ParkingLocation.ToString(), car.LastMaintenanceDate.ToString(), car.GpsCoords.GPSLatitude.ToString(), car.GpsCoords.GPSLongtitude.ToString() };
                ListViewItem carList = new ListViewItem(carData);
                listView1.Items.Add(carList);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            foreach (Person person in persons)
            {
                string[] mydata = { person.Name, person.HomeAddress, person.WorkAddress, person.Age.ToString() };
                ListViewItem carlist = new ListViewItem(mydata); 
                listView2.Items.Add(carlist);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Person person = persons.ElementAt(listView2.SelectedIndices[0]);
            PersonEditForm form = new PersonEditForm(person, this, persons);
            form.Show();
        }
        public void ListCar() 
        {
            listView1.Items.Clear();
            foreach (Car car in cars)
            {
                string[] mycar = { car.Brand, car.Model, car.BuildYear.ToString(), car.Kilometers.ToString(), car.GastankLit.ToString(), car.LicensePlate };

                ListViewItem carlist = new ListViewItem(mycar); 
                listView1.Items.Add(carlist);
            }

        }
        public void ListCar(List<Car> cars) ///function - Laurens
        {
            listView1.Items.Clear();
            foreach (Car car in cars)
            {
                string[] mycar = { car.Brand, car.Model, car.BuildYear.ToString(), car.Kilometers.ToString(), car.GastankLit.ToString(), car.LicensePlate};

                ListViewItem carlist = new ListViewItem(mycar); //TEST// - Laurens
                listView1.Items.Add(carlist);
            }

        }
        public void ListPerson() ///function - Laurens
        {
            listView2.Items.Clear();
            foreach (Person person in persons)
            {
                string[] myperson = { person.Name, person.HomeAddress, person.WorkAddress, person.Age.ToString() };

                ListViewItem personlist = new ListViewItem(myperson); 
                listView2.Items.Add(personlist);
            }
        }
        private void button3_Click(object sender, EventArgs e)//Name filter - Laurens
        {
            var personquery = from per in persons
                              orderby per.Name
                              select per;

            persons = personquery.ToList();
            ListPerson();

        }

        private void button5_Click(object sender, EventArgs e)//Brand Car - Laurens
        {
            var caronquery = from crs in cars
                             orderby crs.Brand
                             select crs;

            cars = caronquery.ToList();
            ListCar();
        }

        private void button4_Click(object sender, EventArgs e)//Licenseplate - Laurens
        {
            
            var caronquery = from crs in cars
                             where crs.LicensePlate.Substring(0,1).ToCharArray()[0] >'e' 
                             orderby crs.LicensePlate
                             select crs;

            
            ListCar(caronquery.ToList());
        }

        private void button6_Click(object sender, EventArgs e)//parkinglocation - Laurens
        {
            var caronquery = from crs in cars
                             orderby crs.ParkingLocation
                             select crs;

            cars = new List<Car>(caronquery.ToArray());
            ListCar();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Car car = cars.ElementAt(listView1.SelectedIndices[0]);
            CarEditForm form = new CarEditForm(car, this, cars);
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
        private void MainForm_Load(object sender, EventArgs e)
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
            listView1.SelectedItems[0].Remove();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listView2.SelectedItems[0].Remove();
        }

     
    }
}

