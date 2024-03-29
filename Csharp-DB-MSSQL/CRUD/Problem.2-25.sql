--2

Select *
FROM Departments
--3
Select [Name]
FROM Departments
--4

SELECT FirstName,LastName,Salary
From Employees

--5
SELECT FirstName,MiddleName, LastName
From Employees

--6

SELECT (Concat(FirstName,'.',LastName,'@softuni.bg'))  as [Full Email Address] 
FROM EMPLOYEES

--7

SELECT DISTINCT Salary 
FROM Employees

--8
SELECT *
FROM EMPLOYEES
WHERE JobTitle = 'Sales Representative'

--9
SELECT FirstName,LastName,JobTitle
FROM Employees
WHERE Salary  BETWEEN 20000 and 30000

--10

--Create an SQL query that finds the�full name�of all employees whose�salary�is exactly�25000, 14000, 12500, or 23600. The result should be displayed in a column, named "Full Name", which is a combination of the�first,�middle, and�last�names separated by a�single space.

SELECT (CONCAT(FirstName,' ',MiddleName,' ',LastName)) AS [Full Name]
FROM Employees
WHERE SALARY IN(25000, 14000, 12500, 23600)

--11

SELECT FirstName,LastName
FROM Employees
WHERE ManagerID is NUll
--12
SELECT FirstName,LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--13
SELECT TOP(5) FirstName,LastName
FROM Employees
ORDER BY Salary DESC

--14
SELECT FirstName,LastName
FROM Employees
WHERE DepartmentID != 4

--15

--Create an SQL query that sorts all the records in the Employees table by the following criteria:
--By�salary�in�decreasing�order
--Then by the�first name�alphabetically
--Then by the�last name descending
--Then by�middle name alphabetically

SELECT * 
FROM Employees
Order By Salary DESC,FirstName, LastName Desc, MiddleName

--16
CREATE VIEW V_EmployeesSalaries AS
Select FirstName,LastName,Salary
FROM Employees

--17
--Create an SQL query that creates a view "V_EmployeeNameJobTitle"�with a�full employee name�and a�job title. When the middle name is�NULL�replace it with�an empty string ('').

CREATE VIEW V_EmployeeNameJobTitle AS
SELECT 
	(Concat(FirstName,' ',MiddleName,' ',LastName))
	AS [Full Name]
	,JobTitle
FROM Employees

--18

SELECT DISTINCT JobTitle 
FROM Employees

--19

--Create an SQL query that finds�the first 10 projects which were started, select�all the information about them, and�order�the result by�starting date,�then by name.

SELECT TOP(10) *
FROM Projects
ORDER BY StartDate,Name

--20
--Create an SQL query that finds�the last 7 hired employees, select�their first, last name, and hire date. Order the result by hire date descending.

SELECT TOP(7) FirstName,LastName,HireDate
FROM Employees
ORDER BY HireDate DESC

--21 
--Create an SQL query that increases salaries by�12%�for all employees that work in one of the following departments -�Engineering,�Tool Design,�Marketing, or�Information Services. As a result, select and display�only the "Salaries" column�from the�Employees�table. After this, you should restore the database to the original data.
begin tran
UPDATE Employees
SET Salary = Salary * 1.12
WHERE DepartmentID IN (1,2,4,11)
SELECT Salary
From Employees
rollback

--22
USE Geography

SELECT PeakName
FROM Peaks
Order BY PeakName

--23

--Find the 30 biggest countries by population, located in�Europe. Display the "CountryName"�and "Population". Order the results by population (from biggest to smallest), then by country alphabetically.

SELECT TOP(30) CountryName,[Population]
FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY [Population] DESC, CountryName

--24

--Find all the countries with information about their currency. Display the "CountryName", "CountryCode", and information about its "Currency": either "Euro" or "Not Euro". Sort the results by country name alphabetically.
--*Hint: Use�CASE���WHEN.


SELECT CountryName
	,CountryCode
	, CASE WHEN CurrencyCode = 'EUR' THEN 'Euro' 
			ELSE 'Not Euro'
			END AS Currency
FROM Countries
ORDER BY CountryName

--25 

USE Diablo
SELECT [Name]
FROM Characters
Order BY [Name]

