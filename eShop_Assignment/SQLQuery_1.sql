-- Insert sample data into products table
INSERT INTO products (Name, Description, Price, StockQuantity)
VALUES 
    ('Product 1', 'Description for Product 1', 10.99, 100),
    ('Product 2', 'Description for Product 2', 19.99, 50),
    ('Product 3', 'Description for Product 3', 8.49, 75);

-- Insert sample data into shippers table
INSERT INTO shippers (Name, ContactNumber)
VALUES 
    ('Shipper A', '123-456-7890'),
    ('Shipper B', '987-654-3210');

-- Insert sample data into users table
INSERT INTO Users (Username, Password, Email, IsAdmin)
VALUES 
    ('user1', 'password1', 'user1@example.com', 'false'),
    ('admin1', 'adminpassword1', 'admin1@example.com', 'true');

-- Insert sample data into customers table
INSERT INTO customers (UserId, FullName, Address, PhoneNumber)
VALUES 
    (1, 'John Doe', '123 Main St, Anytown, USA', '555-123-4567'),
    (2, 'Admin User', '456 Admin Ave, Admin City, USA', '555-987-6543');

-- Insert sample data into shopping_carts table
INSERT INTO ShoppingCarts ( CustomerId, CreatedAt)
VALUES 
    (1, CURRENT_TIMESTAMP),
    (2, CURRENT_TIMESTAMP);

-- Insert sample data into cart_items table
INSERT INTO CartItems ( ShoppingCartId, ProductId, Quantity)
VALUES 
    (1, 1, 2),
    (1, 2, 1),
    (2, 3, 3);


-- Insert sample data into orders table
INSERT INTO orders (CustomerId, ShipperId, OrderDate, TotalAmount)
VALUES 
    (1, 1, CURRENT_TIMESTAMP, 50.47),
    (2, 2, CURRENT_TIMESTAMP, 32.97);

-- Insert sample data into order_items table
INSERT INTO OrderDetails ( OrderId, ProductId, Quantity, Price)
VALUES 
    (1, 1, 2, 10.99),
    (1, 2, 1, 19.99),
    (2, 3, 3, 8.49);

-- Insert sample data into promotions table
INSERT INTO promotions (Name, Description, StartDate, EndDate, Discount)
VALUES 
    ('Promotion 1', 'Description for Promotion 1', '2024-03-01', '2024-03-15', 10.00),
    ('Promotion 2', 'Description for Promotion 2', '2024-03-05', '2024-03-20', 5.00);