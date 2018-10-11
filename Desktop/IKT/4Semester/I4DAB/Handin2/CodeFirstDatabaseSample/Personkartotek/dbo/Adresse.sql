CREATE TABLE Adresse (
  [AdresseID]         BIGINT IDENTITY(1,1) NOT NULL, 
  Vej        varchar(255) NOT NULL, 
  Husnummer  varchar(255) NOT NULL, 
  [City] BIGINT NULL, 
    PRIMARY KEY ([AdresseID]));

	    GO
  ALTER TABLE Adresse ADD CONSTRAINT [FK_Adresse_To_City] FOREIGN KEY ([City]) REFERENCES City ([CityID]);
