USE DeliveryCompany

SELECT OrderID, CustomerName, CONCAT(FirstName,' ', LastName) as Employee FROM Orders
LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID
LEFT JOIN Employees ON Employees.EmployeeID = Orders.EmployeeID