USE DeliveryCompany

SELECT CustomerName FROM Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
INNER JOIN Products ON Products.ProductID = OrderDetails.ProductID
WHERE ProductName IN ('Queso Cabrales', 'Gustafs Knäckebröd', 'Louisiana Fiery Hot Pepper Sauce', 'Schoggi Schokolade', 'Gnocchi di nonna Alice')