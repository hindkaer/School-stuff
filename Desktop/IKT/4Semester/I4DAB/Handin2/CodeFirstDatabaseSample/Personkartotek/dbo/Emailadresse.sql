CREATE TABLE Emailadresse (
  [EmailID]       BIGINT IDENTITY(1,1) NOT NULL, 
  [Person] BIGINT NULL, 
  Email    varchar(255) NULL, 
  PRIMARY KEY ([EmailID]));
GO
ALTER TABLE Emailadresse ADD CONSTRAINT FK_Emailadresse_To_Person FOREIGN KEY ([Person]) REFERENCES Person ([PersonID]);