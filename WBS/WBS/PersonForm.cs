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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }
        Person Person1 = new Person();
        Person Person2;
        private bool TextBoxCheck(TextBox box)
        {
            return (box.Text != null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(textBox1))
            {
                Person1.Name = textBox1.Text;
                textBox1.Text = Person1.Name;
            }

            if (TextBoxCheck(textBox2))
            {
                Person1.HomeAddress = textBox2.Text;
                textBox2.Text = Person1.HomeAddress;
            }
            if (TextBoxCheck(textBox3))
            {
                Person1.WorkAddress = textBox3.Text;
                textBox3.Text = Person1.WorkAddress;
            }
            if (TextBoxCheck(textBox4))
            {
                int value = 18;
                int.TryParse(textBox4.Text, out value);
                Person1.Age = value;
                textBox4.Text = Person1.Age.ToString();
            }
            if (TextBoxCheck(textBox5))
            {
                Person1.BirthDay = textBox5.Text;
                textBox5.Text = Person1.BirthDay;
            }

            if (TextBoxCheck(textBox6))
            {
                int value = 0;
                int.TryParse(textBox6.Text, out value);
                Person1.PhoneNumber = value;
                textBox6.Text = Person1.PhoneNumber.ToString();
            }
            if (TextBoxCheck(textBox7))
            {
                int value = 0;
                int.TryParse(textBox7.Text, out value);
                Person1.CustomerNumber = value;
                textBox7.Text = Person1.CustomerNumber.ToString();
            }
            if (TextBoxCheck(textBox8))
            {
                Car car = new Car();
                car.Brand = textBox8.Text;
                car.Model = "default";
                Person1.Car = car;
                textBox8.Text = Person1.Car.Brand;
            }
            if (checkBox1.Checked)
            {
                Person1.DriversLicense = true;

            }
            else if (!checkBox1.Checked)
            {
                Person1.DriversLicense = false;
            }
            if (TextBoxCheck(textBox10))
            {
                Person1.BankAccountNumber = textBox10.Text;
                textBox10.Text = Person1.BankAccountNumber;
            }
            if (TextBoxCheck(textBox11))
            {
                int value = 0;
                int.TryParse(textBox11.Text, out value);
                Person1.MoneyOwed = value;
                textBox11.Text = Person1.MoneyOwed.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            Person1.ReturnCar(Person1.Car, value);
            if (Person1.Car == null)
            {
                textBox8.Text = "";
            }
            else
                textBox8.Text = Person1.Car.Brand.ToString();
            textBox11.Text = Person1.MoneyOwed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = textBox8.Text;
            Person2 = new Person(textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), textBox5.Text, "default", Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text), car);


        }
    }
}
