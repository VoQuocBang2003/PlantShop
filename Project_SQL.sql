create database "Project_DotNet";

-- Tạo bảng Users: Lưu thông tin người dùng (khách hàng và admin)
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Address NVARCHAR(200),
    Role NVARCHAR(20) NOT NULL,
    CONSTRAINT UQ_Users_Username UNIQUE (Username),
    CONSTRAINT CHK_Users_Role CHECK (Role IN ('Employee','Admin'))
);
GO

-- Tạo bảng Products: Lưu thông tin sản phẩm (cây cảnh, hạt giống, chậu cây)
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(18,2) NOT NULL,
    StockQuantity INT NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Size NVARCHAR(20) NULL,
    CONSTRAINT CHK_Products_Price CHECK (Price >= 0),
    CONSTRAINT CHK_Products_Stock CHECK (StockQuantity >= 0),
    CONSTRAINT CHK_Products_Category CHECK (Category IN ('Plant','Seed','Pot'))
);
GO

-- Tạo bảng Orders: Lưu thông tin đơn hàng của khách hàng
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2) NOT NULL,
    PaymentStatus NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Orders_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT CHK_Orders_Total CHECK (TotalAmount >= 0),
    CONSTRAINT CHK_Orders_PaymentStatus CHECK (PaymentStatus IN ('Pending','Paid')),
);
GO

-- Tạo bảng OrderDetails: Lưu chi tiết sản phẩm của từng đơn hàng
CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_OrderDetails_Orders FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_OrderDetails_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    CONSTRAINT CHK_OrderDetails_Quantity CHECK (Quantity > 0),
    CONSTRAINT CHK_OrderDetails_UnitPrice CHECK (UnitPrice >= 0),
    CONSTRAINT UQ_OrderDetails_Order_Product UNIQUE (OrderID, ProductID)
);
GO
