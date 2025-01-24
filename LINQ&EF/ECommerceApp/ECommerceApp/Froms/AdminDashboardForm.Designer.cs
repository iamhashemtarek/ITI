namespace ECommerceApp.Froms
{
    partial class AdminDashboardForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridViewProducts = new DataGridView();
            dataGridViewCategories = new DataGridView();
            txtCategoryName = new TextBox();
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddCategory = new Button();
            btnAddProduct = new Button();
            txtPrice = new TextBox();
            label3 = new Label();
            cmbCategories = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(694, 260);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(604, 188);
            dataGridViewProducts.TabIndex = 0;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(0, 260);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(314, 188);
            dataGridViewCategories.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(218, 34);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 27);
            txtCategoryName.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(218, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "product";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(432, 34);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(199, 29);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "add category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(433, 111);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(198, 29);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "add  product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(218, 150);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 157);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(218, 211);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(151, 28);
            cmbCategories.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 211);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 11;
            label4.Text = "Category";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 450);
            Controls.Add(label4);
            Controls.Add(cmbCategories);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(btnAddProduct);
            Controls.Add(btnAddCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryName);
            Controls.Add(dataGridViewCategories);
            Controls.Add(dataGridViewProducts);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCategories;
        private TextBox txtCategoryName;
        private TextBox txtProductName;
        private Label label1;
        private Label label2;
        private Button btnAddCategory;
        private Button btnAddProduct;
        private TextBox txtPrice;
        private Label label3;
        private ComboBox cmbCategories;
        private Label label4;
    }
}