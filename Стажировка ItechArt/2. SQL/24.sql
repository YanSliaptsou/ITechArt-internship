USE DeliveryCompany

SELECT OrderID, ShipperName FROM Orders
LEFT JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID