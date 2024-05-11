using Quan_Ly_Khach_San_2024.All_User_Control;
using Quan_Ly_Khach_San_2024.DAO;
using Quan_Ly_Khach_San_2024.GUI.All_User_Control;
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

namespace Quan_Ly_Khach_San_2024.GUI.DashBoard
{
    public partial class DetailsHotel : Form
    {
        RoomDao roomD = new RoomDao();
        HotelDao hotelD = new HotelDao();
        Hotel ht;
        DateTime ckin;
        DateTime ckout;
        public DetailsHotel()
        {
            InitializeComponent();
        }
        public DetailsHotel(Hotel hotel)
        {
            InitializeComponent();
            ht = hotel;
            showdata(ht);
            reloadUI();
        }
        public DetailsHotel(Hotel hotel, DateTime checkin, DateTime checkout)
        {
            InitializeComponent();
            ht = hotel;
            ckin = checkin;
            ckout = checkout;

            showdata(ht);

            reloadUI();

        }
        public void showdata(Hotel hotel)
        {
            if (hotel.ImgHotel != null)
            {
                MemoryStream ms = new MemoryStream(hotel.ImgHotel);
                Image img = Image.FromStream(ms);
                ImgDetail.Image = img;
            }
            txt_hotelname.Text = hotel.HotelName;
            txt_hotelcity.Text = hotel.City;
            txt_hoteldistrict.Text = hotel.District;

            string hotelRating = hotel.Rating;
            foreach (var item in cbb_hotelrating.Items)
            {
                string rating = item.ToString();
                if (rating == hotelRating)
                {
                    cbb_hotelrating.SelectedItem = item;
                    break;
                }
            }

            string hotelType = hotel.TypeHotel;
            foreach (var item in cbb_typeRoom.Items)
            {
                string typeH = item.ToString();
                if (typeH == hotelType)
                {
                    cbb_typeRoom.SelectedItem = item;
                    break;
                }
            }
            lbl_infor_01.Text = "--- " + hotel.TypeHotel.ToUpper() + " ---";
            lbl_infor_02.Text = "<span style='color:blue; font-weight:bold;font-size:16px;'>" + hotel.HotelName + "</span>";
            lbl_infor_03.Text = "<b> Đánh giá: </b>" + hotel.Rating;
            lbl_infor_04.Text = "<b> Địa chỉ: </b>" + hotel.District + ", " + hotel.City;

            if (UserDao.Instance.LoggedInUser.UserType == "Normal")
            {
                btn_open.Visible = false;
                btn_addroom.Visible = false;
                btn_savehotel.Visible = false;


                txt_hotelname.Visible = false;
                txt_hoteldistrict.Visible = false;
                txt_hotelcity.Visible = false;
                cbb_hotelrating.Visible = false;
                cbb_typeRoom.Visible = false;

            }
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgDetail.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }
        }
        public void showroom(List<Object> tableList)
        {
            flPnDSRoom.Controls.Clear();
            foreach (var i in tableList)
            {
                dynamic item = i;
                UC_Plow_Panel uC_Room = new UC_Plow_Panel()
                {
                    Width = 215,
                    Height = 250
                };
                if (item.ImgRoom != null) // Kiểm tra xem Imghotel có giá trị null hay không
                {
                    MemoryStream ms = new MemoryStream(item.ImgRoom);
                    Image img = Image.FromStream(ms);
                    uC_Room.picHotel.Image = img;
                }

                uC_Room.lbl_flow_pannel_01.Text = "<b> Tên Phòng: </b>" + item.RoomNumber + "<b> - Loại: </b>" + item.TypeRoom + "<b> - Size: </b>" + item.SizeRoom + " người";
                uC_Room.lbl_flow_pannel_02.Text = "<b> Giá: </b>" + item.Price + " VND" + "<b> - Voucher: </b>" + item.Voucher + " %";
                uC_Room.lbl_flow_pannel_03.Text = "<b> Tiện nghi:  </b>" + item.Covenient + Environment.NewLine;
                uC_Room.btn_delete.Click += (sender, e) => btn_deleteroom_Click(item.RoomID);
                uC_Room.Click += (sender, e) =>
                {

                    BookRooms bookR = new BookRooms(item, ht);
                    bookR.btn_save.Click += refreshUI;
                    bookR.ShowDialog();
                    
                };
                flPnDSRoom.Controls.Add(uC_Room);
            }
        }
        public void refreshUI(object sender, EventArgs e)
        {
            reloadUI();
        }
        public void reloadUI()
        {
            List<Object> tableList;
            if (UserDao.Instance.LoggedInUser.UserType == "Normal")
            {
                tableList = roomD.GetAvailableRooms(ckin, ckout, ht.HotelID);
            }
            else
            {
                tableList = roomD.LoadRoom(ht.HotelID);
            }
            showroom(tableList);
        }
        private void btn_savehotel_Click(object sender, EventArgs e)
        {
            byte[] ImageToByteArray(Image image)
            {
                MemoryStream stream = new MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
            byte[] b = null;
            if (ImgDetail.Image != null)
            {
                b = ImageToByteArray(ImgDetail.Image);
            }

            Hotel hotel = new Hotel();

            hotel.HotelID = ht.HotelID;
            hotel.HotelName = txt_hotelname.Text;
            hotel.District = txt_hoteldistrict.Text;
            hotel.City = txt_hotelcity.Text;
            hotel.Rating = cbb_hotelrating.SelectedItem != null ? cbb_hotelrating.SelectedItem.ToString() : "";
            hotel.ImgHotel = b;
            hotel.OwnerID = UserDao.Instance.LoggedInUser.UserID;

            if (hotelD.CheckHotelValues(hotel))
            {
                hotelD.UpdateHotel(hotel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            AddForm addroom = new AddForm("room",ht.HotelID);
            addroom.btn_save.Click += refreshUI;

            addroom.txt_Column1.PlaceholderText = "Room Number";
            addroom.txt_Column2.PlaceholderText = "Price";
            addroom.txt_Column3.PlaceholderText = "Type Room";

            addroom.cbb_Column4.Items.Add("Empty");
            addroom.cbb_Column4.Items.Add("Not Empty");

            addroom.cbb_Column5.Items.Add("Standard");
            addroom.cbb_Column5.Items.Add("Deluxe");
            addroom.cbb_Column5.Items.Add("Suite");

            addroom.ShowDialog();
        }
        private void btn_deleteroom_Click(int roomID)
        {
            roomD.DeleteRoom(roomID);
            reloadUI();
        }

    }
}
