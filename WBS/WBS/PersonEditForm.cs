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
    public partial class PersonEditForm : Form
    {
        public MainForm Hoofdmenu;
        WBSEntities1 db;
        Car car;
        ListViewItem carslist;
        public PersonEditForm()
        {
            InitializeComponent();


        }
        Person person;
        public PersonEditForm(WBSEntities1 db)//add person constructor
        {
            InitializeComponent();
            button1.Hide();
            button4.Hide();
            this.db = db;
            CBDriverslicense.Checked = true;
            foreach (Car car in db.Cars)
            {
                fillLVCar(car);
            }
        }
        public PersonEditForm(Person person, WBSEntities1 db)//edit person constructor
        {
            InitializeComponent();
            button2.Hide();

            this.person = person;
            this.db = db;
            TBName.Text = person.Name;
            TBHomeAddress.Text = person.HomeAddress;
            TBWorkAddress.Text = person.WorkAddress;
            TBAge.Text = person.Age.ToString();
            DTPBirthday.Value = person.Birthday.Value;
            TBPhoneNumber.Text = person.PhoneNumber.ToString();
            TBCustomerNumber.Text = person.CustomerNumber.ToString();
            CBDriverslicense.Checked = Convert.ToBoolean(person.DriversLicense);
            TBBankAccount.Text = person.BankAccountNumber;
            TBMoneyOwed.Text = person.MoneyOwed.ToString();
            TBGender.Text = person.Gender;

            var car = from cars in db.Cars//see if person has hired car
                      where cars.Owner == person.id
                      select cars;
            if (car.Count() > 0)//if person already has hired a car
            {

                fillLVCar(car.First());
            }
            else
            {
                foreach (Car cars in db.Cars)
                {
                    fillLVCar(cars);
                }
            }
        }

        //Person Person2;
        private bool TextBoxCheck(TextBox box)
        {
            return (box.Text != null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(TBName))
            {
                person.Name = TBName.Text;
                TBName.Text = person.Name;
            }

            if (TextBoxCheck(TBHomeAddress))
            {
                person.HomeAddress = TBHomeAddress.Text;
                TBHomeAddress.Text = person.HomeAddress;
            }
            if (TextBoxCheck(TBWorkAddress))
            {
                person.WorkAddress = TBWorkAddress.Text;
                TBWorkAddress.Text = person.WorkAddress;
            }
            if (TextBoxCheck(TBAge))
            {
                int value = 18;
                int.TryParse(TBAge.Text, out value);
                person.Age = value;
                TBAge.Text = person.Age.ToString();
            }

            person.Birthday = DTPBirthday.Value;
            DTPBirthday.Value = person.Birthday.Value;


            if (TextBoxCheck(TBPhoneNumber))
            {
                int value = 0;
                int.TryParse(TBPhoneNumber.Text, out value);
                person.PhoneNumber = value;
                TBPhoneNumber.Text = person.PhoneNumber.ToString();
            }
            if (TextBoxCheck(TBCustomerNumber))
            {
                int value = 0;
                int.TryParse(TBCustomerNumber.Text, out value);
                person.CustomerNumber = value;
                TBCustomerNumber.Text = person.CustomerNumber.ToString();
            }



            if (CBDriverslicense.Checked)
            {
                person.DriversLicense = 1;

            }
            else if (!CBDriverslicense.Checked)
            {
                person.DriversLicense = 0;
            }
            if (TextBoxCheck(TBBankAccount))
            {
                person.BankAccountNumber = TBBankAccount.Text;
                TBBankAccount.Text = person.BankAccountNumber;
            }
            if (TextBoxCheck(TBMoneyOwed))
            {
                int value = 0;
                int.TryParse(TBMoneyOwed.Text, out value);
                person.MoneyOwed = value;
                TBMoneyOwed.Text = person.MoneyOwed.ToString();
            }
            db.SaveChanges();
        }
        private void fillLVCar(Car car)
        {
            string[] cardata = { car.Brand, car.LicensePlate, car.ParkingLocation.ToString() };
            carslist = new ListViewItem(cardata);
            carslist.Name = car.id.ToString();
            LVCar.Items.Add(carslist);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            person.ReturnCar(int.Parse(LVCar.SelectedItems[0].Name), value);
            db.SaveChanges();
            LVCar.Items.Clear();
            foreach (Car car in db.Cars)
            {
                fillLVCar(car);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Person tempPerson2 = new Person(TBName.Text, TBHomeAddress.Text, TBWorkAddress.Text, Int32.Parse(TBAge.Text), DTPBirthday.Value, "default", Int32.Parse(TBPhoneNumber.Text), Int32.Parse(TBCustomerNumber.Text), TBBankAccount.Text);
            if (LVCar.SelectedItems.Count > 0)
            {
                int value = 0;
                int.TryParse(textBox9.Text, out value);
                tempPerson2.HireCar(int.Parse(LVCar.SelectedItems[0].Name), value);
            }
            db.Persons.Add(tempPerson2);
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            person.HireCar(int.Parse(LVCar.SelectedItems[0].Name), value);
            db.SaveChanges();
            var car = from cars in db.Cars//see if person has hired car
                      where cars.Owner == person.id
                      select cars;
            LVCar.Items.Clear();
            fillLVCar(car.First());

        }
    }
}
