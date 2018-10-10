CREATE TABLE Emailadresse (
  ID       int IDENTITY NOT NULL, 
  PersonID int NOT NULL, 
  Email    varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Telefon (
  ID            int IDENTITY NOT NULL, 
  OperatørID    int NOT NULL, 
  PersonID      int NOT NULL, 
  Telefonnummer varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Operatør (
  ID   int IDENTITY NOT NULL, 
  Navn varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Person (
  ID   int IDENTITY NOT NULL, 
  Navn varchar(255) NULL, 
  Type varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Noter (
  ID   int IDENTITY NOT NULL, 
  Note varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Adresse (
  ID         int IDENTITY NOT NULL, 
  PersonID   int NOT NULL, 
  Vej        varchar(255) NULL, 
  [By]       varchar(255) NULL, 
  Husnummer  varchar(255) NULL, 
  Postnummer varchar(255) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Person_Adresse (
  PersonID  int NOT NULL, 
  AdresseID int NOT NULL, 
  Type      varchar(255) NOT NULL);
ALTER TABLE Telefon ADD CONSTRAINT FKTelefon747761 FOREIGN KEY (PersonID) REFERENCES Person (ID);
ALTER TABLE Telefon ADD CONSTRAINT FKTelefon302512 FOREIGN KEY (OperatørID) REFERENCES Operatør (ID);
ALTER TABLE Emailadresse ADD CONSTRAINT FKEmailadres218851 FOREIGN KEY (PersonID) REFERENCES Person (ID);
ALTER TABLE Adresse ADD CONSTRAINT FRA FOREIGN KEY (PersonID) REFERENCES Person (ID);
ALTER TABLE Person_Adresse ADD CONSTRAINT FKPerson_Adr321172 FOREIGN KEY (PersonID) REFERENCES Person (ID);
ALTER TABLE Person_Adresse ADD CONSTRAINT FKPerson_Adr332690 FOREIGN KEY (AdresseID) REFERENCES Adresse (ID);
