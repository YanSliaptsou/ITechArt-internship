SELECT ProductName, SUM(OrderDetails.Quantity) as Total_Quantity FROM Products
INNER JOIN OrderDetails
ON Products.ProductId = OrderDetails.ProductId
WHERE ProductName LIKE '%od%'
GROUP BY Products.ProductName
