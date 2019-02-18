CREATE TABLE [dbo].LoginInformation
(
	[Username] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] VARCHAR(50) NOT NULL, 
    [Student] BIT NOT NULL, 
    [Librarian] BIT NOT NULL, 
    [Administration] BIT NOT NULL
)
