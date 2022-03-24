USE DeliveryCompany;

SELECT ProductName, AVG(OrderDetails.Quantity) as Total_Quantity FROM Products
INNER JOIN OrderDetails
ON Products.ProductId = OrderDetails.ProductId
WHERE Unit LIKE '%bottles%'
GROUP BY Products.ProductName
