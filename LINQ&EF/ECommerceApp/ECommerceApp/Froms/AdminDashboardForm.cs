using ECommerceApp.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerceApp.Froms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
        }
        private void LoadCategories()
        {
            // Fetch all categories from the database
            string query = "SELECT * FROM Categories";
            DataTable categoriesTable = new DatabaseHelper().ExecuteQuery(query);

            // Bind the categories to the DataGridView
            dataGridViewCategories.DataSource = categoriesTable;
        }

        private void LoadProducts()
        {
            // Fetch all products from the database
            string query = "SELECT * FROM Products";
            DataTable productsTable = new DatabaseHelper().ExecuteQuery(query);

            // Bind the products to the DataGridView
            dataGridViewProducts.DataSource = productsTable;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            if (!string.IsNullOrEmpty(categoryName))
            {
                // Insert the new category into the database
                string query = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@CategoryName", categoryName)
                };

                int result = new DatabaseHelper().ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Category added successfully!");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to add category.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int categoryId = int.Parse(cmbCategories.SelectedValue.ToString());

            if (!string.IsNullOrEmpty(productName) && price > 0 && categoryId > 0)
            {
                // Insert the new product into the database
                string query = "INSERT INTO Products (ProductName, Price, CategoryId) VALUES (@ProductName, @Price, @CategoryId)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductName", productName),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@CategoryId", categoryId)
                };

                int result = new DatabaseHelper().ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Product added successfully!");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all product details.");
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Load categories into the ComboBox
            string query = "SELECT * FROM Categories";
            DataTable categoriesTable = new DatabaseHelper().ExecuteQuery(query);

            cmbCategories.DataSource = categoriesTable;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
        }
    }
}
