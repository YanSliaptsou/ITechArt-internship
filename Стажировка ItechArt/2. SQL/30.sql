USE DeliveryCompany

SELECT Orders.OrderID, OrderDate, ProductName FROM Orders
INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
INNER JOIN Products ON Products.ProductID = OrderDetails.ProductID
WHERE YEAR(OrderDate) >= 1997