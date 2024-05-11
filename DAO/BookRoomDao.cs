using Guna.UI2.WinForms;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San_2024.DAO
{
    internal class BookRoomDao
    {
        public void InsertBookR(BookRoom br)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                db.BookRooms.Add(br);
                db.SaveChanges();
            }
        }

        public List<Object> GetBookRoomsWhereCheckIn(User user)
        {
            if(user.UserType == "Normal")
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    DateTime today = DateTime.Today;
                    return (from b in db.BookRooms
                            join u in db.Users on b.CustomerID equals u.UserID
                            join h in db.Hotels on b.HotelID equals h.HotelID
                            join r in db.Rooms on b.RoomID equals r.RoomID
                            where b.CheckOutDate > today && b.CustomerID == user.UserID
                            select new
                            {
                                BookRoomID = b.BookingID,
                                HotelName = h.HotelName,
                                RoomNumber = r.RoomNumber,
                                Price = b.TotalPrice,
                                CheckInDate = b.CheckInDate,
                                CheckOutDate = b.CheckOutDate
                            }).ToList<object>();
                }
            }
            else
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    DateTime today = DateTime.Today;
                    return (from b in db.BookRooms
                            join u in db.Users on b.CustomerID equals u.UserID
                            join h in db.Hotels on b.HotelID equals h.HotelID
                            join r in db.Rooms on b.RoomID equals r.RoomID
                            where b.CheckOutDate > today && h.OwnerID == user.UserID
                            select new
                            {
                                BookRoomID = b.BookingID,
                                HotelName = h.HotelName,
                                RoomNumber = r.RoomNumber,
                                Price = b.TotalPrice,
                                CheckInDate = b.CheckInDate,
                                CheckOutDate = b.CheckOutDate
                            }).ToList<object>();
                }
            }
        }


        public List<Object> GetBookRoomsWhereCheckOut(User user)
        {
            if (user.UserType == "Normal")
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    DateTime today = DateTime.Today;
                    return (from b in db.BookRooms
                            join u in db.Users on b.CustomerID equals u.UserID
                            join h in db.Hotels on b.HotelID equals h.HotelID
                            join r in db.Rooms on b.RoomID equals r.RoomID
                            where b.CheckOutDate < today && b.CustomerID == user.UserID
                            select new
                            {
                                BookRoomID = b.BookingID,
                                HotelName = h.HotelName,
                                RoomNumber = r.RoomNumber,
                                Price = b.TotalPrice,
                                CheckInDate = b.CheckInDate,
                                CheckOutDate = b.CheckOutDate
                            }).ToList<object>();
                }
            }
            else
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    DateTime today = DateTime.Today;
                    return (from b in db.BookRooms
                            join u in db.Users on b.CustomerID equals u.UserID
                            join h in db.Hotels on b.HotelID equals h.HotelID
                            join r in db.Rooms on b.RoomID equals r.RoomID
                            where b.CheckOutDate < today && h.OwnerID == user.UserID
                            select new
                            {
                                BookRoomID = b.BookingID,
                                HotelName = h.HotelName,
                                RoomNumber = r.RoomNumber,
                                Price = b.TotalPrice,
                                CheckInDate = b.CheckInDate,
                                CheckOutDate = b.CheckOutDate
                            }).ToList<object>();
                }
            }
        }

        public List<Object> GetBookRoomsMonth(int month, User user)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                DateTime today = DateTime.Today;
                return (from b in db.BookRooms
                        join u in db.Users on b.CustomerID equals u.UserID
                        join h in db.Hotels on b.HotelID equals h.HotelID
                        join r in db.Rooms on b.RoomID equals r.RoomID
                        where b.CheckOutDate < today && h.OwnerID == user.UserID && b.CheckOutDate.Month == month

                        select new
                        {
                            Price = b.TotalPrice,
                        }).ToList<object>();
            }
        }
        public List<Object> GetBookRoomsQuarter(int quarter, User user)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                DateTime today = DateTime.Today; // Định nghĩa today ở đây

                // Tính toán ngày đầu tiên của quý
                int startMonth = (quarter - 1) * 3 + 1; // Tháng đầu tiên của quý
                int endMonth = startMonth + 2; // Tháng cuối cùng của quý
                DateTime startDate = new DateTime(today.Year, startMonth, 1);
                DateTime endDate = new DateTime(today.Year, endMonth, DateTime.DaysInMonth(today.Year, endMonth));

                return (from b in db.BookRooms
                        join u in db.Users on b.CustomerID equals u.UserID
                        join h in db.Hotels on b.HotelID equals h.HotelID
                        join r in db.Rooms on b.RoomID equals r.RoomID
                        where b.CheckOutDate >= startDate && b.CheckOutDate <= endDate && h.OwnerID == user.UserID && b.CheckOutDate < today

                        select new
                        {
                            Price = b.TotalPrice,
                        }).ToList<Object>();
            }
        }

        public List<Object> GetBookRoomsYear(int year, User user)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                DateTime today = DateTime.Today; // Định nghĩa today ở đây

                // Tính toán ngày đầu tiên và cuối cùng của năm
                DateTime startDate = new DateTime(year, 1, 1);
                DateTime endDate = new DateTime(year, 12, 31);

                return (from b in db.BookRooms
                        join u in db.Users on b.CustomerID equals u.UserID
                        join h in db.Hotels on b.HotelID equals h.HotelID
                        join r in db.Rooms on b.RoomID equals r.RoomID
                        where b.CheckOutDate >= startDate && b.CheckOutDate <= endDate && h.OwnerID == user.UserID && b.CheckOutDate < today

                        select new
                        {
                            Price = b.TotalPrice,
                        }).ToList<Object>();
            }
        }
        public void DeleteBookRoom(int brID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var BookroomToDelete = db.BookRooms.Find(brID);
                if (BookroomToDelete != null)
                {
                    db.BookRooms.Remove(BookroomToDelete);
                    db.SaveChanges();
                }
            }
        }

        public bool checkBookR(BookRoom br)
        {
            return br.CheckInDate < br.CheckOutDate && br.CheckInDate > DateTime.Today; 
        }
        public void LoadComboBoxYear(Guna2ComboBox cbbyear, User user)
        {
            try
            {
                using (var db = new DeTai_5_DuLichEntities())
                {
                    // Retrieve distinct years from the BookRooms table based on userId
                    var years = (from b in db.BookRooms
                                 join h in db.Hotels on b.HotelID equals h.HotelID
                                 where h.OwnerID == user.UserID
                                 select b.CheckOutDate.Year)
                                 .Distinct()
                                 .ToList();

                    // Clear existing items in the ComboBox
                    cbbyear.Items.Clear();

                    // Add years to the ComboBox
                    cbbyear.Items.AddRange(years.Select(y => (object)y).ToArray());
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging)
                Console.WriteLine($"An error occurred while loading years: {ex.Message}");
            }
        }

        public void UpdateBookRoom(int brID, double rating)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var existingHotel = db.BookRooms.Find(brID);
                if (existingHotel != null)
                {

                    existingHotel.Rating = rating;
                    db.SaveChanges();
                }
            }
        }
        public bool CheckBookRoom(int brID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var existingBooking = db.BookRooms.Find(brID);
                if (existingBooking != null)
                {
                    if (existingBooking.Rating == null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }


    }
}
