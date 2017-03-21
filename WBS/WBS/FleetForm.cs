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
    public partial class FleetForm : Form
    {

        public FleetForm()
        {
            InitializeComponent();

            //Fill fleet DropDownList
            Dictionary<int, string> CarFleetList = new Dictionary<int, string>();

            foreach (Fleet fleet in Program.db.Fleets)
            {
                CarFleetList.Add(fleet.ID, fleet.Name);
            }

            cbFleet.DataSource = new BindingSource(CarFleetList, null);
            cbFleet.ValueMember = "Key";
            cbFleet.DisplayMember = "Value";

            //if (car.FleetID != null)
            //{
            //    cbFleet.SelectedValue = car.FleetID;
            //}

            //FillListView
            FillListView();
        }

        private void btSaveFleet_Click(object sender, EventArgs e)
        {
            Fleet tempFleet = new Fleet(tbFleetName.Text);
            Program.db.Fleets.Add(tempFleet);
            Program.db.SaveChanges();
            Close();
        }

        private void cbFleets_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbFleet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            //clear ListViewList
            lvFleets.Items.Clear();

            //Get FleetID from Combobox
            int fleetID = (int)cbFleet.SelectedValue;

            //Get Fleed from database
            Fleet tempFleets = Program.db.Fleets.Find(fleetID);

            if (tempFleets != null)
            {
                
                //fill list
                foreach (Car car in tempFleets.Cars)
                {
                    //create string array from data
                    string[] carData = {
                    car.id.ToString(),
                    car.Brand
                };

                //create item from data
                ListViewItem item = new ListViewItem(carData);

                //Fill list with the ListViewItem
                lvFleets.Items.Add(item);

                }
            }
        }
    }
}
