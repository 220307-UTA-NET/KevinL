--20220307 Project0 SQL

--To create the table of the customer
CREATE TABLE Customers(
customerID INT PRIMARY KEY IDENTITY,
customerFirstName NVARCHAR(25) NOT NULL,
customerLastName NVARCHAR(25) NOT NULL,
customerUsername NVARCHAR(25) NOT NULL,
customerPassword NVARCHAR(25) NOT NULL
);

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
itemDescription NVARCHAR(50) NOT NULL
);

--Insert table of products
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('White Rice', 17.99, '15 lbs of Rheechun Rice bag');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Ramen', 4.99, '4 packs of spicy Shin Ramen');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Soy Sauce', 10.99, '930 ml of Organic Sempio Soy Sauce');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Kimchi', 16.99, '3 lbs of Jongga Korean Cabbage Kimchi');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('SoyBean Paste', 3.99, '15.9 oz of Sunchang SoyBean Paste');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Pancake Powder', 4.99, '2.2 lbs of Korean pancake mix powder');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Tofu', 2.99, '14 oz of Pulmuone Organic Tofu');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Dumpling', 10.99, '24 oz of CJ Beef Vegetable Dumpling');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Corn Syrup', 2.99, '24.7 oz of Chunjungone Corn syrup');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('RedPepper Paste', 5.99, '1.1 lbs of Sunchang Red Pepper Paste');
INSERT INTO Items(itemName, itemPrice, itemDescription) VALUES('Sesame Oil', 5.99, '370 oz of Ottogi Sesame Oil');

--To create the table of the inventory
CREATE TABLE Inventory(
storeLocationId INT FOREIGN KEY REFERENCES Locations(storeLocationId),
itemId INT FOREIGN KEY REFERENCES Items(itemId),
itemQuantity INT
);

--Insert table of inventory
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,1,50);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,2,40);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,3,36);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,4,25);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,5,34);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,6,25);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,7,48);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,8,30);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,9,37);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,10,42);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(1,11,32);

INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,1,45);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,2,43);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,3,27);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,4,25);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,5,31);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,6,27);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,7,48);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,8,26);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,9,34);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,10,36);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(2,11,28);

INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,1,49);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,2,38);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,3,32);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,4,37);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,5,33);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,6,36);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,7,46);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,8,30);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,9,37);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,10,42);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(3,11,33);

INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,1,38);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,2,40);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,3,36);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,4,28);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,5,33);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,6,35);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,7,46);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,8,27);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,9,35);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,10,36);
INSERT INTO Inventory(storeLocationId, itemId, itemQuantity) VALUES(4,11,28);



--
CREATE TABLE CustomerOrders(

);

CREATE TABLE StoreOrders(

);