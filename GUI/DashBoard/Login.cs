using Quan_Ly_Khach_San_2024.DAO;
using Quan_Ly_Khach_San_2024.GUI.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (UserDao.Instance.LoginUser(txtUserName.Text, txtPassWord.Text))
            {
                MessageBox.Show("Welcome " + UserDao.Instance.LoggedInUser.Username);
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
