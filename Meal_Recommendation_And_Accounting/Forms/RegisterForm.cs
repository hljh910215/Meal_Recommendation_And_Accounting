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
    public partial class RegisterForm : Form
    {
        private UserService userService = new UserService();

        public RegisterForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            this.Text = "申請會員";
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if (account == "" || password == "" || name == "" || phone == ""|| email == "")
            {
                MessageBox.Show("請完整輸入會員資料");
                return;
            }

            bool result = userService.Register(account, password, name,phone, email);

            if (result)
            {
                MessageBox.Show("註冊成功，請回登入畫面登入");
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號已存在，或資料不完整");
            }
        }
    }
}
