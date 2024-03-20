-- Create sample data for Products table
INSERT INTO Products (Name, Description, Price, Category, Stock)
VALUES ('Smartphone', 'Latest smartphone with great features', 799.99, 'Electronics', 100),
       ('Laptop', 'High-performance laptop for professionals', 1299.99, 'Electronics', 50),
       ('Headphones', 'Wireless headphones with noise cancellation', 199.99, 'Electronics', 75);

-- Create sample data for Shippers table
INSERT INTO Shippers (Name, ContactInformation)
VALUES ('UPS', '1-800-742-5877'),
       ('FedEx', '1-800-463-3339'),
       ('DHL', '1-800-225-5345');

-- Create sample data for Reviews table
INSERT INTO Reviews (ProductId, CustomerId, Rating, Comment)
VALUES (1, 1, 5, 'Excellent product! Highly recommended.'),
       (1, 2, 4, 'Good phone, but battery life could be better.'),
       (2, 3, 5, 'Amazing laptop! Fast and reliable.');

-- Create sample data for Authentication table
INSERT INTO Authentications (Username, Password)
VALUES ('user1', 'password1'),
       ('user2', 'password2'),
       ('user3', 'password3');

-- Create sample data for Customers table
INSERT INTO Customers (Name, Email, Address, PhoneNumber)
VALUES ('John Doe', 'john@example.com', '123 Main St, Anytown', '123-456-7890'),
       ('Jane Smith', 'jane@example.com', '456 Oak St, Othertown', '987-654-3210'),
       ('Bob Johnson', 'bob@example.com', '789 Elm St, Anycity', '555-123-4567');

-- Create sample data for ShoppingCart table
INSERT INTO ShoppingCarts (CustomerId, ProductIds)
VALUES (1, '1,2'),
       (2, '1'),
       (3, '2,3');

-- Create sample data for Orders table
INSERT INTO Orders (CustomerId, ProductIds, ShipperId, OrderDate, TotalPrice)
VALUES (1, '1', 1, '2024-03-18', 799.99),
       (2, '2,3', 2, '2024-03-18', 1499.98),
       (3, '1', 3, '2024-03-18', 1299.99);

-- Create sample data for Promotions table
INSERT INTO Promotions (Description, DiscountPercentage, StartDate, EndDate)
VALUES ('Holiday Sale - 10% off', 10, '2024-12-01', '2024-12-31'),
       ('Summer Clearance - 20% off', 20, '2024-06-01', '2024-06-30');
