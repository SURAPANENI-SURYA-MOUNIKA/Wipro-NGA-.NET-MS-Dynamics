/* Case Study*/


CREATE DATABASE ECommerceCaseStudyDB;
use ECommerceCaseStudyDB;

CREATE TABLE Customer
(
    CustomerId INT PRIMARY KEY IDENTITY,
    CustomerName VARCHAR(100),
    Email VARCHAR(100)
);


CREATE TABLE Product
(
    ProductId INT PRIMARY KEY IDENTITY, --identity automaticslly generate number
    ProductName VARCHAR(100),
    Price DECIMAL(10,2)
);


CREATE TABLE Orders
(
    OrderId INT PRIMARY KEY IDENTITY,
    CustomerId INT,
    ProductId INT,
    Quantity INT,
    OrderDate DATE,

    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);


--CRUD(Create)
--insert to product
INSERT INTO Product (ProductName, Price)
VALUES ('Laptop', 50000);
--insert to customer
INSERT INTO Customer (CustomerName, Email)
VALUES ('Mounika', 'mounika@gmail.com');
--insert to orders
INSERT INTO Orders (CustomerId, ProductId, Quantity, OrderDate)
VALUES (1, 1, 1, GETDATE());


--CRUD(READ)
SELECT * FROM Product;
SELECT * FROM Customer;
SELECT * FROM Orders;


--use join also
/*SELECT c.CustomerName, p.ProductName, o.Quantity, o.OrderDate
FROM Orders o
JOIN Customer c ON o.CustomerId = c.CustomerId
JOIN Product p ON o.ProductId = p.ProductId;*/


--CRUD(UPDATE)

UPDATE Product
SET Price = 55000
WHERE ProductId = 1;

UPDATE Customer
SET Email = 'surya2003@gmail.com'
WHERE CustomerId = 1;

select *from Product;
select *from Customer;


--CRUD(DELETE)
DELETE FROM Orders
WHERE OrderId = 1;

select *from Orders;

DELETE FROM Product
WHERE ProductId = 1;

select *from Product;


--droping the tables 
drop table Product;
drop table Customer;
drop table Orders;

