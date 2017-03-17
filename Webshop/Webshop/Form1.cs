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
    public partial class Form1 : Form
    {
        WebshopEntities db = new WebshopEntities();
        bool categoryselected = false;
        public Form1()
        {
            InitializeComponent();
            listArticles();
            FillCBCategories();
        }

        public void reset()
        {
            LVArticles.Items.Clear();
            listArticles();
            FillCBCategories();
            categoryselected = false;
        }
        public void listArticles()
        {
            foreach (Article article in db.Articles)
            {
                string[] articleItems = { article.Name, article.Price.ToString(), article.Stock.ToString() };
                ListViewItem articles = new ListViewItem(articleItems);
                articles.Name = article.ID.ToString();
                LVArticles.Items.Add(articles);
            }
        }
        public void listArticles(List<Article> articles)
        {
            LVArticles.Items.Clear();
            foreach (Article article in articles)
            {
                string[] articleItems = { article.Name, article.Price.ToString(), article.Stock.ToString() };
                ListViewItem articleViewItems = new ListViewItem(articleItems);
                articleViewItems.Name = article.ID.ToString();
                LVArticles.Items.Add(articleViewItems);
            }
        }
        public void FillCBCategories()
        {
            Dictionary<int, string> categories = new Dictionary<int, string>();
            foreach (Category cat in db.Categories)
            {
                categories.Add(cat.ID, cat.Name);
            }
            CBCategory.DataSource = new BindingSource(categories, null);
            CBCategory.DisplayMember = "Value";
            CBCategory.ValueMember = "Key";
        }
        private void ButAddArticle_Click(object sender, EventArgs e)
        {
            editArticle addArticle = new editArticle(db);
            addArticle.Show();

        }

        private void ButEditArticle_Click(object sender, EventArgs e)
        {
            if (LVArticles.SelectedItems.Count != 0)
            {
                int articleId = int.Parse(LVArticles.SelectedItems[0].Name);
                Article article = db.Articles.Find(articleId);
                editArticle editArticleForm = new editArticle(article, db);
                editArticleForm.Show();
            }
        }

        private void CBCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int categoryId = (int)CBCategory.SelectedValue;
            var articles = (from article in db.Articles
                            where article.CategoryID == categoryId
                            select article).ToList();
            listArticles(articles);
            TBEditCategory.Text = db.Categories.Find(categoryId).Name;
            categoryselected = true;
        }



        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            string searchterm = TBSearch.Text;
            List<Article> articles;

            if (categoryselected)//search current category
            {
                articles = (from article in db.Articles
                            where article.Name.Contains(searchterm) && article.CategoryID == (int)CBCategory.SelectedValue
                            select article
                          ).ToList();
            }
            else//search all articles
            {
                articles = (from article in db.Articles
                            where article.Name.Contains(searchterm)
                            select article
                           ).ToList();
            }
            listArticles(articles);

        }

        private void ButAddCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            if (TBAddCategory.Text != "")
            {
                cat.Name = TBAddCategory.Text;
                db.Categories.Add(cat);
                db.SaveChanges();
                FillCBCategories();
                TBAddCategory.Text = "";
            }
        }

        private void ButEditCategory_Click(object sender, EventArgs e)
        {
            Category cat = db.Categories.Find((int)CBCategory.SelectedValue);
            cat.Name = TBEditCategory.Text;
            db.SaveChanges();
            FillCBCategories();
        }

        private void ButReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, Article> cartItems = new Dictionary<int, Article>();
            foreach(ListViewItem cartitems in LVCart.Items)
            {
                cartItems.Add(int.Parse(cartitems.SubItems[3].Text), db.Articles.Find(int.Parse(cartitems.Name)));
                
            }
            if (cartItems.Count > 0)
            {
                CustomerForm cForm = new CustomerForm(cartItems);
            }
        }

        private void ButAddToCart_Click(object sender, EventArgs e)
        {
            ListViewItem cartItem = (ListViewItem)LVArticles.SelectedItems[0].Clone();
            cartItem.SubItems.Add(TBAmount.Text);
            LVCart.Items.Add(cartItem);
            
        }
    }
}
