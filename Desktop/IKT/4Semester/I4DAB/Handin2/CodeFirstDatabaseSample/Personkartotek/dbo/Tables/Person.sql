CREATE TABLE [dbo].[Person] (
    [Fornavn]    NVARCHAR (300) NOT NULL,
    [Mellemnavn] NVARCHAR (300) NOT NULL,
    [Efternavn]  NVARCHAR (300) NOT NULL,
    [Persontype] NVARCHAR (300) NOT NULL,
    [PersonID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [AdresseID]  BIGINT         NOT NULL,
    CONSTRAINT [pk_Person] PRIMARY KEY CLUSTERED ([PersonID] ASC),
    CONSTRAINT [fk_Person] FOREIGN KEY ([AdresseID]) REFERENCES [dbo].[Adresse] ([AdresseID]) ON DELETE CASCADE ON UPDATE CASCADE
);

