using Quan_Ly_Khach_San_2024.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024.GUI.DashBoard
{
    public partial class Rating : Form
    {
        BookRoomDao brDao = new BookRoomDao();
        int id;
        double rating;
        public Rating()
        {
            InitializeComponent();
        }
        public Rating(int brID)
        {
            InitializeComponent();
            id = brID;
        }

        private void btn_1s_Click(object sender, EventArgs e)
        {
            rating = 1;
            brDao.UpdateBookRoom(id, rating);
            MessageBox.Show("Đánh Giá Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btn_2s_Click(object sender, EventArgs e)
        {
            rating = 2;
            brDao.UpdateBookRoom(id, rating);
            MessageBox.Show("Đánh Giá Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btn_3s_Click(object sender, EventArgs e)
        {
            rating = 3;
            brDao.UpdateBookRoom(id, rating);
            MessageBox.Show("Đánh Giá Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btn_4s_Click(object sender, EventArgs e)
        {
            rating = 4;
            brDao.UpdateBookRoom(id, rating);
            MessageBox.Show("Đánh Giá Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btn_5s_Click(object sender, EventArgs e)
        {
            rating = 5;
            brDao.UpdateBookRoom(id, rating);
            MessageBox.Show("Đánh Giá Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
