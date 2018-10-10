CREATE TABLE Adresse (
  [AdresseID]         BIGINT IDENTITY(1,1) NOT NULL, 
  Vej        varchar(255) NOT NULL, 
  Husnummer  varchar(255) NOT NULL, 
  [Person] BIGINT NULL, 
    PRIMARY KEY ([AdresseID]));

	    GO
  ALTER TABLE Adresse ADD CONSTRAINT [FK_Adresse_To_Person] FOREIGN KEY ([Person]) REFERENCES Person ([PersonID]);
