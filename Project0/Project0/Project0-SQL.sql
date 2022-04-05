--20220307 Project0 SQL
CREATE SCHEMA Project0;
--To create the table of the customer
CREATE TABLE Customers(
customerId INT PRIMARY KEY IDENTITY,
customerFirstName NVARCHAR(25) NOT NULL,
customerLastName NVARCHAR(25) NOT NULL,
customerUsername NVARCHAR(25) NOT NULL,
customerPassword NVARCHAR(25) NOT NULL,
storeLocationId INT FOREIGN KEY REFERENCES Locations(storeLocationId)
);

INSERT INTO Customers(customerFirstName,customerLastName,customerUsername,customerPassword,storeLocationId) VALUES('Kevin','Lee','libra','opal',4)

SELECT * FROM Customers; 

DROP TABLE Customers;

--To create the table of the location of the store
CREATE TABLE Locations(
storeLocationId INT PRIMARY KEY IDENTITY,
storeLocation NVARCHAR(25) NOT NULL
);

--Insert table of store location
INSERT INTO Locations(storeLocation) VALUES ('Washington D.C.');
INSERT INTO Locations(storeLocation) VALUES ('Philadelphia');
INSERT INTO Locations(storeLocation) VALUES ('New York City');
INSERT INTO Locations(storeLocation) VALUES ('Boston');



--To create the table of the item(product)
CREATE TABLE Items(
itemId INT PRIMARY KEY IDENTITY,
itemName NVARCHAR(25) NOT NULL,
itemPrice DECIMAL(6,2) NOT NULL,
itemDescription NVARCHAR(50) NOT NULL,
itemQuantity INT,
storeLocationId INT FOREIGN KEY REFERENCES Locations(storeLocationId),
customerId INT FOREIGN KEY REFERENCES Customers(customerId)
);

DROP TABLE Items

--Insert table of products
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('White Rice', 17.99, '15 lbs of Rheechun Rice bag',38,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Ramen', 4.99, '4 packs of spicy Shin Ramen',40,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Soy Sauce', 10.99, '930 ml of Organic Sempio Soy Sauce',36,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Kimchi', 16.99, '3 lbs of Jongga Korean Cabbage Kimchi',28,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('SoyBean Paste', 3.99, '15.9 oz of Sunchang SoyBean Paste',33,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Pancake Powder', 4.99, '2.2 lbs of Korean pancake mix powder',35,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Tofu', 2.99, '14 oz of Pulmuone Organic Tofu',46,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Dumpling', 10.99, '24 oz of CJ Beef Vegetable Dumpling',27,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId)VALUES('Corn Syrup', 2.99, '24.7 oz of Chunjungone Corn syrup',35,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('RedPepper Paste', 5.99, '1.1 lbs of Sunchang Red Pepper Paste',36,4);
INSERT INTO Items(itemName, itemPrice, itemDescription, itemQuantity, storeLocationId) VALUES('Sesame Oil', 5.99, '370 oz of Ottogi Sesame Oil',28,4);

--To create the table of the inventory
CREATE TABLE Inventory(
storeLocationId INT FOREIGN KEY REFERENCES Locations(storeLocationId),
itemId INT FOREIGN KEY REFERENCES Items(itemId),
itemQuantity INT
);

DROP TABLE Inventory

SELECT * FROM Inventory INNER JOIN Locations ON Locations.storeLocationId = Inventory.storeLocationId INNER JOIN Items ON Items.itemId = Inventory.itemId WHERE storeLocation = 'Boston' ;

--
CREATE TABLE PastOrders(
lineId INT PRIMARY KEY IDENTITY,
orderId uniqueidentifier NOT NULL,
storeLocationId INT NULL FOREIGN KEY REFERENCES Locations(storeLocationId),
customerId INT NULL FOREIGN KEY REFERENCES Customers(customerId),
itemName NVARCHAR(25) NOT NULL FOREIGN KEY REFERENCES Items(itemName),
orderTotal DECIMAL NOT NULL
);

