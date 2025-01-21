namespace DepartmentCRUD
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
            dgv_dept = new DataGridView();
            txt_name = new TextBox();
            txt_desc = new TextBox();
            txt_loc = new TextBox();
            cb_manager = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dt_hiringDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_dept).BeginInit();
            SuspendLayout();
            // 
            // dgv_dept
            // 
            dgv_dept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dept.Location = new Point(0, 0);
            dgv_dept.Name = "dgv_dept";
            dgv_dept.RowHeadersWidth = 51;
            dgv_dept.Size = new Size(697, 449);
            dgv_dept.TabIndex = 0;
            dgv_dept.RowHeaderMouseDoubleClick += dgv_dept_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(1095, 57);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(151, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(1095, 125);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(151, 27);
            txt_desc.TabIndex = 2;
            // 
            // txt_loc
            // 
            txt_loc.Location = new Point(1095, 200);
            txt_loc.Name = "txt_loc";
            txt_loc.Size = new Size(151, 27);
            txt_loc.TabIndex = 3;
            // 
            // cb_manager
            // 
            cb_manager.FormattingEnabled = true;
            cb_manager.Location = new Point(1095, 262);
            cb_manager.Name = "cb_manager";
            cb_manager.Size = new Size(151, 28);
            cb_manager.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(933, 57);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(933, 125);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(933, 200);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(933, 262);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 9;
            label4.Text = "manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(933, 323);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 10;
            label5.Text = "hiring date";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(736, 121);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 11;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(736, 210);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 12;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(736, 298);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dt_hiringDate
            // 
            dt_hiringDate.Location = new Point(1039, 323);
            dt_hiringDate.Name = "dt_hiringDate";
            dt_hiringDate.Size = new Size(250, 27);
            dt_hiringDate.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 450);
            Controls.Add(dt_hiringDate);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_manager);
            Controls.Add(txt_loc);
            Controls.Add(txt_desc);
            Controls.Add(txt_name);
            Controls.Add(dgv_dept);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_dept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_dept;
        private TextBox txt_name;
        private TextBox txt_desc;
        private TextBox txt_loc;
        private ComboBox cb_manager;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DateTimePicker dt_hiringDate;
    }
}
