CREATE TABLE [dbo].[Registrations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DocumentId] INT NOT NULL,
    [ComputerIP] NVARCHAR(50) NOT NULL, 
    [EntryDate] DATETIME NOT NULL
)
