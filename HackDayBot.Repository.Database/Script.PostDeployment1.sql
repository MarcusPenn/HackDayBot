/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Clients(Id,Name,NotebookUrl,ChangeControlUrl)
VALUES (1000, 'dubs', 'https://intranet.waterstons.com/clients/DUBS/_layouts/15/WopiFrame2.aspx?sourcedoc={29aa5407-46ef-4c27-843d-1f6431c36d2a}&action=editnew', 'test');

INSERT INTO Clients(Id,Name,NotebookUrl,ChangeControlUrl)
VALUES (1001, 'navigator', 'https://intranet.waterstons.com/clients/VopakUK/_layouts/15/WopiFrame.aspx?sourcedoc={98C8FA93-8219-47E9-AAD4-4F84BE3930DD}&file=Navigator%20Terminals%20Dev&action=default&Web=1&RootFolder=%2fclients%2fVopakUK%2fSiteAssets%2fNavigator%20Terminals%20Dev', 'test');

INSERT INTO Clients(Id,Name,NotebookUrl,ChangeControlUrl)
VALUES (1002, 'peacocks', 'https://intranet.waterstons.com/clients/Peacock/_layouts/15/WopiFrame.aspx?sourcedoc={daf3c169-231a-479d-afc9-ad43b1f27039}&action=editnew', 'test');

INSERT INTO Clients(Id,Name,NotebookUrl,ChangeControlUrl)
VALUES (1003, 'nsg', 'https://intranet.waterstons.com/clients/NSG/_layouts/15/WopiFrame.aspx?sourcedoc={f0c20ef7-4a0b-408b-af45-0879dfac0626}&action=editnew', 'test');

INSERT INTO Clients(Id,Name,NotebookUrl,ChangeControlUrl)
VALUES (1004, 'ulster', 'https://intranet.waterstons.com/clients/UnofUlster/_layouts/15/WopiFrame.aspx?sourcedoc={b6e70dbd-8006-456e-962f-14341fc5dbb0}&action=editnew', 'test');

