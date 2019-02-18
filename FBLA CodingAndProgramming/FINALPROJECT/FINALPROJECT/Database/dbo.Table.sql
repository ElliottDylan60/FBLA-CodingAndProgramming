CREATE TABLE [dbo].BookAddedInfo
(
	[ISBN] BIGINT NOT NULL PRIMARY KEY, 
    [BookTitle] VARCHAR(50) NOT NULL, 
    [BookAuthor] VARCHAR(50) NOT NULL, 
    [Availably] BIT NOT NULL, 
    [CheckedOutBy] VARCHAR(50) NULL, 
    [TimeCheckedOut] VARCHAR(50) NULL, 
    [RedemptionCode] VARCHAR(50) NULL
)
