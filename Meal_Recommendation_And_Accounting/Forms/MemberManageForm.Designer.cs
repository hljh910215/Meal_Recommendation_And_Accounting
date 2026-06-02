namespace Meal_Recommendation_And_Accounting.Forms
{
    partial class MemberManageForm
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
            lblName1 = new Label();
            lblAccount1 = new Label();
            lblEmail1 = new Label();
            lblUserType1 = new Label();
            btnOrderRecordForm = new Button();
            btnBackToMain = new Button();
            btnLogOut = new Button();
            label5 = new Label();
            lblName = new Label();
            lblAccount = new Label();
            lblEmail = new Label();
            lblUserType = new Label();
            SuspendLayout();
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Microsoft JhengHei UI", 12F);
            lblName1.Location = new Point(101, 115);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(73, 20);
            lblName1.TabIndex = 0;
            lblName1.Text = "會員姓名";
            // 
            // lblAccount1
            // 
            lblAccount1.AutoSize = true;
            lblAccount1.Font = new Font("Microsoft JhengHei UI", 12F);
            lblAccount1.Location = new Point(101, 153);
            lblAccount1.Name = "lblAccount1";
            lblAccount1.Size = new Size(73, 20);
            lblAccount1.TabIndex = 0;
            lblAccount1.Text = "會員帳號";
            // 
            // lblEmail1
            // 
            lblEmail1.AutoSize = true;
            lblEmail1.Font = new Font("Microsoft JhengHei UI", 12F);
            lblEmail1.Location = new Point(101, 192);
            lblEmail1.Name = "lblEmail1";
            lblEmail1.Size = new Size(73, 20);
            lblEmail1.TabIndex = 0;
            lblEmail1.Text = "會員信箱";
            // 
            // lblUserType1
            // 
            lblUserType1.AutoSize = true;
            lblUserType1.Font = new Font("Microsoft JhengHei UI", 12F);
            lblUserType1.Location = new Point(101, 230);
            lblUserType1.Name = "lblUserType1";
            lblUserType1.Size = new Size(73, 20);
            lblUserType1.TabIndex = 0;
            lblUserType1.Text = "會員類型";
            // 
            // btnOrderRecordForm
            // 
            btnOrderRecordForm.Location = new Point(99, 44);
            btnOrderRecordForm.Name = "btnOrderRecordForm";
            btnOrderRecordForm.Size = new Size(75, 23);
            btnOrderRecordForm.TabIndex = 2;
            btnOrderRecordForm.Text = "訂單歷史";
            btnOrderRecordForm.UseVisualStyleBackColor = true;
            btnOrderRecordForm.Click += btnOrderRecord_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(192, 44);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(75, 23);
            btnBackToMain.TabIndex = 2;
            btnBackToMain.Text = "返回主畫面";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(286, 44);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 23);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "登出";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(174, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 4;
            label5.Text = "會員頁面";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft JhengHei UI", 12F);
            lblName.Location = new Point(205, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 20);
            lblName.TabIndex = 0;
            lblName.Text = "顯示會員姓名";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Microsoft JhengHei UI", 12F);
            lblAccount.Location = new Point(205, 153);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(105, 20);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "顯示會員帳號";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft JhengHei UI", 12F);
            lblEmail.Location = new Point(205, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "顯示會員信箱";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Microsoft JhengHei UI", 12F);
            lblUserType.Location = new Point(205, 230);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(105, 20);
            lblUserType.TabIndex = 0;
            lblUserType.Text = "顯示會員類型";
            // 
            // MemberManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 331);
            Controls.Add(label5);
            Controls.Add(btnLogOut);
            Controls.Add(btnBackToMain);
            Controls.Add(btnOrderRecordForm);
            Controls.Add(lblUserType1);
            Controls.Add(lblEmail1);
            Controls.Add(lblAccount1);
            Controls.Add(lblUserType);
            Controls.Add(lblEmail);
            Controls.Add(lblAccount);
            Controls.Add(lblName);
            Controls.Add(lblName1);
            Name = "MemberManageForm";
            Text = "MemberManageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName1;
        private Label lblAccount1;
        private Label lblEmail1;
        private Label lblUserType1;
        private Button btnOrderRecordForm;
        private Button btnBackToMain;
        private Button btnLogOut;
        private Label label5;
        private Label lblName;
        private Label lblAccount;
        private Label lblEmail;
        private Label lblUserType;
    }
}