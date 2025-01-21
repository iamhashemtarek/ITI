namespace StudentCrud
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
            dgv_students = new DataGridView();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            cb_dept = new ComboBox();
            cb_super = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(1, 1);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 51;
            dgv_students.Size = new Size(759, 546);
            dgv_students.TabIndex = 0;
            dgv_students.RowHeaderMouseDoubleClick += dgv_students_RowHeaderMouseDoubleClick;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(986, 25);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(151, 27);
            txt_fname.TabIndex = 1;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(986, 88);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(151, 27);
            txt_lname.TabIndex = 2;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(986, 150);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(151, 27);
            txt_age.TabIndex = 3;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(986, 220);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(151, 27);
            txt_address.TabIndex = 4;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(986, 278);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(151, 28);
            cb_dept.TabIndex = 5;
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(986, 342);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(151, 28);
            cb_super.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(889, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 7;
            label1.Text = "first name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(889, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(889, 150);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(889, 223);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(889, 281);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 11;
            label5.Text = "department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(889, 350);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 12;
            label6.Text = "supervisor";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1049, 458);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(914, 458);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 14;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(782, 458);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 15;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 548);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_super);
            Controls.Add(cb_dept);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(dgv_students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_students;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_age;
        private TextBox txt_address;
        private ComboBox cb_dept;
        private ComboBox cb_super;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
    }
}
