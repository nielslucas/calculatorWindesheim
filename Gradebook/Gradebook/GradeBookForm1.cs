using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gradebook
{
    public partial class GradeBookForm1 : Form
    {
        private GradeBook Gradebook = new GradeBook("ADSD");
        private GradeBook Gradebook2 = new GradeBook("ICT");

        
        public GradeBookForm1()
        {
            InitializeComponent();
            textBox1.Text = Gradebook.CourseName;
            label1.Text = Gradebook.DisplayMessage();
            textBox2.Text = Gradebook2.CourseName;
            label2.Text = Gradebook2.DisplayMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gradebook.CourseName = textBox1.Text;
            textBox1.Text = Gradebook.CourseName;
            label1.Text = Gradebook.DisplayMessage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gradebook2.CourseName = textBox2.Text;
            textBox2.Text = Gradebook2.CourseName;
            label2.Text = Gradebook2.DisplayMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<double> gradelist = Gradebook.DetermineClassAverage(Int32.Parse(textBox3.Text));

            label4.Text = "average: " + gradelist[0].ToString() + "\n";
            label4.Text += "total: " + gradelist[1].ToString() + "\n";
            label4.Text += Gradebook.ACount.ToString() + "\n";
            label4.Text += Gradebook.BCount.ToString() + "\n";
            label4.Text += Gradebook.CCount.ToString() + "\n";
            label4.Text += Gradebook.DCount.ToString() + "\n";
            label4.Text += Gradebook.FCount.ToString() + "\n";
            Gradebook.IncrementLetterGradeCounter(Int32.Parse(textBox3.Text));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<double> gradelist = Gradebook.DetermineClassAverage(Int32.Parse(textBox4.Text));

            label5.Text = "average: " + gradelist[0].ToString() + "\n";
            label5.Text += "total: " + gradelist[1].ToString() + "\n";
            label5.Text += Gradebook2.ACount.ToString() + "\n";
            label5.Text += Gradebook2.BCount.ToString() + "\n";
            label5.Text += Gradebook2.CCount.ToString() + "\n";
            label5.Text += Gradebook2.DCount.ToString() + "\n";
            label5.Text += Gradebook2.FCount.ToString() + "\n";
            Gradebook.IncrementLetterGradeCounter(Int32.Parse(textBox4.Text));
        }

        ///////////////////////////////////////////////
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
