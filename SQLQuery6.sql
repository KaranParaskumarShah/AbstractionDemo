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
-- Author:		KARAN
-- Create date:  2023-08-14 14:07
-- Description:	DEMO FOR STORE PROCEDURE 1 TABLE OF ITEM TYPE
-- =============================================
CREATE PROCEDURE InsertItemType
	-- Add the parameters for the stored procedure here
	@ItemName varchar(40),
	@ItemPrice float,
	@CategoryId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO ItemType VALUES (@ItemName,@ItemPrice,@CategoryId)
END
GO
