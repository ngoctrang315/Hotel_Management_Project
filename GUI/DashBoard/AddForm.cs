using Bunifu.UI.WinForms.Helpers.Transitions;
using Quan_Ly_Khach_San_2024.DAO;
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
    public partial class AddForm : Form
    {
        HotelDao hotelD = new HotelDao();
        RoomDao roomD = new RoomDao();
        string type;
        int htID;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(string typ, int hotelID)
        {
            InitializeComponent();
            type = typ;
            htID = hotelID;
            if(type != "hotel")
            {
                txt_Column3.Visible = false;
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Img.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(type == "hotel")
            {

                byte[] ImageToByteArray(Image image)
                {
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
                byte[] b = null;
                if (Img.Image != null)
                {
                    b = ImageToByteArray(Img.Image);
                }

                Hotel hotel = new Hotel();
                hotel.HotelName = txt_Column1.Text;
                hotel.District = txt_Column3.Text;
                hotel.City = txt_Column2.Text;
                hotel.Rating = cbb_Column4.SelectedItem != null ? cbb_Column4.SelectedItem.ToString() : "";
                hotel.ImgHotel = b;
                hotel.OwnerID = UserDao.Instance.LoggedInUser.UserID;
                hotel.TypeHotel = cbb_Column5.SelectedItem != null ? cbb_Column5.SelectedItem.ToString() : "";

                if (hotelD.CheckHotelValues(hotel))
                {
                    hotelD.InsertHotel(hotel);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                byte[] ImageToByteArray(Image image)
                {
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
                byte[] b = null;
                if (Img.Image != null)
                {
                    b = ImageToByteArray(Img.Image);
                }

                Room room = new Room();
                room.RoomNumber = txt_Column1.Text;
                room.TypeRoom = cbb_Column5.SelectedItem != null ? cbb_Column5.SelectedItem.ToString() : "";
                room.ImgRoom = b;
                room.HotelID = htID;
                int price;
                if (int.TryParse(txt_Column2.Text, out price))
                {
                    room.Price = price;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một giá trị số nguyên hợp lệ cho giá phòng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (roomD.CheckRoomValues(room))
                {
                    roomD.InsertRoom(room);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
