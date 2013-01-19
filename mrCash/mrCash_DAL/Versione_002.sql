ALTER TABLE Fornitori
ADD [Note] nvarchar(1000) COLLATE Latin1_General_CI_AS NOT NULL DEFAULT ''
GO

ALTER TABLE Oggetti
ALTER COLUMN [Modello] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL
GO

ALTER TABLE Oggetti
ALTER COLUMN [Serie] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL
GO

ALTER TABLE Oggetti
ADD [DataRientro] [datetime] NULL
GO

ALTER TABLE Oggetti
ADD [DataRiconsegna] [datetime] NULL
GO

ALTER TABLE Oggetti
ADD [DataRottamazione] [datetime] NULL
GO

ALTER TABLE Oggetti
[Note] [nvarchar](1000) COLLATE Latin1_General_CI_AS NULL
GO