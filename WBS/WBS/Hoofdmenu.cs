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
            Car car = new Car();
            CarEditForm form = new CarEditForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm();
            form.Show();
        }

    }
}

