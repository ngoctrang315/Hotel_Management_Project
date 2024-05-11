using Quan_Ly_Khach_San_2024.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024.GUI.DashBoard
{
    public partial class BookRooms : Form
    {
        RoomDao roomD = new RoomDao();
        BookRoomDao brD = new BookRoomDao();
        dynamic rm;
        Hotel ht;
        public BookRooms()
        {
            InitializeComponent();
        }
        public BookRooms(Object room, Hotel hotel)
        {
            InitializeComponent();

            rm = room;
            ht = hotel;
            if ( rm.ImgRoom != null)
            {
                MemoryStream ms = new MemoryStream(rm.ImgRoom);
                Image img = Image.FromStream(ms);
                ImgRoom.Image = img;
            }

            txtRoomNumber.Text = rm.RoomNumber;
            txtPrice.Text = rm.Price.ToString();
            string typeroom = rm.TypeRoom.ToString();
            foreach (var item in cbb_typeRoom.Items)
            {
                string type = item.ToString();
                if (type == typeroom)
                {
                    cbb_typeRoom.SelectedItem = item;
                    break;
                }
            }

            lbl_infor1.Text = "<b> Hotel: </b>" + ht.HotelName + " -----<b> Đánh giá: </b>" + ht.Rating;
            lbl_infor2.Text = "<b> Loại: </b>" + rm.TypeRoom + " -----<b> Size: </b>" + rm.SizeRoom + " người" ;
            lbl_infor3.Text = "<b> Giá: </b>" + rm.Price + " VND -----<b> Voucher: </b>" + rm.Voucher + " %";
            lbl_infor4.Text = "<b> Tiện nghi: </b>" + rm.Covenient + Environment.NewLine;

            if (UserDao.Instance.LoggedInUser.UserType.ToString() == "Normal")
            {
                txtRoomNumber.Visible = false;
                cbb_typeRoom.Visible = false;
                txtPrice.Visible = false;

                btn_save.Visible = false;
                btnopen.Visible = false;
                btn_BookRoom.Visible = true;
            }

            txt_totalPrice.Text = (int.Parse(txtPrice.Text) - int.Parse(txtPrice.Text) * (rm.Voucher) / 100).ToString();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgRoom.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            byte[] ImageToByteArray(Image image)
            {
                MemoryStream stream = new MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
            byte[] b = null;
            if (ImgRoom.Image != null)
            {
                b = ImageToByteArray(ImgRoom.Image);
            }

            Room room = new Room();
            room.RoomID = rm.RoomID;
            room.RoomNumber = txtRoomNumber.Text;
            room.TypeRoom = cbb_typeRoom.SelectedItem != null ? cbb_typeRoom.SelectedItem.ToString() : "";
            room.ImgRoom = b;
            int price;
            if (int.TryParse(txtPrice.Text, out price))
            {
                room.Price = price;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị số nguyên hợp lệ cho giá phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (roomD.CheckRoomValues(room))
            {
                roomD.UpdateRoom(room);
                MessageBox.Show("Cập nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_BookRoom_Click(object sender, EventArgs e)
        {
            BookRoom br = new BookRoom();
            br.RoomID = rm.RoomID;
            br.CustomerID = UserDao.Instance.LoggedInUser.UserID;
            br.CheckInDate = dtCheckIn.Value;
            br.CheckOutDate = dtCheckOut.Value;
            br.TotalPrice = int.Parse(txt_totalPrice.Text) ;
            br.HotelID = ht.HotelID;


            if (brD.checkBookR(br))
            {
                brD.InsertBookR(br);
                MessageBox.Show("Đặt phòng thành công.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close() ;
            }
            else
            {
                    
            }
            {
                MessageBox.Show("Kiểm tra lại CheckIn và CheckOut.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
