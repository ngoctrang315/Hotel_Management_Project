using Guna.UI2.WinForms;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San_2024.DAO
{
    internal class HotelDao
    {
        public List<Hotel> LoadHotels(User user)
        {
            List<Hotel> hotelList = new List<Hotel>();

            try
            {
                if(user.UserType == "Normal")
                {
                    using (var db = new DeTai_5_DuLichEntities())
                    {
                        var hotels = db.Hotels.ToList();

                        foreach (var hotel in hotels)
                        {
                            Hotel hotelItem = new Hotel
                            {
                                HotelID = hotel.HotelID,
                                HotelName = hotel.HotelName,
                                District = hotel.District,
                                City = hotel.City,
                                TypeHotel = hotel.TypeHotel,
                                ImgHotel = hotel.ImgHotel,
                                Rating = hotel.Rating
                            };

                            hotelList.Add(hotelItem);
                        }
                    }
                }
                else
                {
                    using (var db = new DeTai_5_DuLichEntities())
                    {
                        var hotels = db.Hotels
                        .Where(h => h.OwnerID == user.UserID) // Filter hotels where owner matches userId
                    .ToList();


                        foreach (var hotel in hotels)
                        {
                            Hotel hotelItem = new Hotel
                            {
                                HotelID = hotel.HotelID,
                                HotelName = hotel.HotelName,
                                District = hotel.District,
                                City = hotel.City,
                                TypeHotel = hotel.TypeHotel,
                                ImgHotel = hotel.ImgHotel,
                                Rating = hotel.Rating
                            };

                            hotelList.Add(hotelItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging)
                Console.WriteLine($"An error occurred while loading hotels: {ex.Message}");
            }

            return hotelList;
        }

        public void LoadComboBoxCity(Guna2ComboBox cbbcity)
        {
            try
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    // Retrieve distinct city names from the Hotels table
                    var cities = db.Hotels.Select(h => h.City).Distinct().ToList();

                    // Clear existing items in the ComboBox
                    cbbcity.Items.Clear();
                        
                    // Add cities to the ComboBox
                    cbbcity.Items.AddRange(cities.ToArray());
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging)
                Console.WriteLine($"An error occurred while loading cities: {ex.Message}");
            }
        }

        public void LoadComboBoxDistrict(string city, Guna2ComboBox cbbdistrict)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                // Lấy danh sách các quận từ các hotel thuộc thành phố đã chọn và loại bỏ các quận trùng lặp
                var districts = db.Hotels
                                  .Where(h => h.City == city)
                                  .Select(h => h.District)
                                  .Distinct()
                                  .ToList();

                cbbdistrict.Items.Clear();
                foreach (var district in districts)
                {
                    cbbdistrict.Items.Add(district);
                }
            }
        }


        public List<Hotel> SearchHotelsByCityOrDistrict(string city, string district)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var hotels = db.Hotels
                               .Where(h => (string.IsNullOrEmpty(city) || h.City.Contains(city)) &&
                                           (string.IsNullOrEmpty(district) || h.District.Contains(district)))
                               .ToList();

                return hotels;
            }
        }

        public List<Hotel> SearchHotelsByName(string hotelName)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var hotels = db.Hotels
                               .Where(h => h.HotelName.StartsWith(hotelName))
                               .ToList();

                return hotels;
            }
        }

        public List<Hotel> SearchHotelsByRating(List<string> ratings)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var hotels = db.Hotels
                               .Where(h => ratings.Any(r => h.Rating.Contains(r)))
                               .ToList();

                return hotels;
            }
        }


        public void InsertHotel(Hotel hotel)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                db.Hotels.Add(hotel);
                db.SaveChanges();
            }
        }

        public void UpdateHotel(Hotel hotel)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var existingHotel = db.Hotels.Find(hotel.HotelID);
                if (existingHotel != null)
                {
                    
                    existingHotel.HotelName = hotel.HotelName;
                    existingHotel.City = hotel.City;
                    existingHotel.District = hotel.District;
                    existingHotel.ImgHotel = hotel.ImgHotel;
                    existingHotel.Rating = hotel.Rating;

                    db.SaveChanges();
                }
            }
        }
        public bool CheckHotelValues(Hotel hotel)
        {
            return !string.IsNullOrEmpty(hotel.HotelName) &&
                   !string.IsNullOrEmpty(hotel.City) &&
                   !string.IsNullOrEmpty(hotel.District) &&
                   !string.IsNullOrEmpty(hotel.Rating) &&
                   hotel.ImgHotel != null;
        }

        public void DeleteHotel(int hotelID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var hotelToDelete = db.Hotels.Find(hotelID);
                if (hotelToDelete != null)
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách sạn này và tất cả các phòng của nó?",
                        "Xác nhận xóa",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    // Nếu người dùng nhấn OK, tiếp tục xóa
                    if (result == DialogResult.OK)
                    {
                        // Xóa tất cả các phòng của khách sạn
                        foreach (var room in hotelToDelete.Rooms.ToList())
                        {
                            db.Rooms.Remove(room);
                        }

                        // Xóa khách sạn
                        db.Hotels.Remove(hotelToDelete);

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SaveChanges();

                        MessageBox.Show("Đã xóa khách sạn và các phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hủy bỏ xóa khách sạn và các phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Khách sạn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
