USE [StorePro]
GO

/****** Object:  StoredProcedure [dbo].[InsertClientInfo]    Script Date: 16-08-2023 14:50:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:KARAN
-- Create date: 2023-08-14 14:07
-- Description:	DEMO FOR STORE PROCEDURE 1
-- =============================================
Alter PROCEDURE [dbo].[InsertClientInfo]
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

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>

	

	
	if(@OperationId=1)
	BEGIN
    -- Insert statements for procedure here
	Insert into ClientInfo values(@ClientName,@ClientNumber,@ClientEmail,@ClientPassword,@ClientGenderId,@ClientDOB,@OperationId)
	END

	if(@OperationId=2)
		BEGIN
	UPDATE ClientInfo SET ClientName= @ClientName,ClientGenderId=@ClientGenderId , OperationId=@OperationId where ClientId=@ClientId
	END

	if(@OperationId=3)
	BEGIN
	DELETE ClientInfo WHERE ClientId=@ClientId
	END






END
GO


