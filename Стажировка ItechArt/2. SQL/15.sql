SELECT Country, COUNT(Country) FROM Suppliers GROUP BY Country HAVING COUNT(Country) > 2
