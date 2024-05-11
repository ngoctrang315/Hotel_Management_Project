using Quan_Ly_Khach_San_2024.DAO;
using Quan_Ly_Khach_San_2024.GUI.All_User_Control;
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
    public partial class CheckDate : Form
    {
        Hotel item;
        RoomDao roomD = new RoomDao();
        public CheckDate()
        {
            InitializeComponent();
        }
        public CheckDate(Hotel hotel)
        {
            InitializeComponent();
            item = hotel;
        }
        private void btn_searchroom_Click(object sender, EventArgs e)
        {
            DetailsHotel detailsHotel = new DetailsHotel(item, dtp_checkin.Value, dtp_checkout.Value);
            detailsHotel.ShowDialog();
            this.Close();
        }
    }
}
