-- Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday. When inserting, make up info if necessary. Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.

-- 1.      Create a view named “view_product_order_[your_last_name]”,
-- list all products and total ordered quantity for that product.

CREATE VIEW view_product_order_Do
AS
SELECT p.ProductID, p.ProductName , SUM(ISNULL(od.Quantity,0)) AS [Order Quantities]
FROM Products p LEFT JOIN [Order Details] od ON  p.ProductID = od.ProductID
GROUP BY p.ProductName, p.ProductID

GO

SELECT *
FROM view_product_order_Do

GO
-- 2.      Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id 
--         as an input and total quantities of order as output parameter.

CREATE PROC sp_product_order_quantity_do
@product_id INT,
@total_quantities INT OUT
AS
BEGIN
    SELECT @total_quantities = SUM(ISNULL(od.Quantity,0))
    FROM Products p LEFT JOIN [Order Details] od ON  p.ProductID = od.ProductID LEFT JOIN Orders o ON o.OrderID = od.OrderID
    WHERE p.ProductID = @product_id
END

GO

-- 3.      Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as
--  an input and top 5 cities that ordered most that product combined with 
-- the total quantity of that product ordered from that city as output.

CREATE PROC sp_product_order_CITY_do
@product_name varchar(50)
AS
BEGIN
    SELECT Top 5 c.City, SUM(od.Quantity) AS [Total Quantity]
    FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON p.ProductID = od.ProductID 
    WHERE p.ProductName = @product_name
    GROUP BY c.City
    ORDER BY [Total Quantity] DESC
END

GO
EXEC sp_product_order_CITY_do 'Alice Mutton'


-- 4.      Create 2 new tables “people_your_last_name” “city_your_last_name”. 
-- City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}.
-- People has three records: {id:1, Name: Aaron Rodgers, City: 2}, 
-- {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
-- Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
-- Create a view “Packers_your_name” lists all people from Green Bay. If any error occurred, 
-- no changes should be made to DB. (after test) Drop both tables and view.
CREATE TABLE people_do(Id int, Name varchar(30),City int)
CREATE TABLE city_do(CityId int, City varchar(30))

INSERT INTO people_do(Id, Name, City) VALUES(1,'Aaron Rodgers',2), (2,'Russell Wilson',1) ,(3, 'Jody Nelson', 2)
INSERT INTO city_do(CityId, City) VALUES (1, 'Seattle'),(2,'Green Bay')

UPDATE city_do 
SET City = 'Madison'
WHERE City = 'Seattle'

GO

CREATE VIEW Packers_do 
AS
SELECT p.Id, p.Name, c.City
FROM people_do p JOIN city_do c ON p.City = c.CityId
WHERE c.City = 'Green Bay'

GO

DROP TABLE city_do
DROP TABLE people_do
DROP VIEW Packers_do


GO


-- 5. Create a stored procedure “sp_birthday_employees_[you_last_name]” that 
-- creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb.
-- (Make a screen shot) drop the table. Employee table should not be affected.

CREATE PROC sp_birthday_employees_do
AS
BEGIN
    SELECT EmployeeID, FirstName + ' '+ LastName AS [Full Name], BirthDate INTO birthday_employees_anh
    FROM Employees
    WHERE MONTH(BirthDate) = 2
END

EXEC sp_birthday_employees_do
SELECT * FROM birthday_employees_anh

DROP TABLE birthday_employees_anh

-- 6.      How do you make sure two tables have the same data? 
-- Answer: I will use UNION and COUNT() to check, I'll assume that tables may have duplicate rows.

-- First: I will check if 
-- SELECT COUNT(*) FROM Table1 == SELECT COUNT(*) FROM Table2. If yes, continue. If no, they don't have same data

-- Then: I will check if 
-- SELECT COUNT(*) FROM (SELECT DISTINCT * from Table1) == SELECT COUNT(*) FROM (SELECT DISTINCT * from Table2)
-- If yes, continue. If no, they don't have same data

--Then I perform:

--  SELECT COUNT(*)
--  FROM 
--     (SELECT *
--     FROM Table1
--     UNION
--     SELECT *
--     FROM Table2)
--  If there is an error message, two table may have different number of columns or data type of each column are different,
--  then the two column don't have the same data

--  We can say that the data in the 2 tables is identical if distinct count 
--  from the 2 tables is equal to the number of records obtained by performing union of the 2 tables.