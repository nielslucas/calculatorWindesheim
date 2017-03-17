namespace Webshop
{
    partial class Form1
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
            this.LVArticles = new System.Windows.Forms.ListView();
            this.ArticleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ButAddArticle = new System.Windows.Forms.Button();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.LabCategory = new System.Windows.Forms.Label();
            this.ButEditArticle = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.ButAddCategory = new System.Windows.Forms.Button();
            this.TBAddCategory = new System.Windows.Forms.TextBox();
            this.TBEditCategory = new System.Windows.Forms.TextBox();
            this.ButEditCategory = new System.Windows.Forms.Button();
            this.ButReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVArticles
            // 
            this.LVArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArticleName,
            this.Price,
            this.InStock});
            this.LVArticles.Location = new System.Drawing.Point(236, 28);
            this.LVArticles.Name = "LVArticles";
            this.LVArticles.Size = new System.Drawing.Size(274, 149);
            this.LVArticles.TabIndex = 0;
            this.LVArticles.UseCompatibleStateImageBehavior = false;
            this.LVArticles.View = System.Windows.Forms.View.Details;
            // 
            // ArticleName
            // 
            this.ArticleName.Text = "Name";
            this.ArticleName.Width = 56;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 40;
            // 
            // InStock
            // 
            this.InStock.Text = "In Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // ButAddArticle
            // 
            this.ButAddArticle.Location = new System.Drawing.Point(12, 12);
            this.ButAddArticle.Name = "ButAddArticle";
            this.ButAddArticle.Size = new System.Drawing.Size(75, 23);
            this.ButAddArticle.TabIndex = 2;
            this.ButAddArticle.Text = "add Article";
            this.ButAddArticle.UseVisualStyleBackColor = true;
            this.ButAddArticle.Click += new System.EventHandler(this.ButAddArticle_Click);
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(537, 28);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 3;
            this.CBCategory.SelectionChangeCommitted += new System.EventHandler(this.CBCategory_SelectionChangeCommitted);
            // 
            // LabCategory
            // 
            this.LabCategory.AutoSize = true;
            this.LabCategory.Location = new System.Drawing.Point(534, 12);
            this.LabCategory.Name = "LabCategory";
            this.LabCategory.Size = new System.Drawing.Size(57, 13);
            this.LabCategory.TabIndex = 4;
            this.LabCategory.Text = "Categories";
            // 
            // ButEditArticle
            // 
            this.ButEditArticle.Location = new System.Drawing.Point(93, 12);
            this.ButEditArticle.Name = "ButEditArticle";
            this.ButEditArticle.Size = new System.Drawing.Size(75, 23);
            this.ButEditArticle.TabIndex = 5;
            this.ButEditArticle.Text = "Edit article";
            this.ButEditArticle.UseVisualStyleBackColor = true;
            this.ButEditArticle.Click += new System.EventHandler(this.ButEditArticle_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(537, 94);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(100, 20);
            this.TBSearch.TabIndex = 6;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // ButAddCategory
            // 
            this.ButAddCategory.Location = new System.Drawing.Point(12, 78);
            this.ButAddCategory.Name = "ButAddCategory";
            this.ButAddCategory.Size = new System.Drawing.Size(75, 23);
            this.ButAddCategory.TabIndex = 7;
            this.ButAddCategory.Text = "Add categorie";
            this.ButAddCategory.UseVisualStyleBackColor = true;
            this.ButAddCategory.Click += new System.EventHandler(this.ButAddCategory_Click);
            // 
            // TBAddCategory
            // 
            this.TBAddCategory.Location = new System.Drawing.Point(12, 52);
            this.TBAddCategory.Name = "TBAddCategory";
            this.TBAddCategory.Size = new System.Drawing.Size(100, 20);
            this.TBAddCategory.TabIndex = 8;
            // 
            // TBEditCategory
            // 
            this.TBEditCategory.Location = new System.Drawing.Point(118, 52);
            this.TBEditCategory.Name = "TBEditCategory";
            this.TBEditCategory.Size = new System.Drawing.Size(100, 20);
            this.TBEditCategory.TabIndex = 9;
            // 
            // ButEditCategory
            // 
            this.ButEditCategory.Location = new System.Drawing.Point(118, 78);
            this.ButEditCategory.Name = "ButEditCategory";
            this.ButEditCategory.Size = new System.Drawing.Size(75, 23);
            this.ButEditCategory.TabIndex = 10;
            this.ButEditCategory.Text = "edit Category";
            this.ButEditCategory.UseVisualStyleBackColor = true;
            this.ButEditCategory.Click += new System.EventHandler(this.ButEditCategory_Click);
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(435, 183);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(75, 23);
            this.ButReset.TabIndex = 11;
            this.ButReset.Text = "RESET";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 307);
            this.Controls.Add(this.ButReset);
            this.Controls.Add(this.ButEditCategory);
            this.Controls.Add(this.TBEditCategory);
            this.Controls.Add(this.TBAddCategory);
            this.Controls.Add(this.ButAddCategory);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.ButEditArticle);
            this.Controls.Add(this.LabCategory);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.ButAddArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVArticles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButAddArticle;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Label LabCategory;
        private System.Windows.Forms.ColumnHeader ArticleName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader InStock;
        private System.Windows.Forms.Button ButEditArticle;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button ButAddCategory;
        private System.Windows.Forms.TextBox TBAddCategory;
        private System.Windows.Forms.TextBox TBEditCategory;
        private System.Windows.Forms.Button ButEditCategory;
        private System.Windows.Forms.Button ButReset;
    }
}

