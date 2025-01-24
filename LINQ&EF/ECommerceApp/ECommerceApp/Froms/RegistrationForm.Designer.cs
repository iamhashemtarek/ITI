namespace ECommerceApp.Froms
{
    partial class RegistrationForm
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
            textBox1 = new TextBox();
            txtUsername = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(445, 54);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(445, 227);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(445, 289);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(445, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(445, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(457, 384);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 40);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 296);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 8;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 234);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 168);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 106);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 11;
            label5.Text = "Password:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtUsername);
            Controls.Add(textBox1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtUsername;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}