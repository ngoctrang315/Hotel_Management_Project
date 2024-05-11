CREATE TABLE Users (
    UserID int IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Passwords NVARCHAR(50) NOT NULL,
    UserType NVARCHAR(20) NOT NULL
);

CREATE TABLE Hotels (
    HotelID int IDENTITY(1,1) PRIMARY KEY,
    HotelName NVARCHAR(100) NOT NULL,
    City NVARCHAR(100) NOT NULL,
    District NVARCHAR(100) NOT NULL,
    TypeHotel NVARCHAR(MAX), -- Có hai loại là homestay, hotel
    ImgHotel image NULL,
    Rating NVARCHAR(100),
    OwnerID int FOREIGN KEY REFERENCES Users(UserID) 
);
        
CREATE TABLE TypeRoom (
    TypeRoomName NVARCHAR(50) PRIMARY KEY, -- Loại phòng: Ví dụ: 'Standard', 'Deluxe', 'Suite'
    Covenient NVARCHAR(MAX),
    SizeRoom NVARCHAR(20),
    Voucher INT
)
CREATE TABLE Rooms (
    RoomID int IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(20) NOT NULL,
    TypeRoom NVARCHAR(50) FOREIGN KEY REFERENCES TypeRoom(TypeRoomName), -- note
    Price INT NOT NULL,
    ImgRoom image NULL,
    HotelID int FOREIGN KEY REFERENCES Hotels(HotelID) -- Tham chiếu đến khách sạn mà phòng thuộc về
);

CREATE TABLE BookRoom (
    BookingID int IDENTITY(1,1) PRIMARY KEY,
    RoomID int FOREIGN KEY REFERENCES Rooms(RoomID), -- Tham chiếu đến phòng được đặt
    CustomerID int FOREIGN KEY REFERENCES Users(UserID), -- Tham chiếu đến khách hàng đặt phòng
    HotelID int FOREIGN KEY REFERENCES Hotels(HotelID),
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalPrice float NOT NULL,
    Rating float ,
    CONSTRAINT Check_CheckOutDate CHECK (CheckOutDate > CheckInDate) -- Đảm bảo ngày trả phòng sau ngày nhận phòng
);
INSERT INTO BookRoom (RoomID, CustomerID, HotelID, CheckInDate, CheckOutDate, TotalPrice)
VALUES (1, 1, 2, '2024-05-1', '2024-05-2', 500.0);

-- Chèn dữ liệu vào bảng Users
INSERT INTO Users (Username, Passwords, UserType) VALUES
('user1', 'user1', 'Normal'),
('owner1', 'owner1', 'HotelOwner'),
('owner2', 'owner2', 'HotelOwner');

-- Dữ liệu cho bảng Hotels
INSERT INTO Hotels (HotelName, City, District, TypeHotel, Rating, OwnerID) 
VALUES 
('Sunset Hotel', 'Hà Nội', 'Hồ Gươm', 'hotel', '5 sao', 2),
('Cozy Homestay', 'Đà Nẵng', 'Quận 1', 'homestay', '4 sao', 3),
('City Lights Hotel', 'Hồ Chí Minh', 'Quận 1', 'hotel', '4 sao', 2);


-- Dữ liệu cho bảng TypeRoom
INSERT INTO TypeRoom (TypeRoomName, Covenient, SizeRoom, Voucher) 
VALUES 
('Standard', N'Giường đôi, TV, Wifi miễn phí', '2-3', 10),
('Deluxe', N'Giường đôi lớn, TV màn hình phẳng, Mini bar, Wifi miễn phí','2-4' , 15),
('Suite', N'Phòng khách riêng, Phòng ngủ riêng, Phòng tắm sang trọng, Dịch vụ ăn sáng phòng', '3-5' , 20);

-- Dữ liệu cho bảng Rooms
INSERT INTO Rooms (RoomNumber, TypeRoom, Price, HotelID) 
VALUES 
('101', 'Standard', 80.00, 1),
('102', 'Deluxe', 120.00, 1),
('103', 'Suite', 200.00, 1),
('201', 'Standard', 90.00, 2),
('202', 'Standard', 90.00, 2),
('203', 'Deluxe', 130.00, 2),
('301', 'Deluxe', 140.00, 3),
('302', 'Suite', 220.00, 3),
('303', 'Suite', 220.00, 3);


