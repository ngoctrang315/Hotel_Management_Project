    using Quan_Ly_Khach_San_2024.DAO;
using Quan_Ly_Khach_San_2024.GUI.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024.GUI.All_User_Control
{
    public partial class UC_History : UserControl
    {
        BookRoomDao brD = new BookRoomDao();
        int brID;
        public UC_History()
        {
            InitializeComponent();
            brD.LoadComboBoxYear(cbb_year, UserDao.Instance.LoggedInUser);
            try
            {
                if (UserDao.Instance.LoggedInUser.UserType == "Normal")
                {
                    Panel_Visable.Visible = true;
                }
            }
            catch
            {
                Console.WriteLine("");
            }
            showboor();
        }
        public void showboor()
        {
            flow_pnl_UC_Book_CanCancel.Controls.Clear();
            flow_pnl_UC_Book_DontCancel.Controls.Clear();


            // Tạo một instance mới của UC_BookList cho flow_pnl_UC_Book_CanCancel.Controls
            UC_BookList uC_BookListTitleCanCancel = new UC_BookList();
            uC_BookListTitleCanCancel.inforbook1.Text = "HotelName";
            uC_BookListTitleCanCancel.inforbook2.Text = "RoomNumber";
            uC_BookListTitleCanCancel.inforbook3.Text = "Price";
            uC_BookListTitleCanCancel.inforbook4.Text = "CheckInDate";
            uC_BookListTitleCanCancel.inforbook5.Text = "CheckOutDate";
            flow_pnl_UC_Book_CanCancel.Controls.Add(uC_BookListTitleCanCancel);

            // Tạo một instance mới khác của UC_BookList cho flow_pnl_UC_Book_DontCancel.Controls
            UC_BookList uC_BookListTitleDontCancel = new UC_BookList();
            uC_BookListTitleDontCancel.inforbook1.Text = "HotelName";
            uC_BookListTitleDontCancel.inforbook2.Text = "RoomNumber";
            uC_BookListTitleDontCancel.inforbook3.Text = "Price";
            uC_BookListTitleDontCancel.inforbook4.Text = "CheckInDate";
            uC_BookListTitleDontCancel.inforbook5.Text = "CheckOutDate";
            flow_pnl_UC_Book_DontCancel.Controls.Add(uC_BookListTitleDontCancel);

            var hist = brD.GetBookRoomsWhereCheckIn(UserDao.Instance.LoggedInUser);
            var histories = brD.GetBookRoomsWhereCheckOut(UserDao.Instance.LoggedInUser);
            foreach (Object it in hist)
            {
                dynamic item = it;
                UC_BookList uC_BookList = new UC_BookList();
                uC_BookList.inforbook1.Text = item.HotelName;
                uC_BookList.inforbook2.Text = item.RoomNumber;
                uC_BookList.inforbook3.Text = item.Price.ToString();
                uC_BookList.inforbook4.Text = item.CheckInDate.ToString("yyyy-MM-dd");
                uC_BookList.inforbook5.Text = item.CheckOutDate.ToString("yyyy-MM-dd");
                foreach (Control control in uC_BookList.Controls)
                {
                    control.Click += (sender, e) => Click1(item);
                    brID = item.BookRoomID;
                }
                flow_pnl_UC_Book_CanCancel.Controls.Add(uC_BookList);
            }

            foreach (Object it in histories)
            {
                dynamic item = it;
                UC_BookList uC_BookList2 = new UC_BookList();
                uC_BookList2.inforbook1.Text = item.HotelName;
                uC_BookList2.inforbook2.Text = item.RoomNumber;
                uC_BookList2.inforbook3.Text = item.Price.ToString();
                uC_BookList2.inforbook4.Text = item.CheckInDate.ToString("yyyy-MM-dd");
                uC_BookList2.inforbook5.Text = item.CheckOutDate.ToString("yyyy-MM-dd");
                foreach (Control control in uC_BookList2.Controls)
                {
                    control.Click += (sender, e) => Click2(item);
                    brID = item.BookRoomID;
                }
                flow_pnl_UC_Book_DontCancel.Controls.Add(uC_BookList2);
            }
        }
        public void Click1(dynamic ob)
        {
            txt_hotelName.Text = ob.HotelName;
            txt_roomNumber.Text = ob.RoomNumber;
            txt_CheckIn.Text = ob.CheckInDate.ToString("yyyy-MM-dd");
            txt_CheckOut.Text = ob.CheckOutDate.ToString("yyyy-MM-dd");
            txt_Price.Text = ob.Price.ToString();
        }
        BookRoomDao brDao = new BookRoomDao();
        public void Click2(dynamic ob)
        {
            if (brDao.CheckBookRoom(brID))
            {
                Rating rating = new Rating(brID);
                rating.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Đã Đánh Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_cancelBook_Click(object sender, EventArgs e)
        {
            if(cbb_lidoHuy.SelectedItem != null)
            {
                brD.DeleteBookRoom(brID);
                MessageBox.Show("Hủy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                reset();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn lí do hủy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            showboor();
            txt_hotelName.Text = null;
            txt_roomNumber.Text = null;
            txt_Price.Text = null;
            txt_CheckIn.Text = null;
            txt_CheckOut.Text = null;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = cbb_Month.Text;
            var histories = brD.GetBookRoomsMonth(int.Parse(month), UserDao.Instance.LoggedInUser);
            double totalPrice = CalculateTotalPrice(histories);
            txt_DoanhThuMonth.Text = totalPrice.ToString();
        }
        private double CalculateTotalPrice(List<object> histories)
        {
            double totalPrice = 0;

            foreach (dynamic history in histories)
            {
                totalPrice += history.Price;
            }

            return totalPrice;
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string quarter = cbb_quarter.Text;
            var histories = brD.GetBookRoomsQuarter(int.Parse(quarter), UserDao.Instance.LoggedInUser);
            double totalPrice = CalculateTotalPrice(histories);
            txt_DoanhThuQuarter.Text = totalPrice.ToString();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cbb_year.Text;
            var histories = brD.GetBookRoomsYear(int.Parse(year), UserDao.Instance.LoggedInUser);
            double totalPrice = CalculateTotalPrice(histories);
            txt_year.Text = totalPrice.ToString();
        }

    }
}
