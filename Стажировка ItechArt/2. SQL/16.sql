SELECT OrderId, SUM(Quantity) FROM OrderDetails WHERE Quantity = 
(SELECT MAX(Quantity) FROM OrderDetails) GROUP BY OrderId