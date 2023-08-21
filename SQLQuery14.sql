USE [StorePro]
GO

/****** Object:  StoredProcedure [dbo].[InsertBill]    Script Date: 21-08-2023 12:28:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertBill]
	-- Add the parameters for the stored procedure here
	@ItemId int,
	@ItemQuantity int,
	@ClientId int,
	@PaymentTypeId int,
	@CreatedOn datetime, 
	@OperationType int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if(@OperationType=1)
    -- Insert statements for procedure here
	BEGIN
	Insert into Bill values(@ItemId,@ItemQuantity,@ClientId,@PaymentTypeId,@CreatedOn,@OperationType)
	END

	ELSE if(@OperationType=2)
	BEGIN 
	UPDATE Bill SET PaymentTypeId=@PaymentTypeId WHERE ItemId=@ItemId
	END

	else
	BEGIN
	DELETE FROM Bill WHERE ItemId=@ItemId
	END
END
GO


