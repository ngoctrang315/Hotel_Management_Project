using System;
using Quan_Ly_Khach_San_2024.DAO;
using System.Windows.Forms;
using Quan_Ly_Khach_San_2024.GUI.All_User_Control;

namespace Quan_Ly_Khach_San_2024
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            btnHome.PerformClick();
            UpdateUI();
        }


        #region Ẩn hiện các button theo loại User đăng nhập --> Normal & Hotel Owner
        private void btnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.Visible = true;
            uC_Home1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = true;
            uC_Search1.BringToFront();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {

        }
        
        
        private void UpdateUI()
        {
            if ( UserDao.Instance.LoggedInUser.UserType.ToString() == "Normal")
            {
                // Ẩn hoặc hiện các nút tương ứng cho người dùng Normal
                uC_Search1.btn_addhotel.Visible = false;
                //button dashboard
                btnHome.Visible = true;
                btnSearch.Visible = true;

                btn_History.Visible = true;
                btn_History.Text = "History";
            }
        }
        #endregion

        #region Events
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Home1.btnFind.Click += btnFind_Click;// sử dụng btnFind của UC_Home trong dashboard.           
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = true;
            uC_Search1.BringToFront();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        #endregion

        private void btn_history_Click(object sender, EventArgs e)
        {
            uC_History1.Visible = true;
            uC_History1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

    }
}
