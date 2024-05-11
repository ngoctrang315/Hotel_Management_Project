using Quan_Ly_Khach_San_2024.GUI.DashBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Quan_Ly_Khach_San_2024.DAO
{
    internal class RoomDao
    {
        public List<Object> LoadRoom(int hotelID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                return (from r in db.Rooms
                        join tr in db.TypeRooms on r.TypeRoom equals tr.TypeRoomName
                        where r.HotelID == hotelID

                        select new
                        {
                            RoomID = r.RoomID,
                            RoomNumber = r.RoomNumber,
                            TypeRoom = r.TypeRoom,
                            Price = r.Price,
                            ImgRoom = r.ImgRoom,
                            HotelID = r.HotelID,
                            Covenient = tr.Covenient,
                            SizeRoom = tr.SizeRoom,
                            Voucher = tr.Voucher
                        }).ToList<object>();
            }
        }
        public TypeRoom selectTypeRoom(string typeRname)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var typeR = db.TypeRooms.Find(typeRname);
                return typeR;
            }
        }
        public void InsertRoom(Room room)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                db.Rooms.Add(room);
                db.SaveChanges();
            }
        }

        public void UpdateRoom(Room room)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var existingHotel = db.Rooms.Find(room.RoomID);
                if (existingHotel != null)
                {

                    existingHotel.RoomNumber = room.RoomNumber;
                    existingHotel.Price = room.Price;
                    existingHotel.TypeRoom = room.TypeRoom;
                    existingHotel.ImgRoom = room.ImgRoom;
                    db.SaveChanges();
                }
            }
        }
        
        public void DeleteRoom(int roomID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var roomToDelete = db.Rooms.Find(roomID);
                if (roomToDelete != null)
                {
                    db.Rooms.Remove(roomToDelete);
                    db.SaveChanges();
                }
            }
        }
        public bool CheckRoomValues(Room room)
        {
            return !string.IsNullOrEmpty(room.RoomNumber) &&
                   room.Price > 0 &&
                   !string.IsNullOrEmpty(room.TypeRoom) &&
                   room.ImgRoom != null;
        }

        public (decimal? minPrice, decimal? maxPrice) GetMinMaxRoomPrice(int hotelID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var rooms = db.Rooms.Where(s => s.HotelID == hotelID);

                // Kiểm tra xem có phòng nào trong khách sạn không
                if (!rooms.Any())
                {
                    return (null, null); // Trả về null nếu không có phòng
                }

                // Lấy giá nhỏ nhất và lớn nhất từ danh sách các phòng
                decimal? minPrice = rooms.Min(s => s.Price);
                decimal? maxPrice = rooms.Max(s => s.Price);

                return (minPrice, maxPrice);
            }
        }

        public List<Object> GetAvailableRooms(DateTime checkin, DateTime checkout, int hotelID)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {

                var bookedRoomIds = db.BookRooms
                    .Where(br => !(checkout < br.CheckInDate || checkin > br.CheckOutDate))
                    .Select(br => br.RoomID)
                    .ToList();

                var availableRooms = db.Rooms
                    .Where(r => !bookedRoomIds.Contains(r.RoomID))
                    .ToList();

                return (from r in availableRooms
                        join tr in db.TypeRooms on r.TypeRoom equals tr.TypeRoomName
                        where r.HotelID == hotelID

                        select new
                        {
                            RoomID = r.RoomID,
                            RoomNumber = r.RoomNumber,
                            TypeRoom = r.TypeRoom,
                            Price = r.Price,
                            ImgRoom = r.ImgRoom,
                            HotelID = r.HotelID,
                            Covenient = tr.Covenient,
                            SizeRoom = tr.SizeRoom,
                            Voucher = tr.Voucher
                        }).ToList<object>();
            }
        }

    }
}
