CREATE TABLE AlternativAdresse (
  PersonID  BIGINT NOT NULL, 
  AdresseID BIGINT NOT NULL, 
  Type      varchar(255) NOT NULL, 
    CONSTRAINT [PK_Person_Adresse] PRIMARY KEY ([AdresseID]));
GO
ALTER TABLE AlternativAdresse ADD CONSTRAINT FKPerson_Adr321172 FOREIGN KEY (PersonID) REFERENCES Person ([PersonID]);
GO
ALTER TABLE AlternativAdresse ADD CONSTRAINT FKPerson_Adr332690 FOREIGN KEY (AdresseID) REFERENCES Adresse ([AdresseID]);