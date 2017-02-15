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
        GradeBook gradebook = new GradeBook("ADSD");
        GradeBook gradebook2 = new GradeBook("ICT");

        public GradeBookForm1()
        {
            InitializeComponent();
            textBox1.Text = gradebook.CourseName;
            label1.Text = gradebook.DisplayMessage();
            textBox2.Text = gradebook2.CourseName;
            label2.Text = gradebook2.DisplayMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradebook.CourseName = textBox1.Text;
            textBox1.Text = gradebook.CourseName;
            label1.Text = gradebook.DisplayMessage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gradebook2.CourseName = textBox2.Text;
            textBox2.Text = gradebook2.CourseName;
            label2.Text = gradebook2.DisplayMessage();
        }
    }
}
