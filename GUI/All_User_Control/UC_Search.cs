using Quan_Ly_Khach_San_2024.DAO;
using Quan_Ly_Khach_San_2024.GUI.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024.GUI.All_User_Control
{
    public partial class UC_Search : UserControl
    {
        HotelDao hotelD = new HotelDao();
        RoomDao roomD = new RoomDao();
        public UC_Search()
        {
            InitializeComponent();
            List<Hotel> tableList = hotelD.LoadHotels(UserDao.Instance.LoggedInUser);
            showhotel(tableList);
            hotelD.LoadComboBoxCity(cbbCity);
        }

        public void showhotel(List<Hotel> tableList)
        {
            flow_pnl_UC_Search.Controls.Clear();
            foreach (Hotel item in tableList)
            {
                UC_Plow_Panel uC_Hotel = new UC_Plow_Panel()
                {
                    Width = 205,
                    Height = 250
                };

                if (item.ImgHotel != null) // Kiểm tra xem Imghotel có giá trị null hay không
                {
                    MemoryStream ms = new MemoryStream(item.ImgHotel);
                    Image img = Image.FromStream(ms);
                    uC_Hotel.picHotel.Image = img;
                }
                var (minPrice, maxPrice) = roomD.GetMinMaxRoomPrice(item.HotelID);


                uC_Hotel.lbl_flow_pannel_01.Text = "<span style='color:blue; font-weight:bold; font-size:14px;'>" + item.HotelName + "</span> --- <span style='color:blue; font-weight:bold; font-size:14px;'>" + item.Rating + "</span>";
                uC_Hotel.lbl_flow_pannel_02.Text = "Địa chỉ: " + item.District + ", " + item.City;
                uC_Hotel.lbl_flow_pannel_03.Text = "Giá: <span style='color:darkgreen; font-weight:bold;'>" + minPrice.ToString() + " VNĐ</span> -> <span style='color:darkgreen; font-weight:bold;'>" + maxPrice.ToString() + " VNĐ</span>";


                uC_Hotel.btn_delete.Click += (sender, e) => btn_deletehotel_Click(item.HotelID);
                uC_Hotel.Click += (sender, e) =>
                {
                    if (UserDao.Instance.LoggedInUser.UserType == "Normal")
                    {
                        CheckDate checkDate = new CheckDate(item);
                        checkDate.ShowDialog();
                    }
                    else
                    {
                        DetailsHotel detailsHotel = new DetailsHotel(item);
                        detailsHotel.btn_savehotel.Click += refreshUI;
                        detailsHotel.ShowDialog();
                    }
                };
                flow_pnl_UC_Search.Controls.Add(uC_Hotel);
            }
        }
        public void refreshUI(object sender, EventArgs e)
        {
            reloadUI();
        }
        public void reloadUI()
        {
            List<Hotel> tableList = hotelD.LoadHotels(UserDao.Instance.LoggedInUser);
            showhotel(tableList);
            hotelD.LoadComboBoxCity(cbbCity);

        }
        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchTerm = cbbCity.Text;
            List<Hotel> tableList = hotelD.SearchHotelsByCityOrDistrict(searchTerm, "");
            hotelD.LoadComboBoxDistrict(searchTerm, cbbDistrict);
            showhotel(tableList);
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchTerm = cbbDistrict.SelectedItem.ToString();
            List<Hotel> tableList = hotelD.SearchHotelsByCityOrDistrict("", searchTerm);
            showhotel(tableList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToString();
            List<Hotel> hotels = hotelD.SearchHotelsByName(searchTerm);
            showhotel(hotels);

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các lựa chọn trong ComboBox
            cbbCity.SelectedIndex = -1;
            cbbDistrict.Items.Clear();

            // Xóa tất cả các lựa chọn trong CheckedListBox
            for (int i = 0; i < list_star.Items.Count; i++)
            {
                list_star.SetItemChecked(i, false);
            }

            txtSearch.Text = string.Empty;
            List<Hotel> tableList = hotelD.LoadHotels(UserDao.Instance.LoggedInUser);
            showhotel(tableList);
        }

        private void list_star_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> selectedTexts = new List<string>();

            foreach (var item in list_star.CheckedItems)
            {
                selectedTexts.Add(item.ToString());
            }
            List<Hotel> hotels = hotelD.SearchHotelsByRating(selectedTexts);
            showhotel(hotels);
        }

        private void btn_addhotel_Click(object sender, EventArgs e)
        {
            AddForm addHotel = new AddForm("hotel", 0);
            addHotel.btn_save.Click += refreshUI;
            addHotel.txt_Column1.PlaceholderText = "Hotel Name";
            addHotel.txt_Column2.PlaceholderText = "City";
            addHotel.txt_Column3.PlaceholderText = "District";

            addHotel.cbb_Column4.Items.Add("1 sao");
            addHotel.cbb_Column4.Items.Add("2 sao");
            addHotel.cbb_Column4.Items.Add("3 sao");
            addHotel.cbb_Column4.Items.Add("4 sao");
            addHotel.cbb_Column4.Items.Add("5 sao");

            addHotel.cbb_Column5.Items.Add("hotel");
            addHotel.cbb_Column5.Items.Add("homestay");

            addHotel.ShowDialog();
        }

        private void btn_deletehotel_Click(int hotelID)
        {
            hotelD.DeleteHotel(hotelID);
            reloadUI();
        }

    }
}
