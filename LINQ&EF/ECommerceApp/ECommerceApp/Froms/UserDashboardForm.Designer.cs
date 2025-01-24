namespace ECommerceApp.Froms
{
    partial class UserDashboardForm
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
            dataGridViewProducts = new DataGridView();
            btnViewFavorites = new Button();
            btnAddToFavorites = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(0, 225);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(799, 226);
            dataGridViewProducts.TabIndex = 0;
            // 
            // btnViewFavorites
            // 
            btnViewFavorites.Location = new Point(162, 62);
            btnViewFavorites.Name = "btnViewFavorites";
            btnViewFavorites.Size = new Size(94, 29);
            btnViewFavorites.TabIndex = 1;
            btnViewFavorites.Text = "view fav";
            btnViewFavorites.UseVisualStyleBackColor = true;
            btnViewFavorites.Click += btnAddFavorite_Click;
            // 
            // btnAddToFavorites
            // 
            btnAddToFavorites.Location = new Point(395, 72);
            btnAddToFavorites.Name = "btnAddToFavorites";
            btnAddToFavorites.Size = new Size(94, 29);
            btnAddToFavorites.TabIndex = 2;
            btnAddToFavorites.Text = "add to fav";
            btnAddToFavorites.UseVisualStyleBackColor = true;
            btnAddToFavorites.Click += btnAddToFavorites_Click;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddToFavorites);
            Controls.Add(btnViewFavorites);
            Controls.Add(dataGridViewProducts);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnViewFavorites;
        private Button btnAddToFavorites;
    }
}