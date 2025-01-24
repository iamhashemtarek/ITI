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
    public partial class UserDashboardForm : Form
    {
        private int _userId; // Store the logged-in user's ID
        public UserDashboardForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadProducts();
        }
        private void LoadProducts()
        {
            // Fetch all products from the database
            string query = "SELECT * FROM Products";
            DataTable productsTable = new DatabaseHelper().ExecuteQuery(query);

            // Bind the products to the DataGridView
            dataGridViewProducts.DataSource = productsTable;
        }


        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            // Fetch the user's favorite products
            string query = @"
                SELECT p.ProductId, p.ProductName, p.Price 
                FROM Products p
                INNER JOIN Favorites f ON p.ProductId = f.ProductId
                WHERE f.UserId = @UserId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserId", _userId)
            };

            DataTable favoritesTable = new DatabaseHelper().ExecuteQuery(query, parameters);

            // Display the favorites in a new form or message box
            if (favoritesTable.Rows.Count > 0)
            {
                string favorites = string.Join("\n", favoritesTable.AsEnumerable()
                    .Select(row => $"{row["ProductName"]} - ${row["Price"]}"));

                MessageBox.Show("Your Favorites:\n" + favorites, "Favorites");
            }
            else
            {
                MessageBox.Show("You have no favorite products.", "Favorites");
            }
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Get the selected product's ID
                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductId"].Value);

                // Add the product to the user's favorites
                string query = "INSERT INTO Favorites (UserId, ProductId) VALUES (@UserId, @ProductId)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId", _userId),
                    new SqlParameter("@ProductId", productId)
                };

                int result = new DatabaseHelper().ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Product added to favorites!");
                }
                else
                {
                    MessageBox.Show("Failed to add product to favorites.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to add to favorites.");
            }
        }
    }
}
