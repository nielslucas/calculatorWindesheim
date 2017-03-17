namespace Webshop
{
    partial class SupplierEdit
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
            this.ButSave = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.TBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(157, 225);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 16;
            this.ButSave.Text = "Save";
            this.ButSave.UseVisualStyleBackColor = true;
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(56, 225);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 15;
            this.ButAdd.Text = "Add";
            this.ButAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSize = true;
            this.SupplierName.Location = new System.Drawing.Point(53, 13);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(35, 13);
            this.SupplierName.TabIndex = 12;
            this.SupplierName.Text = "Name";
            // 
            // TBdescription
            // 
            this.TBdescription.Location = new System.Drawing.Point(56, 120);
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.Size = new System.Drawing.Size(100, 20);
            this.TBdescription.TabIndex = 11;
            // 
            // NUDPrice
            // 
            this.NUDPrice.Location = new System.Drawing.Point(56, 71);
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(119, 20);
            this.NUDPrice.TabIndex = 10;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(56, 29);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 9;
            // 
            // SupplierEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierName);
            this.Controls.Add(this.TBdescription);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.TBName);
            this.Name = "SupplierEdit";
            this.Text = "SupplierEdit";
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SupplierName;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.TextBox TBName;
    }
}