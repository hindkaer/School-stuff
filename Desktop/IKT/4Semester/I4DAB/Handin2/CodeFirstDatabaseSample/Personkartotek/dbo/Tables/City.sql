CREATE TABLE [dbo].[City]
(
	[CityID] BIGINT NOT NULL PRIMARY KEY, 
    [Citynavn] NVARCHAR(50) NOT NULL, 
    [Postnummer] NVARCHAR(50) NOT NULL, 
    [Land] NVARCHAR(50) NOT NULL, 
    [Adresse] BIGINT NULL
)

    GO
  ALTER TABLE City ADD CONSTRAINT [FK_City_To_Adresse] FOREIGN KEY ([Adresse]) REFERENCES Adresse ([AdresseID]);
