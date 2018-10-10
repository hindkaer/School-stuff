CREATE TABLE Noter (
  [NoteID]   BIGINT IDENTITY(1,1) NOT NULL, 
  Note varchar(255) NULL, 
    [Person] BIGINT NULL, 
    PRIMARY KEY ([NoteID]));

	    GO
  ALTER TABLE Noter ADD CONSTRAINT [FK_Noter_To_Person] FOREIGN KEY ([Person]) REFERENCES Person ([PersonID]);