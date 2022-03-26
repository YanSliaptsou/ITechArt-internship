USE DeliveryCompany

SELECT ProductName, SupplierName, Price FROM Products
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
WHERE SupplierName = 'Grandma Kellys Homestead' AND Price > 27