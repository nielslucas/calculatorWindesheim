using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unknown
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// test laurens
        /// </summary>

        Calculator calc = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void setnumber(double number)
        {
            if (this.check)
            {
                number2 += number.ToString();
                textBox1.Text = number2;
            }
            else
            {
                number1 += number.ToString();
                textBox1.Text = number1;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            number1 = "";
            method = ' ';
            number2 = "";
            textBox1.Text = "";
            check = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            method = '+';
            check = true;
            textBox1.Text = method.ToString();
        }

        private void keer_Click(object sender, EventArgs e)
        {
            method = '*';
            check = true;
            textBox1.Text = method.ToString();
        }

        private void deel_Click(object sender, EventArgs e)
        {
            method = '/';
            check = true;
            textBox1.Text = method.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            method = '-';
            check = true;
            textBox1.Text = method.ToString();
        }
        private void setOperator()
        {
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }
        private void iss_Click(object sender, EventArgs e)
        {
            if (number1.Length >= 1 && number2.Length >= 1 && method.ToString().Length == 1)
            {
                //parse strings to ints
                double temp1 = double.Parse(number1);
                double temp2 = double.Parse(number2);
                //stars switch
                switch (method)
                {
                    case '+':
                        //show result
                        //set number 1 result
                        number1 = (temp1 + temp2).ToString();
                        textBox1.Text = (temp1 + temp2).ToString();
                        cases(temp1, temp2);
                        break;

                    case '*':
                        //show result
                        //set number 1 result
                        number1 = (temp1 * temp2).ToString();
                        textBox1.Text = (temp1 * temp2).ToString();
                        cases(temp1, temp2);
                        break;

                    case '-':
                        //set number 1 result
                        number1 = (temp1 - temp2).ToString();
                        textBox1.Text = (temp1 - temp2).ToString();
                        cases(temp1, temp2);
                        break;

                    case '/':
                        //set number 1 result
                        number1 = (temp1 / temp2).ToString();
                        textBox1.Text = (temp1 / temp2).ToString();
                        cases(temp1, temp2);
                        break;

                    default:
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            setnumber(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            setnumber(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            setnumber(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            setnumber(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            setnumber(5);
        }

        private void sixs_Click(object sender, EventArgs e)
        {
            setnumber(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            setnumber(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            setnumber(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            setnumber(9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setnumber(0);
        }

        private void komma_Click(object sender, EventArgs e)
        {
            if (!this.number1.Contains(","))
            {

                if (this.check)
                {
                    this.number2 += ",";
                    this.textBox1.Text = this.number2;

                }
                else
                {

                    this.number1 += ",";
                    this.textBox1.Text = this.number2;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cases(double temp1, double temp2)
        {
            //refresh nmr 1
            textBox1.Text = number1;
            //set number 2 empty
            this.number2 = "";
            //refresh label
            textBox1.Text = number2;
            textBox1.Text = number1;
            calculation.Add(temp1.ToString() +" " + method + " " + temp2.ToString()+" = "+ textBox1.Text);
        }
        private void save(List<string> calculations)
        {
            //System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
            //foreach(string calculation in calculations) { 
            //file.WriteLine("#"+calculation);
            //}
            //file.Close();

            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", calculations);


        }
        private void load()
        {
            string[] calculations = System.IO.File.ReadAllLines(@"C:\Users\Public\WriteLines.txt");
            foreach(string calcpart in calculations)
            {
                label2.Text += calcpart+"\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.save(this.calculation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.load();
        }
       
    }
}
