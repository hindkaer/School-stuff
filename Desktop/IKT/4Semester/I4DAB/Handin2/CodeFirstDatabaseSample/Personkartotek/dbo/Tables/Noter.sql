CREATE TABLE [dbo].[Noter] (
    [NoterID]  BIGINT NOT NULL,
    [PersonID] BIGINT NOT NULL,
    CONSTRAINT [pk_Noter] PRIMARY KEY CLUSTERED ([NoterID] ASC),
    CONSTRAINT [fk_Noter] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID]) ON UPDATE CASCADE
);

