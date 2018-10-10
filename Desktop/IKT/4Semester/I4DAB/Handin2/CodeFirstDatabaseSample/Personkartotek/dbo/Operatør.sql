CREATE TABLE Operatør (
  [OperatørID]   BIGINT IDENTITY(1,1) NOT NULL, 
  [Selskab] varchar(255) NOT NULL, 
  [Telefon] BIGINT NULL, 
    PRIMARY KEY ([OperatørID])); 
  
    GO
  ALTER TABLE Operatør ADD CONSTRAINT [FK_Operatør_To_Telefon] FOREIGN KEY ([Telefon]) REFERENCES Telefon ([TelefonID]);
