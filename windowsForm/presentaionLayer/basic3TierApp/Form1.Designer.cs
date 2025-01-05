namespace basic3TierApp
{
    partial class Instructor
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
            dgv_instructors = new DataGridView();
            lbl_id = new Label();
            txt_name = new TextBox();
            lbl_name = new Label();
            lbl_degree = new Label();
            lbl_salary = new Label();
            num_id = new NumericUpDown();
            lbl_dept = new Label();
            txt_degree = new TextBox();
            num_salary = new NumericUpDown();
            num_dept = new NumericUpDown();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_salary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_dept).BeginInit();
            SuspendLayout();
            // 
            // dgv_instructors
            // 
            dgv_instructors.BackgroundColor = Color.GhostWhite;
            dgv_instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructors.Location = new Point(3, 2);
            dgv_instructors.Name = "dgv_instructors";
            dgv_instructors.RowHeadersWidth = 51;
            dgv_instructors.Size = new Size(670, 519);
            dgv_instructors.TabIndex = 0;
            dgv_instructors.RowHeaderMouseDoubleClick += dgv_instructors_RowHeaderMouseDoubleClick;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(734, 86);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(22, 20);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "id";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(858, 127);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(150, 27);
            txt_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(734, 130);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(46, 20);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "name";
            // 
            // lbl_degree
            // 
            lbl_degree.AutoSize = true;
            lbl_degree.Location = new Point(734, 172);
            lbl_degree.Name = "lbl_degree";
            lbl_degree.Size = new Size(56, 20);
            lbl_degree.TabIndex = 4;
            lbl_degree.Text = "degree";
            // 
            // lbl_salary
            // 
            lbl_salary.AutoSize = true;
            lbl_salary.Location = new Point(734, 213);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(47, 20);
            lbl_salary.TabIndex = 5;
            lbl_salary.Text = "salary";
            // 
            // num_id
            // 
            num_id.Location = new Point(858, 86);
            num_id.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            num_id.Name = "num_id";
            num_id.Size = new Size(150, 27);
            num_id.TabIndex = 6;
            // 
            // lbl_dept
            // 
            lbl_dept.AutoSize = true;
            lbl_dept.Location = new Point(734, 253);
            lbl_dept.Name = "lbl_dept";
            lbl_dept.Size = new Size(87, 20);
            lbl_dept.TabIndex = 7;
            lbl_dept.Text = "department";
            // 
            // txt_degree
            // 
            txt_degree.Location = new Point(858, 172);
            txt_degree.Name = "txt_degree";
            txt_degree.Size = new Size(150, 27);
            txt_degree.TabIndex = 8;
            // 
            // num_salary
            // 
            num_salary.Location = new Point(858, 205);
            num_salary.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            num_salary.Name = "num_salary";
            num_salary.Size = new Size(150, 27);
            num_salary.TabIndex = 9;
            // 
            // num_dept
            // 
            num_dept.Location = new Point(858, 246);
            num_dept.Name = "num_dept";
            num_dept.Size = new Size(150, 27);
            num_dept.TabIndex = 10;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(696, 326);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(107, 43);
            btn_add.TabIndex = 11;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(818, 326);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(107, 43);
            btn_update.TabIndex = 12;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(941, 326);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(107, 43);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(736, 397);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(272, 54);
            btn_save.TabIndex = 15;
            btn_save.Text = "save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1070, 522);
            Controls.Add(btn_save);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(num_dept);
            Controls.Add(num_salary);
            Controls.Add(txt_degree);
            Controls.Add(lbl_dept);
            Controls.Add(num_id);
            Controls.Add(lbl_salary);
            Controls.Add(lbl_degree);
            Controls.Add(lbl_name);
            Controls.Add(txt_name);
            Controls.Add(lbl_id);
            Controls.Add(dgv_instructors);
            Name = "Instructor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_salary).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_dept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_instructors;
        private Label lbl_id;
        private TextBox txt_name;
        private Label lbl_name;
        private Label lbl_degree;
        private Label lbl_salary;
        private NumericUpDown num_id;
        private Label lbl_dept;
        private TextBox txt_degree;
        private NumericUpDown num_salary;
        private NumericUpDown num_dept;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_save;
    }
}
