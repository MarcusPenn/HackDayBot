CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [NotebookUrl] NVARCHAR(MAX) NOT NULL, 
    [ChangeControlUrl] NVARCHAR(MAX) NOT NULL
)
