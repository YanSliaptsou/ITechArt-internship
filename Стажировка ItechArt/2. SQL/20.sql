USE DeliveryCompany
SELECT * FROM Customers WHERE Country = 'Mexico'

UPDATE Customers
SET Country = 'Spain' WHERE Country = 'Mexico'

SELECT * FROM Customers WHERE Country = 'Spain'