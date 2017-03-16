using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop
{
    public partial class editArticle : Form
    {
        WebshopEntities db = new WebshopEntities();
        private Article _article;
        public editArticle()
        {
            InitializeComponent();
        }
        public editArticle(Article article, WebshopEntities db)
        {
            InitializeComponent();
            _article = article;
            this.db = db;
            ButAdd.Hide();
            FillCBCategory();
            TBName.Text = article.Name;
            TBdescription.Text = article.Description;
            NUDPrice.Value = (decimal)article.Price;
            FillCBCategory();
            CBCategory.SelectedIndex = CBCategory.FindStringExact(article.Category.Name);
            //CBCategory.Items.IndexOf(article.Category.Name);
            

        }
        public editArticle(WebshopEntities db)
        {
            InitializeComponent();
            this.db = db;
            ButSave.Hide();
            FillCBCategory();

        }
        private void FillCBCategory()
        {
            Dictionary<int, string> categories = new Dictionary<int, string>();
            foreach (var categorie in db.Categories)
            {
                categories.Add(categorie.ID, categorie.Name);
            }
            CBCategory.DataSource = new BindingSource(categories, null);
            CBCategory.DisplayMember = "Value";
            CBCategory.ValueMember = "Key";
        }
        private Form1 _form = new Form1();
        private void ButAdd_Click(object sender, EventArgs e)
        {

            Article article = new Article();
            article.Name = TBName.Text;
            article.Price = (double)NUDPrice.Value;
            article.Description = TBdescription.Text;
            article.CategoryID = (int)CBCategory.SelectedValue;
            article.Stock = 0;

            db.Articles.Add(article);
            db.SaveChanges();
            Close();
            _form.listArticles();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            _article.Name = TBName.Text;
            _article.Price = (double)NUDPrice.Value;
            _article.Description = TBdescription.Text;
            _article.CategoryID = (int)CBCategory.SelectedValue;
            db.SaveChanges();
            Close();
            _form.listArticles();
        }
    }
}
