CREATE TABLE [dbo].[Documents]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(250) NULL, 
    [Description] VARCHAR(10) NULL, 
    [Author] VARCHAR(10) NULL, 
    [Area] VARCHAR(10) NULL, 
    [IdFile] INT NULL, 
    [Publication] DATETIME NULL, 
    [Version] VARCHAR(10) NULL, 
    [Tags] VARCHAR(10) NULL, 
    [LastUpdated] DATETIME NULL, 
    [KeyWords] VARCHAR(10) NULL, 
    [PathFile] VARCHAR(10) NULL, 
)
