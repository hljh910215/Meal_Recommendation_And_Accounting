namespace Meal_Recommendation_And_Accounting.Forms
{
    partial class FindByAccountAndEmail
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
            IblAccount = new Label();
            txtAccount = new TextBox();
            IblEmail = new Label();
            txtEmail = new TextBox();
            IblForgotPasswordForm = new Label();
            btnSeach = new Button();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // IblAccount
            // 
            IblAccount.AutoSize = true;
            IblAccount.Location = new Point(71, 88);
            IblAccount.Name = "IblAccount";
            IblAccount.Size = new Size(67, 15);
            IblAccount.TabIndex = 0;
            IblAccount.Text = "使用者帳號";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(144, 85);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(100, 23);
            txtAccount.TabIndex = 1;
            // 
            // IblEmail
            // 
            IblEmail.AutoSize = true;
            IblEmail.Location = new Point(71, 137);
            IblEmail.Name = "IblEmail";
            IblEmail.Size = new Size(67, 15);
            IblEmail.TabIndex = 0;
            IblEmail.Text = "使用者信箱";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // IblForgotPasswordForm
            // 
            IblForgotPasswordForm.AutoSize = true;
            IblForgotPasswordForm.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            IblForgotPasswordForm.Location = new Point(127, 36);
            IblForgotPasswordForm.Name = "IblForgotPasswordForm";
            IblForgotPasswordForm.Size = new Size(110, 31);
            IblForgotPasswordForm.TabIndex = 0;
            IblForgotPasswordForm.Text = "忘記密碼";
            // 
            // btnSeach
            // 
            btnSeach.Location = new Point(153, 177);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(84, 23);
            btnSeach.TabIndex = 2;
            btnSeach.Text = "查詢";
            btnSeach.UseVisualStyleBackColor = true;
            btnSeach.Click += btnFind_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(176, 223);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(37, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 223);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "您的密碼：";
            // 
            // FindByAccountAndEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 273);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnSeach);
            Controls.Add(txtEmail);
            Controls.Add(IblEmail);
            Controls.Add(txtAccount);
            Controls.Add(IblForgotPasswordForm);
            Controls.Add(IblAccount);
            Name = "FindByAccountAndEmail";
            Text = "FindByAccountAndEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblAccount;
        private TextBox txtAccount;
        private Label IblEmail;
        private TextBox txtEmail;
        private Label IblForgotPasswordForm;
        private Button btnSeach;
        private Label lblResult;
        private Label label1;
    }
}