--1 
Create database TestDB
--2
Use TestDB
--3 creaets Products table
CREATE TABLE Products (
    ProductName  char(50) NOT NULL,
    CategoryId int NULL
);

--4 creaets Categorys table
CREATE TABLE Categorys (
    CategoryName  char(50) NOT NULL,
    CategoryId int NULL
);
--5 Inserting data into Products

INSERT into Products 
(ProductName ,CategoryId)
VALUES
('Перец',1),
('Огурец' , 1),
('Помидор' , 1),
('Мандарин' , 2),
('Яблоко' , 2),
('Рис' , 3),
('Мука' , 3),
('Тушенка' , NULL)


--6 Inserting data into Categorys

INSERT into Categorys 
(CategoryName ,CategoryId)
VALUES
('Овощ',1),
('Фрукт' , 2),
('Крупа' , 3)

--7 Select
SELECT Products.ProductName as Product, Categorys.CategoryName as category
FROM Categorys
right outer join Products on Products.CategoryId = Categorys.CategoryId