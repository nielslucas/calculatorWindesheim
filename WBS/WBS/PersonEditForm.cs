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
        public PersonEditForm()
        {
            InitializeComponent();

        }

        Person person;
        public PersonEditForm(WBSEntities1 db)//add person constructor
        {
            InitializeComponent();
            button1.Hide();
            this.db = db;
            checkBox1.Checked = true;
        }
        public PersonEditForm(Person person, WBSEntities1 db)//edit person constructor
        {
            InitializeComponent();
            button2.Hide();
            this.person = person;
            this.db = db;
            textBox1.Text = person.Name;
            textBox2.Text = person.HomeAddress;
            textBox3.Text = person.WorkAddress;
            textBox4.Text = person.Age.ToString();
            textBox5.Text = person.Birthday.ToString();
            textBox6.Text = person.PhoneNumber.ToString();
            textBox7.Text = person.CustomerNumber.ToString();
            checkBox1.Checked = Convert.ToBoolean(person.DriversLicense);
           // textBox9.Text = Person.BankAccountNumber.ToString();
           // textBox10.Text = Person.MoneyOwed.ToString();
            textBox12.Text = person.Gender;
            
        }
        
        //Person Person2;
        private bool TextBoxCheck(TextBox box)
        {
            return (box.Text != null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(textBox1))
            {
                person.Name = textBox1.Text;
                textBox1.Text = person.Name;
            }

            if (TextBoxCheck(textBox2))
            {
                person.HomeAddress = textBox2.Text;
                textBox2.Text = person.HomeAddress;
            }
            if (TextBoxCheck(textBox3))
            {
                person.WorkAddress = textBox3.Text;
                textBox3.Text = person.WorkAddress;
            }
            if (TextBoxCheck(textBox4))
            {
                int value = 18;
                int.TryParse(textBox4.Text, out value);
                person.Age = value;
                textBox4.Text = person.Age.ToString();
            }
            if (TextBoxCheck(textBox5))
            {
                person.Birthday = DateTime.Parse(textBox5.Text);
                textBox5.Text = person.Birthday.ToString();
            }

            if (TextBoxCheck(textBox6))
            {
                int value = 0;
                int.TryParse(textBox6.Text, out value);
                person.PhoneNumber = value;
                textBox6.Text = person.PhoneNumber.ToString();
            }
            if (TextBoxCheck(textBox7))
            {
                int value = 0;
                int.TryParse(textBox7.Text, out value);
                person.CustomerNumber = value;
                textBox7.Text = person.CustomerNumber.ToString();
            }
            if (TextBoxCheck(textBox8))
            {
                Car car = new Car();
                car.Brand = textBox8.Text;
                car.Model = "default";
                person.Car = car;
                textBox8.Text = person.Car.Brand;
            }
            if (checkBox1.Checked)
            {
                person.DriversLicense = 1;

            }
            else if (!checkBox1.Checked)
            {
                person.DriversLicense = 0;
            }
            if (TextBoxCheck(textBox10))
            {
                person.BankAccountNumber = textBox10.Text;
                textBox10.Text = person.BankAccountNumber;
            }
            if (TextBoxCheck(textBox11))
            {
                int value = 0;
                int.TryParse(textBox11.Text, out value);
                person.MoneyOwed = value;
                textBox11.Text = person.MoneyOwed.ToString();
            }
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(textBox9.Text, out value);
            person.ReturnCar(person.Car, value);
            if (person.Car == null)
            {
                textBox8.Text = "";
            }
            else
                textBox8.Text = person.Car.Brand.ToString();
            textBox11.Text = person.MoneyOwed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = textBox8.Text;
           Person tempPerson2 = new Person(textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), DateTime.Parse(textBox5.Text), "default", Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text),textBox10.Text);
            db.Persons.Add(tempPerson2);
            db.SaveChanges();
        }
        
    }
}
