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
    public partial class Hoofdmenu : Form
    {

        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {   
            Car car = new Car("BMW","whatever",1009,500,"Red","Yellow",5,"sport",50,"ADSL3",4,"Purple",20,54,true,false,200);
            CarEditForm form = new CarEditForm(car);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                 
        }
    }
}

