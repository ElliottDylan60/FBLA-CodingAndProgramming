CREATE TABLE [dbo].[StudentLogin] (
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Student] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

