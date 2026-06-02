namespace Meal_Recommendation_And_Accounting.Forms
{
    partial class RegisterForm
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
            Register = new Label();
            lblAccount = new Label();
            lblPassword = new Label();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            IblName = new Label();
            txtName = new TextBox();
            IblPhone = new Label();
            txtPhone = new TextBox();
            btnRegister = new Button();
            IblEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Register.Location = new Point(130, 29);
            Register.Name = "Register";
            Register.Size = new Size(110, 31);
            Register.TabIndex = 0;
            Register.Text = "會員申請";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(68, 92);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(67, 15);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "使用者帳號";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(68, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "使用者密碼";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(151, 92);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(100, 23);
            txtAccount.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // IblName
            // 
            IblName.AutoSize = true;
            IblName.Location = new Point(86, 175);
            IblName.Name = "IblName";
            IblName.Size = new Size(31, 15);
            IblName.TabIndex = 5;
            IblName.Text = "姓名";
            IblName.Click += txtName_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // IblPhone
            // 
            IblPhone.AutoSize = true;
            IblPhone.Location = new Point(86, 213);
            IblPhone.Name = "IblPhone";
            IblPhone.Size = new Size(31, 15);
            IblPhone.TabIndex = 5;
            IblPhone.Text = "手機";
            IblPhone.Click += txtEmail_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(151, 210);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(165, 294);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "註冊";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // IblEmail
            // 
            IblEmail.AutoSize = true;
            IblEmail.Location = new Point(86, 252);
            IblEmail.Name = "IblEmail";
            IblEmail.Size = new Size(31, 15);
            IblEmail.TabIndex = 5;
            IblEmail.Text = "信箱";
            IblEmail.Click += txtEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 359);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(IblEmail);
            Controls.Add(txtName);
            Controls.Add(IblPhone);
            Controls.Add(IblName);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(lblPassword);
            Controls.Add(lblAccount);
            Controls.Add(Register);
            Name = "RegisterForm";
            Text = "Form1";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Register;
        private Label lblAccount;
        private Label lblPassword;
        private TextBox txtAccount;
        private TextBox txtPassword;
        private Label IblName;
        private TextBox txtName;
        private Label IblPhone;
        private TextBox txtPhone;
        private Button btnRegister;
        private Label IblEmail;
        private TextBox txtEmail;
    }
}