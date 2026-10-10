CREATE DATABASE VehicleBookingDB;

USE VehicleBookingDB;

CREATE TABLE Bookings(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerName NVARCHAR(100),
PickupLocation NVARCHAR(100),
DropLocation NVARCHAR(100),
VehicleType NVARCHAR(50),
Distance FLOAT,
Price FLOAT
);
