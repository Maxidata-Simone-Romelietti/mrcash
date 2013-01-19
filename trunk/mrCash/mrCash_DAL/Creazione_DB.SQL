create database mrCASH
GO

USE [mrCASH]
GO

CREATE TABLE [dbo].[Fornitori](
	[IDFornitore] [int] IDENTITY(1,1) NOT NULL,
	[Cognome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Nome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[RifDoc] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Indirizzo] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[Citta] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Provincia] [nvarchar](2) COLLATE Latin1_General_CI_AS NOT NULL,
	[Telefono] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Cap] [nvarchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[TipoDoc] [nvarchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[DataRilascio] [datetime] NOT NULL,
	[DataNascita] [datetime] NOT NULL,
	[Note] [nvarchar](1000) COLLATE Latin1_General_CI_AS NOT NULL,	
 CONSTRAINT [PK_Fornitori] PRIMARY KEY ( [IDFornitore] ASC )
)

CREATE TABLE [dbo].[Vendite](
	[IDVendita] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NOT NULL,
 CONSTRAINT [PK_Vendite] PRIMARY KEY (	[IDVendita] ASC)
) 

CREATE TABLE [dbo].[Acquisti](
	[IDAcquisto] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NOT NULL,
	[IDFornitore] [int] NOT NULL,
 CONSTRAINT [PK_Acquisti] PRIMARY KEY (	[IDAcquisto] ASC )
)
GO

ALTER TABLE [dbo].[Acquisti]  WITH CHECK ADD  CONSTRAINT [FK_Acquisti_Fornitori] FOREIGN KEY([IDFornitore])
REFERENCES [dbo].[Fornitori] ([IDFornitore])
GO
ALTER TABLE [dbo].[Acquisti] CHECK CONSTRAINT [FK_Acquisti_Fornitori]
GO



CREATE TABLE [dbo].[Oggetti](
	[IDOggetto] [int] IDENTITY(1,1) NOT NULL,
	[Codice] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Descrizione] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[PrezzoAcquisto] [money] NOT NULL,
	[PrezzoStimato] [money] NOT NULL,
	[PrezzoVendita] [money] NOT NULL,
	[IDAcquisto] [int] NOT NULL,
	[IDVendita] [int] NULL,
	[Modello] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[Serie] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
	[DataRientro] [datetime] NULL,
	[DataRiconsegna] [datetime] NULL,
	[DataRottamazione] [datetime] NULL,
	[Note] [nvarchar](1000) COLLATE Latin1_General_CI_AS NULL,		
 CONSTRAINT [PK_Oggetti] PRIMARY KEY (	[IDOggetto] ASC)
)
GO

ALTER TABLE [dbo].[Oggetti]  WITH CHECK ADD  CONSTRAINT [FK_Oggetti_Acquisti] FOREIGN KEY([IDAcquisto])
REFERENCES [dbo].[Acquisti] ([IDAcquisto])
GO
ALTER TABLE [dbo].[Oggetti] CHECK CONSTRAINT [FK_Oggetti_Acquisti]
GO

ALTER TABLE [dbo].[Oggetti]  WITH CHECK ADD  CONSTRAINT [FK_Oggetti_Vendite] FOREIGN KEY([IDVendita])
REFERENCES [dbo].[Vendite] ([IDVendita])
GO
ALTER TABLE [dbo].[Oggetti] CHECK CONSTRAINT [FK_Oggetti_Vendite]
GO
