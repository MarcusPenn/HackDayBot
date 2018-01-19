CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [NotebookUrl] NVARCHAR(200) NOT NULL, 
    [ChangeControlUrl] NVARCHAR(200) NOT NULL
)
