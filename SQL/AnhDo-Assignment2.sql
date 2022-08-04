-- 1. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables.
-- Join them and produce a result set similar to the following.

--     Country                        Province
SELECT c.Name  AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode


-- 2. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables 
-- and list the countries filter them by Germany and Canada.
-- Join them and produce a result set similar to the following.

--     Country                        Province
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion as c JOIN Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')


--  Using Northwind Database: (Use aliases for all the Joins)

-- 3. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductID ,p.ProductName
FROM  Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= 1997-07-28


-- 4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 ISNULL(o.ShipPostalCode,'Unknown') AS [Location], SUM(od.Quantity) AS Quantity
FROM  Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= 1997-07-28
GROUP BY O.ShipPostalCode
ORDER BY Quantity DESC


-- 5. List all city names and number of customers in that city.     
SELECT City, COUNT(CustomerID) AS [NumberOfCustomer]
FROM Customers
GROUP BY City


-- 6. List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(CustomerID) AS [Number Of Customer]
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2


-- 7. Display the names of all customers  along with the count of products they bought
SELECT c.ContactName AS Name, SUM(ISNULL(od.Quantity,0)) AS [Count Of Products]
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName
ORDER BY c.ContactName


-- 8. Display the customer ids who bought more than 100 Products with count of products.
SELECT o.CustomerID , SUM(od.Quantity) AS [Count Of Products]
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.CustomerID
HAVING SUM(od.Quantity) >100



-- 9. List all of the possible ways that suppliers can ship their products. Display the results as below

--     Supplier Company Name                Shipping Company Name

--     ----------------------              ----------------------
SELECT su.CompanyName as [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM Suppliers su CROSS JOIN Shippers sh
ORDER BY su.CompanyName


-- 10. Display the products order each day. Show Order date and Product Name.
SELECT p.ProductName, o.OrderDate
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON p.ProductID = od.ProductID
ORDER BY o.OrderDate


-- 11. Displays pairs of employees who have the same job title.
SELECT e1.EmployeeID, e1.LastName + e1.FirstName AS Employee1, e2.EmployeeID, e2.LastName +e2.FirstName AS Employee2, e1.Title
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID < e2.EmployeeID 




-- 12. Display all the Managers who have more than 2 employees reporting to them.
SELECT m.FirstName + ' ' + m.LastName AS Manager, COUNT(e.EmployeeID) AS NumOfEmployee
FROM Employees AS m LEFT JOIN Employees AS e ON  m.EmployeeID = e.ReportsTo
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(e.EmployeeID) > 2

-- 13. Display the customers and suppliers by city. The results should have the following columns

-- City
-- Name
-- Contact Name,
-- Type (Customer or Supplier)




-- All scenarios are based on Database NORTHWIND.


-- 14. List all cities that have both Employees and Customers.
SELECT City, Country
FROM Employees
UNION
SELECT City, Country
FROM Customers

-- 15. List all cities that have Customers but no Employee.
-- a. Use sub-query
SELECT DISTINCT City, Country
FROM Customers
WHERE City NOT IN (
    SELECT DISTINCT City 
    FROM Employees
)


-- b. Do not use sub-query
SELECT DISTINCT c.City, c.Country
FROM Customers c LEFT JOIN Employees e ON c.City = e.City 
WHERE e.EmployeeID is null
ORDER BY c.City


-- 16. List all products and their total order quantities throughout all orders.
SELECT p.ProductName , SUM(ISNULL(od.Quantity,0)) AS [Order Quantities]
FROM Products p LEFT JOIN [Order Details] od ON  p.ProductID = od.ProductID 
GROUP BY p.ProductName
ORDER BY p.ProductName

-- 17. List all Customer Cities that have at least two customers.
-- a. Use union
SELECT City, Country
FROM Customers 
GROUP BY City, Country
HAVING COUNT(CustomerID) = 2
UNION 
SELECT City, Country
FROM Customers 
GROUP BY City, Country
HAVING COUNT(CustomerID) >2

-- b. Use no union
SELECT City, Country
FROM Customers 
GROUP BY City, Country
HAVING COUNT(CustomerID)>=2
ORDER BY City

-- 18. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, c.Country
FROM Products p JOIN [Order Details] od ON  p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID JOIN Customers c ON c.CustomerID = o.CustomerID
GROUP BY c.City, c.Country
HAVING COUNT(CategoryID)>=2
ORDER BY City
 

-- 19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.



-- 20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
-- and also the city of most total quantity of products ordered from. (tip: join  sub-query)




-- 21. How do you remove the duplicates record of a table?
-- Use UNION
