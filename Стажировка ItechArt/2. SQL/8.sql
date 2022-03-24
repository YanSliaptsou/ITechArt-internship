SELECT * FROM Suppliers WHERE City = 'Tokyo' OR City = 'Frankfurt' OR City = 'Osaka'
SELECT * FROM Suppliers WHERE City IN ('Tokyo', 'Frankfurt', 'Osaka') 