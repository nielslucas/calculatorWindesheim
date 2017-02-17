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
        Person person1 = new Person();
        Person person2;
        private bool TextBoxCheck(TextBox box)
        {
            return (box.Text != null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(textBox1))
            {
                person1.Name = textBox1.Text;
                textBox1.Text = person1.Name;
            }

            if (TextBoxCheck(textBox2))
            {
                person1.HomeAddress = textBox2.Text;
                textBox2.Text = person1.HomeAddress;
            }
            if (TextBoxCheck(textBox3))
            {
                person1.WorkAddress = textBox3.Text;
                textBox3.Text = person1.WorkAddress;
            }
            if (TextBoxCheck(textBox4))
            {
                int value = 18;
                int.TryParse(textBox4.Text, out value);
                person1.Age = value;
                textBox4.Text = person1.Age.ToString();
            }
            if (TextBoxCheck(textBox5))
            {
                person1.BirthDay = textBox5.Text;
                textBox5.Text = person1.BirthDay;
            }

            if (TextBoxCheck(textBox6))
            {
                int value = 0;
                int.TryParse(textBox6.Text, out value);
                person1.PhoneNumber = value;
                textBox6.Text = person1.PhoneNumber.ToString();
            }
            if (TextBoxCheck(textBox7))
            {
                int value = 0;
                int.TryParse(textBox7.Text, out value);
                person1.CustomerNumber = value;
                textBox7.Text = person1.CustomerNumber.ToString();
            }
            if (TextBoxCheck(textBox8))
            {
                Car car = new Car();
                car.Brand= textBox8.Text;
                car.Model = "default";
                person1.Car = car;
                textBox8.Text = person1.Car.Brand;
            }
            if (checkBox1.Checked)
            {
                person1.DriversLicense = true;

            }
            else if (!checkBox1.Checked)
            {
                person1.DriversLicense = false;
            }
            if (TextBoxCheck(textBox10))
            {
                person1.BankAccountNumber = textBox10.Text;
                textBox10.Text = person1.BankAccountNumber;
            }
            if (TextBoxCheck(textBox11))
            {
                int value = 0;
                int.TryParse(textBox11.Text, out value);
                person1.MoneyOwed = value;
                textBox11.Text = person1.MoneyOwed.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            person1.ReturnCar(person1.Car,value);
            if (person1.Car == null) { 
            textBox8.Text = "";
            }else
                textBox8.Text = person1.Car.Brand.ToString();
            textBox11.Text= person1.MoneyOwed.ToString();
            person2 = new Person();
        }
        
    }
}
