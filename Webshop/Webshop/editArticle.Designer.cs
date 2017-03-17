namespace Webshop
{
    partial class editArticle
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.ArticleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 21);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            // 
            // NUDPrice
            // 
            this.NUDPrice.Location = new System.Drawing.Point(12, 63);
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(119, 20);
            this.NUDPrice.TabIndex = 2;
            // 
            // TBdescription
            // 
            this.TBdescription.Location = new System.Drawing.Point(12, 112);
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.Size = new System.Drawing.Size(100, 20);
            this.TBdescription.TabIndex = 3;
            // 
            // ArticleName
            // 
            this.ArticleName.AutoSize = true;
            this.ArticleName.Location = new System.Drawing.Point(9, 5);
            this.ArticleName.Name = "ArticleName";
            this.ArticleName.Size = new System.Drawing.Size(35, 13);
            this.ArticleName.TabIndex = 4;
            this.ArticleName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(12, 217);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 7;
            this.ButAdd.Text = "Add";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(113, 217);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 8;
            this.ButSave.Text = "Save";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(151, 20);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 9;
            // 
            // editArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticleName);
            this.Controls.Add(this.TBdescription);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.TBName);
            this.Name = "editArticle";
            this.Text = "editArticle";
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.Label ArticleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.ComboBox CBCategory;
    }
}