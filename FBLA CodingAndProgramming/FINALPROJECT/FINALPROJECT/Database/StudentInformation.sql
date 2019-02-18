CREATE TABLE [dbo].[StudentInformation] (
    [Username]     VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [Grade]        INT NULL,
    [BookISNB]     INT          NULL,
    [BookTitle]    VARCHAR (50) NULL,
    [CheckOutDate] VARCHAR (50) NULL,
    [DueDate]      VARCHAR (50) NULL,
    [Student] BIT NOT NULL, 
    [Librarian] BIT NOT NULL, 
    [Admin] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

