CREATE TABLE Product (
    Id INT PRIMARY KEY,
    name VARCHAR(255),
    price DECIMAL(10, 2),
    description TEXT,
    category_id INT
);

CREATE TABLE Orders (
    Id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    total_amount DECIMAL(10, 2),
    status VARCHAR(50)
);

CREATE TABLE OrderDetail (
    Id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (order_id) REFERENCES Orders(Id),
    FOREIGN KEY (product_id) REFERENCES Product(Id)
);

-- Sample data for Product table
INSERT INTO Product (Id, name, price, description, category_id)
VALUES
    (1, 'Laptop', 999.99, 'High-performance laptop', 1),
    (2, 'Smartphone', 699.99, 'Latest smartphone model', 1),
    (3, 'Headphones', 149.99, 'Wireless noise-canceling headphones', 2),
    (4, 'Keyboard', 49.99, 'Mechanical gaming keyboard', 3),
    (5, 'Mouse', 29.99, 'Wireless optical mouse', 3);

-- Sample data for Orders table
INSERT INTO Orders (Id, customer_id, order_date, total_amount, status)
VALUES
    (1, 101, '2024-03-10', 1349.97, 'Completed'),
    (2, 102, '2024-03-11', 79.98, 'Processing'),
    (3, 103, '2024-03-11', 999.99, 'Shipped');

-- Sample data for OrderDetail table
INSERT INTO OrderDetail (Id, order_id, product_id, quantity, price)
VALUES
    (1, 1, 1, 1, 999.99),
    (2, 1, 2, 1, 699.99),
    (3, 2, 5, 2, 59.98),
    (4, 3, 3, 1, 149.99),
    (5, 3, 4, 1, 49.99);


CREATE PROCEDURE sp_InsertOrderDetail
    @OrderId int,
    @ProductId int,
    @quantity int,
    @price decimal(18,2)
AS
BEGIN
    INSERT INTO OrderDetail (OrderId, ProductId, quantity, price)
    VALUES (@OrderId, @ProductId, @quantity, @price)

    SELECT *
    FROM OrderDetail
END

CREATE PROC sp_orderdetails
AS
BEGIN

SELECT o.Id, o.OrderId, o.ProductId, o.quantity, o.price, p.Id , p.name
FROM Product p inner join OrderDetail o
on p.Id = o.ProductId
End