namespace WBS
{
    partial class FleetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFleet = new System.Windows.Forms.Label();
            this.tbFleetName = new System.Windows.Forms.TextBox();
            this.btSaveFleet = new System.Windows.Forms.Button();
            this.cbFleet = new System.Windows.Forms.ComboBox();
            this.lbFleets = new System.Windows.Forms.Label();
            this.lvFleets = new System.Windows.Forms.ListView();
            this.blub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbFleet
            // 
            this.lbFleet.AutoSize = true;
            this.lbFleet.Location = new System.Drawing.Point(23, 45);
            this.lbFleet.Name = "lbFleet";
            this.lbFleet.Size = new System.Drawing.Size(59, 13);
            this.lbFleet.TabIndex = 0;
            this.lbFleet.Text = "Fleet name";
            // 
            // tbFleetName
            // 
            this.tbFleetName.Location = new System.Drawing.Point(26, 62);
            this.tbFleetName.Name = "tbFleetName";
            this.tbFleetName.Size = new System.Drawing.Size(100, 20);
            this.tbFleetName.TabIndex = 1;
            // 
            // btSaveFleet
            // 
            this.btSaveFleet.Location = new System.Drawing.Point(26, 89);
            this.btSaveFleet.Name = "btSaveFleet";
            this.btSaveFleet.Size = new System.Drawing.Size(75, 23);
            this.btSaveFleet.TabIndex = 2;
            this.btSaveFleet.Text = "Save";
            this.btSaveFleet.UseVisualStyleBackColor = true;
            this.btSaveFleet.Click += new System.EventHandler(this.btSaveFleet_Click);
            // 
            // cbFleet
            // 
            this.cbFleet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFleet.FormattingEnabled = true;
            this.cbFleet.Location = new System.Drawing.Point(222, 62);
            this.cbFleet.Name = "cbFleet";
            this.cbFleet.Size = new System.Drawing.Size(129, 21);
            this.cbFleet.TabIndex = 3;
            this.cbFleet.SelectionChangeCommitted += new System.EventHandler(this.cbFleet_SelectionChangeCommitted);
            this.cbFleet.SelectedValueChanged += new System.EventHandler(this.cbFleets_SelectedValueChanged);
            // 
            // lbFleets
            // 
            this.lbFleets.AutoSize = true;
            this.lbFleets.Location = new System.Drawing.Point(222, 43);
            this.lbFleets.Name = "lbFleets";
            this.lbFleets.Size = new System.Drawing.Size(35, 13);
            this.lbFleets.TabIndex = 4;
            this.lbFleets.Text = "Fleets";
            // 
            // lvFleets
            // 
            this.lvFleets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blub,
            this.columnHeader1});
            this.lvFleets.Location = new System.Drawing.Point(222, 89);
            this.lvFleets.Name = "lvFleets";
            this.lvFleets.Size = new System.Drawing.Size(129, 160);
            this.lvFleets.TabIndex = 5;
            this.lvFleets.UseCompatibleStateImageBehavior = false;
            this.lvFleets.View = System.Windows.Forms.View.Details;
            // 
            // blub
            // 
            this.blub.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Brand";
            // 
            // FleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 261);
            this.Controls.Add(this.lvFleets);
            this.Controls.Add(this.lbFleets);
            this.Controls.Add(this.cbFleet);
            this.Controls.Add(this.btSaveFleet);
            this.Controls.Add(this.tbFleetName);
            this.Controls.Add(this.lbFleet);
            this.Name = "FleetForm";
            this.Text = "FleetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFleet;
        private System.Windows.Forms.TextBox tbFleetName;
        private System.Windows.Forms.Button btSaveFleet;
        private System.Windows.Forms.ComboBox cbFleet;
        private System.Windows.Forms.Label lbFleets;
        private System.Windows.Forms.ListView lvFleets;
        private System.Windows.Forms.ColumnHeader blub;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}