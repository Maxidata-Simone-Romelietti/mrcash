ALTER TABLE Acquisti
ADD [Transazione] int NOT NULL DEFAULT 0
GO

UPDATE Acquisti SET Transazione = IDAcquisto
GO