CREATE TABLE Person (
  [PersonID]   BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
  [Fornavn] varchar(255) NOT NULL, 
  [Mellemnavn] NCHAR(10) NULL, 
  [Efternavn] NCHAR(10) NOT NULL, 
	Type varchar(255) NULL 
   
);