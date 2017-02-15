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
    public partial class graphicCalculator : Form
    {

        GraphicCalc graph = new GraphicCalc();

        public graphicCalculator()
        {
            InitializeComponent();
            DrawGraph();
        }


        public void DrawGraph()
        {
            Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 0, graph.graphXLength, graph.graphYHeight);
            myPen.Dispose();
            formGraphics.Dispose();
        }
        public void Drawvalues(string calc)
        {

           List<double> numbers= graph.Calculation(calc);
            foreach (double number in numbers)
            {
                Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                System.Drawing.Graphics formGraphics = this.CreateGraphics();
                formGraphics.DrawLine(myPen, 0, 0, 0, (float)number);
                myPen.Dispose();
                formGraphics.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drawvalues(textBox1.Text);
            graph.graphXLength = Int32.Parse(textBox2.Text);
            graph.graphYHeight = Int32.Parse(textBox3.Text);
        }
    }

}
