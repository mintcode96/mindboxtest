CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(0, 'Тапочки'),
	(1, 'Чай'),
	(2, 'Плед'),
	(3, 'Кофе'),
	(4, 'Ботинки'),
	(5, 'Аааааавтомобиииль');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Напиток'),
	(2, 'Обувь'),
	(3, 'Для дома');

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories
VALUES
	(0, 2),
	(4, 2),
	(1, 1),
	(3, 1),
	(2, 3);

SELECT P.Name as 'Product', C.Name as 'Category'
FROM Products P
LEFT JOIN ProductsCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;