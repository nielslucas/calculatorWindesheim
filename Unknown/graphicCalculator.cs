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
            
        }


        public void DrawGraph()
        {
            Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, new Point(0, 0), new Point(graph.graphXLength * 100,0));
            formGraphics.DrawLine(myPen,new Point(0,0),new Point(0, graph.graphYHeight*100));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        public void Drawvalues(string calc)
        {

           List<double> numbers= graph.Calculation(calc);
            int x = 0;
            foreach (double number in numbers)
            {
                x++;
                //Pen myPen;
                //myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                //System.Drawing.Graphics formGraphics = this.CreateGraphics();
                //formGraphics.DrawLine(myPen, 0, 0, 0, (float)number);
                Brush aBrush = (Brush)Brushes.Black;
                Graphics g = this.CreateGraphics();
                g.FillRectangle(aBrush, x, (float)number, 1, 1);
                label1.Text += "x: " + x + "  y: " + number + "\n";
               // myPen.Dispose();
                //formGraphics.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraph();
            Drawvalues(textBox1.Text);
            graph.graphXLength = Int32.Parse(textBox2.Text);
            graph.graphYHeight = Int32.Parse(textBox3.Text);
        }
    }

}
