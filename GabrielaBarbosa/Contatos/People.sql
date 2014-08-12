CREATE TABLE [dbo].[People]
(
	[ContactID] INT NOT NULL IDENTITY, 
    [LastCall] DATETIME NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Client] BIT NULL, 
    [Company] NVARCHAR(50) NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ContactID]) 
)
