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
Create PROCEDURE InsertClientInfo
	-- Add the parameters for the stored procedure here
	@ClientId int,
	@ClientName varchar(25),
	@ClientNumber varchar(20),
	@ClientEmail varchar(30),
	@ClientPassword varchar(40),
	@ClientGenderId int,
	@ClientDOB datetime,
	@OperationId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    SET IDENTITY_INSERT ClientId ON;


	if(@OperationId=1)
	BEGIN
    -- Insert statements for procedure here
	INSERT INTO ClientInfo VALUES(@ClientId,@ClientName,@ClientNumber,@ClientEmail,@ClientPassword,@ClientGenderId,@ClientDOB,@OperationId)
	END

	if(@OperationId=2)
		BEGIN
	UPDATE ClientInfo SET ClientName= @ClientName,ClientGenderId=@ClientGenderId where ClientId=@ClientId
	END

	if(@OperationId=3)
	BEGIN
	DELETE ClientInfo WHERE ClientId=@ClientId
	END

END
GO
