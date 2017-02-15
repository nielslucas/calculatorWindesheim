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
            _Form1 = this;
        }

        public static Form1 _Form1;

        public void update(string message)
        {
            textBox1.Text = message;
        }
        //////////////////////////////////////////////////////////////////////////////////////////

        private void reset_Click(object sender, EventArgs e)
        {
            calc.reset();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            calc.method = '+';
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }

        private void keer_Click(object sender, EventArgs e)
        {
            calc.method = '*';
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }

        private void deel_Click(object sender, EventArgs e)
        {
            calc.method = '/';
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            calc.method = '-';
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }
        private void setOperator()
        {
            calc.check = true;
            textBox1.Text = calc.method.ToString();
        }
        private void iss_Click(object sender, EventArgs e)
        {
            calc.calculate();
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
            calc.setnumber(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            calc.setnumber(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            calc.setnumber(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            calc.setnumber(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            calc.setnumber(5);
        }

        private void sixs_Click(object sender, EventArgs e)
        {
            calc.setnumber(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            calc.setnumber(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            calc.setnumber(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calc.setnumber(9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc.setnumber(0);
        }

        private void komma_Click(object sender, EventArgs e)
        {
            calc.komma();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            this.save(calc.calculation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphicCalculator calc = new graphicCalculator();
            calc.Show();
        }
    }
}
