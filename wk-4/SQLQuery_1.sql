--this is SQL
--forcomments

--when nothing is highlighted, and we run/execute eveything in the query is run
--you can select only a specific command, and only run that one

SELECT * FROM Customer;
--when you make query to a DB, any result wlltake the form of a table

SELECT 'Hello World';
--single quotes mark a string literal

SELECT 2+2;

SELECT SYSUTDATETIME();

--USUALLY nothing in SQL is case senstive
select 2 + 2;

--semicolons are not a required end-line character, they are an end of operation/end of throught, and are not generally required.
SELECT 2+2;

SELECT Address From Customer;
-- SELECT (Columns) FROM (Table)
-- ^select-list

-- Column Alias
-- great for concatenating multiple columns together.
SELECT FirstName,+ ' ' + LastName, Address FROM Customer;
SELECT FirstName,+ ' ' + LastName AS FullName, Address FROM Customer;
SELECT FirstName,+ ' ' + LastName AS 'FullName', Address FROM Customer;
SELECT FirstName,+ ' ' + LastName AS [FullName], Address FROM Customer;

-- filtering with WHERE

SELECT * --get this column
FROM Customer -- fromthis table
WHERE LEN(FirstName) > 5; --for entries that meet this condition

SELECT * 
FROM Customer
WHERE Country = 'Brazil'; --

SELECT * 
FROM Customer
WHERE Country = 'Brazil' AND City = "Sao Paulo";

SELECT * 
FROM Customer
WHERE CustomerId = 10;

--Aggregate Functions

SELECT COUNT(*)
FROM Customer;

SELECT SUM(Total)
FROM Invoice;

-- other agg functions include min, max, avg

SELECT CustomerId, SUM(Total)
FROM Invoice
GROUP BY CustomerId; -- Group By gives us a way to group the results of an agg. function by entries.

SELECT CustomerId, SUM(Total) AS Sum_Total
FROM Invoice
GROUP BY CustomerId
HAVING SUM(Total) > 40
GROUP BY SUM(Total) DESC, CustomerId;