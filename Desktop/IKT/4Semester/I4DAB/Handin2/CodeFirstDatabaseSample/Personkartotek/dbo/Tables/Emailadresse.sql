CREATE TABLE [dbo].[Emailadresse] (
    [EMAILID]  BIGINT IDENTITY (1, 1) NOT NULL,
    [PersonID] BIGINT NOT NULL,
    CONSTRAINT [pk_Emailadresse] PRIMARY KEY CLUSTERED ([EMAILID] ASC),
    CONSTRAINT [fk_Emailadresse] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID]) ON UPDATE CASCADE
);

