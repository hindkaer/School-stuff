CREATE TABLE Telefon (
  [TelefonID]            BIGINT IDENTITY(1,1) NOT NULL, 
  [Person]    BIGINT NULL, 
  Telefonnummer varchar(255) NOT NULL, 
  [Operatør] BIGINT NULL, 
    PRIMARY KEY ([TelefonID]));

GO
ALTER TABLE Telefon ADD CONSTRAINT [FK_Telefon_To_Person] FOREIGN KEY ([Person]) REFERENCES Person ([PersonID]);

GO
ALTER TABLE Telefon ADD CONSTRAINT [FK_Telefon_To_Operatør] FOREIGN KEY ([Operatør]) REFERENCES Operatør ([OperatørID]);