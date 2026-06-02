using Meal_Recommendation_And_Accounting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal_Recommendation_And_Accounting.Forms
{
    public partial class MemberManageForm : Form
    {
        private User currentUser;

        public MemberManageForm(User user)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            currentUser = user;
            this.Text = "會員頁面 - " + currentUser.Name;

            ShowUserInfo();
            
        }

        private void ShowUserInfo()
        {
            lblName.Text = currentUser.Name;
            lblAccount.Text = currentUser.Account;
            lblEmail.Text = currentUser.Email;
            lblUserType.Text = currentUser.UserType;
        }

        

        private void btnOrderRecord_Click(object sender, EventArgs e)
        {
            OrderRecordForm form = new OrderRecordForm(currentUser);
            form.ShowDialog();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定要登出嗎？",
                "登出確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();

            Form? mainForm = this.Owner;

            if (mainForm != null)
            {
                mainForm.Hide();
            }
        }
    }
}
