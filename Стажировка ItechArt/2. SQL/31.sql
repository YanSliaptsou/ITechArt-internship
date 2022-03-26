USE DeliveryCompany

SELECT ProductName, CategoryName FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
INNER JOIN OrderDetails ON Products.ProductID = OrderDetails.ProductID
INNER JOIN Orders ON Orders.OrderID = OrderDetails.OrderID
INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
WHERE CustomerName = 'Blondel père et fils'