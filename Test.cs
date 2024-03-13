using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024
{
    public partial class Test : Form
    {
        private Dictionary<string, List<string>> cityDistricts = new Dictionary<string, List<string>>();
        public Test()
        {
            InitializeComponent();
            // Thêm các thành phố và quận vào từ điển
            cityDistricts.Add("Hanoi", new List<string> { "Ba Dinh", "Hoan Kiem", "Cau Giay" });
            cityDistricts.Add("Ho Chi Minh City", new List<string> { "District 1", "District 2", "District 3" });

            // Thêm các thành phố vào ComboBox
            foreach (var city in cityDistricts.Keys)
            {
                cbbCity.Items.Add(city);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các quận hiện tại
            cbbDistrict.Items.Clear();

            // Lấy tên thành phố được chọn
            string selectedCity = cbbCity.SelectedItem.ToString();

            // Lấy danh sách quận của thành phố được chọn từ từ điển và thêm vào ComboBox
            foreach (var district in cityDistricts[selectedCity])
            {
                cbbDistrict.Items.Add(district);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCity = cbbCity.SelectedItem.ToString();
            string selectedDistrict = cbbDistrict.SelectedItem.ToString();

            MessageBox.Show("Searching in " + selectedDistrict + ", " + selectedCity);
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
