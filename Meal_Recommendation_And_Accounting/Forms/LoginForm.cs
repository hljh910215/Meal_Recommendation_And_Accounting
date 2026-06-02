using Meal_Recommendation_And_Accounting.Forms;
using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Services;
using System;
using System.Windows.Forms;

namespace Meal_Recommendation_And_Accounting
{
    public partial class LoginForm : Form
    {
        private UserService userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "登入畫面";

            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;

            User? user = userService.Login(account, password);

            if (user == null)
            {
                MessageBox.Show("帳號或密碼錯誤");
                return;
            }

            MessageBox.Show("登入成功，歡迎 " + user.Name);

            MainForm mainForm = new MainForm(user);
            mainForm.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            FindByAccountAndEmail form = new FindByAccountAndEmail();
            form.ShowDialog();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}