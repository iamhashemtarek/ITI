namespace NewsCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_news = new DataGridView();
            txt_title = new TextBox();
            txt_brief = new TextBox();
            txt_desc = new TextBox();
            dt_time = new DateTimePicker();
            cb_author = new ComboBox();
            cb_catalog = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(0, 0);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersWidth = 51;
            dgv_news.Size = new Size(734, 449);
            dgv_news.TabIndex = 0;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(1067, 25);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(151, 27);
            txt_title.TabIndex = 1;
            // 
            // txt_brief
            // 
            txt_brief.Location = new Point(1067, 80);
            txt_brief.Name = "txt_brief";
            txt_brief.Size = new Size(151, 27);
            txt_brief.TabIndex = 2;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(1067, 143);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(151, 27);
            txt_desc.TabIndex = 3;
            // 
            // dt_time
            // 
            dt_time.Location = new Point(1067, 203);
            dt_time.Name = "dt_time";
            dt_time.Size = new Size(151, 27);
            dt_time.TabIndex = 4;
            // 
            // cb_author
            // 
            cb_author.FormattingEnabled = true;
            cb_author.Location = new Point(1067, 280);
            cb_author.Name = "cb_author";
            cb_author.Size = new Size(151, 28);
            cb_author.TabIndex = 5;
            // 
            // cb_catalog
            // 
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(1067, 361);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(151, 28);
            cb_catalog.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(963, 32);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 7;
            label1.Text = "title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(963, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "breif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(963, 150);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(963, 210);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 10;
            label4.Text = "time";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(963, 288);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 11;
            label5.Text = "author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(963, 369);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 12;
            label6.Text = "catalog";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(781, 68);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 13;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(781, 141);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 14;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(781, 224);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_catalog);
            Controls.Add(cb_author);
            Controls.Add(dt_time);
            Controls.Add(txt_desc);
            Controls.Add(txt_brief);
            Controls.Add(txt_title);
            Controls.Add(dgv_news);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_news;
        private TextBox txt_title;
        private TextBox txt_brief;
        private TextBox txt_desc;
        private DateTimePicker dt_time;
        private ComboBox cb_author;
        private ComboBox cb_catalog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
