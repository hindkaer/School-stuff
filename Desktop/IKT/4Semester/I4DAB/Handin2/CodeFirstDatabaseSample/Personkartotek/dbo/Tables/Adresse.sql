CREATE TABLE [dbo].[Adresse] (
    [Husnummer]  NVARCHAR (300) NOT NULL,
    [Vejnavn]    NVARCHAR (300) NOT NULL,
    [Postnummer] NVARCHAR (300) NOT NULL,
    [Bynavn]     NVARCHAR (300) NOT NULL,
    [AdresseID]  BIGINT         IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [pk_Adresse] PRIMARY KEY CLUSTERED ([AdresseID] ASC)
);

