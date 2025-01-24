using NewsCRUD.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NewsCRUD
{
    public partial class Form1 : Form
    {
        NewsContext dbContext;
        int id;
        public Form1()
        {
            InitializeComponent();
            dbContext = new NewsContext();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var news = dbContext.News.Select(n => new
            {
                n.Id,
                n.Title,
                n.Brief,
                n.Description,
                n.Time,
                AuthorName = n.Author.Name,
                CatalogName = n.Catalog.Name
            }).ToList();

            //dgv_news.Columns["Id"].Visible = false;


            dgv_news.DataSource = news;

            cb_author.DataSource = dbContext.Authors.ToList();
            cb_author.DisplayMember = "Name";
            cb_author.ValueMember = "Id";

            cb_catalog.DataSource = dbContext.Catalogs.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var n = new News()
            {
                Title = txt_title.Text,
                Brief = txt_brief.Text,
                Description = txt_desc.Text,
                Time = dt_time.Value,
                AuthorId = (int)cb_author.SelectedValue,
                CatalogId = (int)cb_catalog.SelectedValue,
            };

            dbContext.News.Add(n);
            dbContext.SaveChanges();

            txt_brief.Text = txt_desc.Text = txt_title.Text = "";

            dgv_news.DataSource = dbContext.News.Select(n => new
            {
                n.Id,
                n.Title,
                n.Brief,
                n.Description,
                n.Time,
                AuthorName = n.Author.Name,
                CatalogName = n.Catalog.Name
            }).ToList();

            MessageBox.Show("added successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            News n = dbContext.News.Where(n => n.Id == id).SingleOrDefault();
            n.Title = txt_title.Text;
            n.Brief = txt_brief.Text;
            n.Description = txt_desc.Text;
            n.Time = dt_time.Value;
            n.AuthorId = (int)cb_author.SelectedValue;
            n.CatalogId = (int)cb_catalog.SelectedValue;



            dbContext.SaveChanges();

            txt_brief.Text = txt_desc.Text = txt_title.Text = "";

            dgv_news.DataSource = dbContext.News.Select(n => new
            {
                n.Id,
                n.Title,
                n.Brief,
                n.Description,
                n.Time,
                AuthorName = n.Author.Name,
                CatalogName = n.Catalog.Name
            }).ToList();

            MessageBox.Show("updated successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this department", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                News n = dbContext.News.Where(n => n.Id == id).SingleOrDefault();

                if (true)
                {
                    MessageBox.Show("you can't delete this row");
                    return;
                }

                dbContext.News.Remove(n);
                dbContext.SaveChanges();

                txt_brief.Text = txt_desc.Text = txt_title.Text = "";

                dgv_news.DataSource = dbContext.News.Select(n => new
                {
                    n.Id,
                    n.Title,
                    n.Brief,
                    n.Description,
                    n.Time,
                    AuthorName = n.Author.Name,
                    CatalogName = n.Catalog.Name
                }).ToList();

                MessageBox.Show("deleted successfully");
            }
        }

        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            var n = dbContext.News.Where(n => n.Id == id).SingleOrDefault();

            txt_title.Text = n.Title;
            txt_brief.Text = n.Brief;
            txt_desc.Text = n.Description;
            dt_time.Value = n.Time;
            cb_author.SelectedValue = n.Author.Id;
            cb_catalog.SelectedValue = n.Catalog.Id;

        }
    }
}
