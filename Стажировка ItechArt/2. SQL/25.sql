USE DeliveryCompany

SELECT LastName, FirstName FROM Employees
INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
WHERE OrderDate = '1996-11-27'

SELECT LastName, FirstName FROM Employees WHERE EmployeeID = 
(SELECT EmployeeID FROM Orders WHERE OrderDate = '1996-11-27')