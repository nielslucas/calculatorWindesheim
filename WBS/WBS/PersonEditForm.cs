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

        //  Car car; // personeditform never used - Laurens
        ListViewItem carslist;
        public PersonEditForm()
        {
            InitializeComponent();
        }
        Person person;

        public PersonEditForm(Person person)//edit person constructor
        {
            InitializeComponent();
            //button2.Hide();
            this.person = person;
            TBName.Text = person.Name;
            TBHomeAddress.Text = person.HomeAddress;
            TBWorkAddress.Text = person.WorkAddress;
            TBAge.Text = person.Age.ToString();
            if (person.Birthday != null)
            {
                DTPBirthday.Value = person.Birthday.Value;
            }
            TBPhoneNumber.Text = person.PhoneNumber.ToString();
            TBCustomerNumber.Text = person.CustomerNumber.ToString();
            CBDriverslicense.Checked = Convert.ToBoolean(person.DriversLicense);
            TBBankAccount.Text = person.BankAccountNumber;
            TBMoneyOwed.Text = person.MoneyOwed.ToString();
            TBGender.Text = person.Gender;

            var car = from cars in Program.db.Cars//see if person has hired car
                      where cars.Owner == person.id
                      select cars;
            if (car.Count() > 0)//if person already has hired a car
            {

                fillLVCar(car.First());
            }
            else
            {
                fillLVCARNoOwners();
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

            if (TextBoxCheck(TBGender))
            {
                person.Gender = TBGender.Text;

            }
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
            if (LVCar.SelectedItems.Count > 0)//if a car to be hired is selected, hire it
            {
                int value = 0;
                int.TryParse(textBox9.Text, out value);
                person.HireCar(int.Parse(LVCar.SelectedItems[0].Name), value);
            }
            Program.db.SaveChanges();
            Close();
        }
        private void fillLVCar(Car car)
        {
            string[] cardata = { car.Brand, car.LicensePlate, car.ParkingLocation.ToString() };
            carslist = new ListViewItem(cardata);
            carslist.Name = car.id.ToString();
            LVCar.Items.Add(carslist);
        }
        private void fillLVCARNoOwners()//only make cars that are not hired available for hire
        {
            LVCar.Items.Clear();
            var cars = (from car in Program.db.Cars
                        where car.Owner == null
                        select car).ToList();
            foreach (Car car in cars)
            {
                fillLVCar(car);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            if (LVCar.SelectedItems.Count > 0)
            {
                person.ReturnCar(int.Parse(LVCar.SelectedItems[0].Name), value);
                Program.db.SaveChanges();
                fillLVCARNoOwners();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            person.HireCar(int.Parse(LVCar.SelectedItems[0].Name), value);
            Program.db.SaveChanges();
            var car = from cars in Program.db.Cars//see if person has hired car
                      where cars.Owner == person.id
                      select cars;
            LVCar.Items.Clear();
            fillLVCar(car.First());

        }
    }
}
