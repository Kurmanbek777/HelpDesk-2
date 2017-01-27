USE [D:\USERS\USER\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\HELPDESK\HELPDESK\APP_DATA\MWD.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spHelpDeskGetStatuses]

SELECT	@return_value as 'Return Value'

GO
