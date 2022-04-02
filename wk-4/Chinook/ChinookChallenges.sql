-- On the Chinook DB, practice writing queries with the following exercises

-- List all customers (full name, customer id, and country) who are not in the USA
SELECT FirstName + ' ' + LastName AS FullName, CustomerId, Country FROM Customer WHERE NOT COUNTRY = 'USA';



-- List all customers from Brazil
SELECT * 
FROM Customer 
WHERE Country = 'Brazil';



-- List all sales agents
SELECT * FROM Employee WHERE Title = 'Sales Support Agent';


-- Retrieve a list of all countries in billing addresses on invoices
SELECT DISTINCT BillingCountry FROM Invoice;



-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)
SELECT COUNT(InvoiceId) AS TotalInvoices, Sum(Total) AS TotalSales FROM Invoice WHERE InvoiceDate LIKE '%2009%';

-- how many line items were there for invoice #37
SELECT*FROM InvoiceLine WHERE InvoiceId = 37;



-- how many invoices per country?
SELECT BillingCountry, SUM(Total)As Invoice_Count
FROM Invoice
GROUP BY BillingCountry
ORDER BY 2 DESC;



-- Retrieve the total sales per country, ordered by the highest total sales first.
SELECT BillingCountry, SUM(Total) AS Sum_Total
FROM Invoice
GROUP BY BillingCountry
ORDER BY 2 DESC;

-- JOINS CH                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   mmmmmmmmmmmm  mmmmmmmmmmmmmmmmmmmmm                                                                                                                                                                                                                                                                                                                                                                                                                                                      m                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              mm                                                                                                                                                                                                                                                                                                                                                                                                        ALLENGES
-- Show all invoices of customers from brazil (mailing address not billing)
SELECT * FROM Invoice WHERE BillingCountry = 'Brazil';


-- Show all invoices together with the name of the sales agent for each one
 SELECT Invoice.*,Employee.FirstName + ' ' + Employee.LastName AS FullName
 FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId
			JOIN Employee ON Customer.SupportRepId = Employee.EmployeeId



-- Show all playlists ordered by the total number of tracks they have
SELECT Playlist.Name, Count(PlaylistTrack.PlaylistId) AS 'Total Songs'
FROM Playlist INNER JOIN PlaylistTrack ON Playlist.PlaylistId = PlaylistTrack.PlaylistId
GROUP BY Playlist.Name
ORDER BY [Total Songs]



-- Which sales agent made the most sales in 2009?
SELECT Employee.FirstName, SUM(Invoice.Total) AS 'Total Sales'
FROM Employee 
	INNER JOIN Customer ON Employee.EmployeeId = Customer.SupportRepId
	JOIN Invoice ON Customer.CustomerId = Invoice.CustomerId
	WHERE Invoice.InvoiceDate LIKE '%2009%'
	GROUP BY Employee.FirstName;



-- How many customers are assigned to each sales agent?
SELECT Employee.FirstName, Employee.LastName,COUNT(Customer.SupportRepId) AS Customer_Count
FROM Employee
JOIN Customer ON Employee.EmployeeId = Customer.SupportRepId
JOIN Invoice ON Customer.CustomerId = Invoice.CustomerId
GROUP BY Employee.LastName, Employee.FirstName;

-- Which track was purchased the most ing 2010?
SELECT Track.Name, SUM(Invoice.Total) AS Sum_Total
FROM Track JOIN InvoiceLine ON Track.TrackId = InvoiceLine.TrackId
		   JOIN Invoice ON InvoiceId = Invoice.InvoiceId
WHERE YEAR(Invoice.InvoiceDate) = 2010
GROUP BY Track.Name
ORDER BY Sum_Total DESC; 

-- Show the top three best selling artists.
SELECT TOP(3) Artist.Name, SUM(Invoice.Total) AS Sum_Total
FROM Artist
JOIN Album ON Artist.ArtistId = Album.ArtistId
JOIN Track ON Album.AlbumId = Track.AlbumId
JOIN InvoiceLine ON Track.TrackId = InvoiceLine.TrackId
JOIN Invoice ON InvoiceLine.InvoiceId = Invoice.InvoiceId
GROUP BY Artist.Name
ORDER BY Sum_Total DESC;

-- Which customers have the same initials as at least one other customer?



-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

SELECT * FROM ArtistWHERE ArtistID IN (SELECT ArtistId FROM ArtistEXCEPTSELECT ArtistId FROM Album);


-- 2. which artists did not record any tracks of the Latin genre?

-- Artist has ArtistID and NAME
-- Track Has AlbumId, GenreId
-- Album has ArtistId and AlbumId
-- Genre has GenreId and Name (Latin = 6)

SELECT COUNT (DISTINCT Artist.Name + Genre.Name)
FROM Track 
INNER JOIN Album ON Track.AlbumId = Album.AlbumId
INNER JOIN Artist ON Album.ArtistId = Artist.ArtistId
INNER JOIN Genre ON Track.GenreId = Genre.GenreId
WHERE Genre.Name !='Latin';


SELECT DISTINCT Name FROM ArtistWHERE ArtistId NOT IN (SELECT ArtistId FROM Album WHERE AlbumId IN (SELECT AlbumId FROM TrackWHERE GenreId IN (SELECT GenreId FROM Genre WHERE Name = 'Latin')))


-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.
INSERT INTO Employee (Name) VALUES
(


);

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter
UPDATE Customer
SET FirstName = 'Robert' AND LastName = 'Walter'
WHERE CustomerId = 32;

-- 4. delete one of the employees you inserted.

DELETE FROM Employee WHERE;

-- 5. delete customer Robert Walter.
ALTER TABLE Invoice
	DROP CONSTRAINT FK_InvoiceCustomerId;
	
ALTER TABLE Invoice
	ADD CONSTRAINT FK_InvoiceCustomerId
	FOREIGN KEY (CustomerId)
	REFERENCES Customer (CustomerId)
	ON DELETE CASCADE;

ALTER TABLE InvoiceLine DROPCONSTRAINT FK_InvoiceLineInvoiceId;ALTER TABLE InvoiceLine ADDCONSTRAINT FK_InvoiceLineInvoiceIdFOREIGN KEY (InvoiceId)REFERENCES Invoice (InvoiceId)ON DELETE CASCADE;


DELETE FROM Customer WHERE FirstName = 'Robert' AND LastName = 'Walter';
