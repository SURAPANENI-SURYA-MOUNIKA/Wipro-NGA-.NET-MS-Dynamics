CREATE DATABASE ECommerceDB;
USE ECommerceDB;

--create table
--customer
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Phone NVARCHAR(20) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

--Product
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    SKU NVARCHAR(30) UNIQUE NOT NULL,
    ProductName NVARCHAR(150) NOT NULL,
    Description NVARCHAR(1000) NULL,
    Price DECIMAL(12,2) NOT NULL CHECK (Price >= 0),
    StockQuantity INT NOT NULL DEFAULT 0 CHECK (StockQuantity >= 0),
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);


--order
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(12,2) NOT NULL CHECK (TotalAmount >= 0),
    OrderStatus NVARCHAR(30) NOT NULL DEFAULT 'Pending' 
        CHECK (OrderStatus IN ('Pending','Processing','Shipped','Delivered','Cancelled')),
    PaymentStatus NVARCHAR(30) DEFAULT 'Pending'
        CHECK (PaymentStatus IN ('Pending','Paid','Failed','Refunded')),
    ShippingAddress NVARCHAR(500) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    
    CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerID) 
        REFERENCES Customers(CustomerID)
);

--order deatils
CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(12,2) NOT NULL CHECK (UnitPrice >= 0),
    Subtotal AS (Quantity * UnitPrice) PERSISTED,   -- calculated column
    
    CONSTRAINT FK_OrderDetails_Orders FOREIGN KEY (OrderID) 
        REFERENCES Orders(OrderID) ON DELETE CASCADE,
    CONSTRAINT FK_OrderDetails_Products FOREIGN KEY (ProductID) 
        REFERENCES Products(ProductID)
);

-- Add new customer
INSERT INTO Customers (FirstName, LastName, Email, Phone)
VALUES ('Rahul', 'Sharma', 'rahul.sharma@gmail.com', '9876543210');

-- Add new product
INSERT INTO Products (SKU, ProductName, Price, StockQuantity, Description)
VALUES ('TSH-BLK-M', 'Black Cotton T-Shirt', 599.00, 85, 'Premium cotton round neck t-shirt');

-- Add new order (with details)
BEGIN TRANSACTION;

    DECLARE @NewOrderID INT;

    INSERT INTO Orders (CustomerID, TotalAmount, ShippingAddress, OrderStatus)
    VALUES (1, 1797.00, 'Flat 402, Lotus Towers, Vijayawada, AP 520010', 'Pending');

    SET @NewOrderID = SCOPE_IDENTITY();

    INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
    VALUES 
        (@NewOrderID, 1, 3, 599.00);     -- buying 3 t-shirts

COMMIT TRANSACTION;

-- All active customers
SELECT CustomerID, FirstName, LastName, Email, Phone, CreatedDate
FROM Customers
WHERE IsActive = 1;

-- Products with low stock
SELECT ProductName, SKU, Price, StockQuantity
FROM Products
WHERE StockQuantity <= 10 AND IsActive = 1
ORDER BY StockQuantity;

-- Recent orders with customer info
SELECT 
    o.OrderID,
    o.OrderDate,
    c.FirstName + ' ' + c.LastName AS CustomerName,
    o.TotalAmount,
    o.OrderStatus
FROM Orders o
JOIN Customers c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate >= DATEADD(DAY, -30, GETDATE())
ORDER BY o.OrderDate DESC;


--order details
SELECT 
    od.OrderDetailID,
    p.ProductName,
    od.Quantity,
    od.UnitPrice,
    od.Subtotal
FROM OrderDetails od
JOIN Products p ON p.ProductID = od.ProductID
WHERE od.OrderID = 1;



--update
-- Update product price
UPDATE Products
SET Price = 649.00,
    StockQuantity = StockQuantity - 3
WHERE ProductID = 1;

-- Update order status
UPDATE Orders
SET OrderStatus = 'Processing',
    PaymentStatus = 'Paid'
WHERE OrderID = 1;
select *from Products;
select *from Orders;


--delete
select *from Customers;
UPDATE Customers
SET IsActive = 0
WHERE CustomerID = 5;