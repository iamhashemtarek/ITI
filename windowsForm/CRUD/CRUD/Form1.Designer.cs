namespace CRUD
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
            dataGridView = new DataGridView();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_duration = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_cancel = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            cb_topic = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(0, 211);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 200;
            dataGridView.Size = new Size(729, 239);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentDoubleClick += dataGridView_CellContentDoubleClick;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(47, 52);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(370, 50);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(212, 52);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(125, 27);
            txt_duration.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 27);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 29);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 27);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "topic";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(68, 141);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 9;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(227, 141);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(543, 141);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Visible = false;
            btn_delete.Click += btn_delete_click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(383, 141);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 12;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Visible = false;
            btn_update.Click += btn_update_click;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(543, 51);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(151, 28);
            cb_topic.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(cb_topic);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_duration);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += getAllCourses;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_duration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_cancel;
        private Button btn_delete;
        private Button btn_update;
        private ComboBox cb_topic;
    }
}
