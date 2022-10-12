-- Database creating
IF DB_ID('MindBoxTestDb') IS NULL
	CREATE DATABASE MindBoxTestDb;
GO

-- Current database
USE MindBoxTestDb;
GO

-- Creating tables
IF OBJECT_ID('Product') IS NULL 
	BEGIN
		CREATE TABLE Product(Id INT PRIMARY KEY, Name NVARCHAR(MAX) NOT NULL);
		INSERT INTO Product VALUES(1, '��������'), (2, '����'), (3, '�����'), (4, '���'), (5, '���������');
	END

IF OBJECT_ID('Category') IS NULL 
	BEGIN
		CREATE TABLE Category(Id INT PRIMARY KEY, Name NVARCHAR(MAX) NOT NULL);
		INSERT INTO Category VALUES(1, '������������� �������'), (2, '�������� �������'), (3, '������������ �������');
	END

IF OBJECT_ID('ProductCategory') IS NULL
	BEGIN
		CREATE TABLE ProductCategory(ProductId INT NOT NULL, CategoryId INT NOT NULL);
		INSERT INTO ProductCategory VALUES(1, 1), (2, 1), (3, 2), (4, 2);
	END
GO

-- Task
SELECT Product.Name as ProductName, Category.Name as CategoryName FROM Product
    LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductID
    LEFT JOIN Category ON Category.id = ProductCategory.CategoryId
ORDER BY Product.Name;