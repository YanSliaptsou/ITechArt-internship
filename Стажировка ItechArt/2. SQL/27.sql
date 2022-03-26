USE DeliveryCompany

SELECT Quantity FROM OrderDetails INNER JOIN Products
ON OrderDetails.ProductID = Products.ProductID WHERE ProductName = 'Queso Cabrales'

SELECT Quantity FROM OrderDetails WHERE ProductID = (SELECT ProductID FROM Products WHERE ProductName = 'Queso Cabrales')