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
        public Hoofdmenu Hoofdmenu;
        public PersonEditForm()
        {
            InitializeComponent();
        }

        Person Person;

        public PersonEditForm(Person person1, Hoofdmenu hoofdmenu)
        {
            InitializeComponent();
            Person = person1;
            textBox1.Text = Person.Name.ToString();
            textBox2.Text = Person.HomeAddress;
            textBox3.Text = Person.WorkAddress;
            textBox4.Text = Person.Age.ToString();
            textBox5.Text = Person.BirthDay;
            textBox6.Text = Person.PhoneNumber.ToString();
            textBox7.Text = Person.CustomerNumber.ToString();
            checkBox1.Checked = Person.DriversLicense;
           // textBox9.Text = Person.BankAccountNumber.ToString();
           // textBox10.Text = Person.MoneyOwed.ToString();
            textBox12.Text = Person.Gender;
            Hoofdmenu = hoofdmenu;
        }
        
        Person Person2;
        private bool TextBoxCheck(TextBox box)
        {
            return (box.Text != null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(textBox1))
            {
                Person.Name = textBox1.Text;
                textBox1.Text = Person.Name;
            }

            if (TextBoxCheck(textBox2))
            {
                Person.HomeAddress = textBox2.Text;
                textBox2.Text = Person.HomeAddress;
            }
            if (TextBoxCheck(textBox3))
            {
                Person.WorkAddress = textBox3.Text;
                textBox3.Text = Person.WorkAddress;
            }
            if (TextBoxCheck(textBox4))
            {
                int value = 18;
                int.TryParse(textBox4.Text, out value);
                Person.Age = value;
                textBox4.Text = Person.Age.ToString();
            }
            if (TextBoxCheck(textBox5))
            {
                Person.BirthDay = textBox5.Text;
                textBox5.Text = Person.BirthDay;
            }

            if (TextBoxCheck(textBox6))
            {
                int value = 0;
                int.TryParse(textBox6.Text, out value);
                Person.PhoneNumber = value;
                textBox6.Text = Person.PhoneNumber.ToString();
            }
            if (TextBoxCheck(textBox7))
            {
                int value = 0;
                int.TryParse(textBox7.Text, out value);
                Person.CustomerNumber = value;
                textBox7.Text = Person.CustomerNumber.ToString();
            }
            if (TextBoxCheck(textBox8))
            {
                Car car = new Car();
                car.Brand = textBox8.Text;
                car.Model = "default";
                Person.Car = car;
                textBox8.Text = Person.Car.Brand;
            }
            if (checkBox1.Checked)
            {
                Person.DriversLicense = true;

            }
            else if (!checkBox1.Checked)
            {
                Person.DriversLicense = false;
            }
            if (TextBoxCheck(textBox10))
            {
                Person.BankAccountNumber = textBox10.Text;
                textBox10.Text = Person.BankAccountNumber;
            }
            if (TextBoxCheck(textBox11))
            {
                int value = 0;
                int.TryParse(textBox11.Text, out value);
                Person.MoneyOwed = value;
                textBox11.Text = Person.MoneyOwed.ToString();
            }

            Hoofdmenu.refreshLabels();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            Person.ReturnCar(Person.Car, value);
            if (Person.Car == null)
            {
                textBox8.Text = "";
            }
            else
                textBox8.Text = Person.Car.Brand.ToString();
            textBox11.Text = Person.MoneyOwed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = textBox8.Text;
            Person2 = new Person(textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), textBox5.Text, "default", Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text), car);


        }
        
    }
}
