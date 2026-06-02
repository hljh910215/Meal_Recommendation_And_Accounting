namespace Meal_Recommendation_And_Accounting
{
    partial class LoginForm
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
            btnAccount = new Label();
            txtAccount = new TextBox();
            btnPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            btnForgotPassword = new Button();
            btnRegister = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnAccount
            // 
            btnAccount.AutoSize = true;
            btnAccount.Location = new Point(56, 91);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(67, 15);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "使用者帳號";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(129, 88);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(117, 23);
            txtAccount.TabIndex = 1;
            // 
            // btnPassword
            // 
            btnPassword.AutoSize = true;
            btnPassword.Location = new Point(56, 131);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(67, 15);
            btnPassword.TabIndex = 2;
            btnPassword.Text = "使用者密碼";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(117, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(156, 176);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(110, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 4;
            label1.Text = "餐點推薦系統";
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(110, 220);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(75, 23);
            btnForgotPassword.TabIndex = 5;
            btnForgotPassword.Text = "忘記密碼";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnFindPassword_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(203, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "申請會員";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(252, 131);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(74, 19);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "顯示密碼";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 282);
            Controls.Add(chkShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnForgotPassword);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(btnAccount);
            Name = "LoginForm";
            Text = "登入畫面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnAccount;
        private TextBox txtAccount;
        private Label btnPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Button btnForgotPassword;
        private Button btnRegister;
        private CheckBox chkShowPassword;
    }
}
