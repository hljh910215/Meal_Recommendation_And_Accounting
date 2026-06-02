using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Services;
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
    public partial class FindByAccountAndEmail : Form
    {
        private UserService userService = new UserService();

        public FindByAccountAndEmail()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "忘記密碼";
            lblResult.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string email = txtEmail.Text;

            if (account == "" || email == "")
            {
                MessageBox.Show("請輸入帳號和 Email");
                return;
            }

            User? user = userService.FindByAccountAndEmail(account, email);

            if (user == null)
            {
                lblResult.Text = "查無符合的會員資料";
                return;
            }

            lblResult.Text = "" + user.Password;
        }
    }
}