use mwd
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spInsertHelpDeskTicket 
	-- Add the parameters for the stored procedure here
	@FName varchar(50),
	@LName varchar(50),
	@Email varchar(50),
	@SeverityID int,
	@StatusID int,
	@DepartmentID int,
	@Comments varchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO HelpDesk(FName,LName,Email,SeverityID,StatusID,DepartmentID,Comments)VALUES(@FName,@LName,@Email,@SeverityID,@StatusID,@DepartmentID,@Comments)
END
GO
