USE [StorePro]
GO

/****** Object:  Trigger [dbo].[ReduceQuantity]    Script Date: 21-08-2023 10:47:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Alter Trigger [dbo].[ReduceQuantity]
on [dbo].[CategoryType]
After Insert
As 
BEGIN

/*
select * from CategoryType C 
join ItemType it on
c.CategoryId=it.CategoryId
join Bill B on
B.ItemId=it.ItemId
where BillId=1
Update C  set  C.CategoryQuantity = C.CategoryQuantity-B.ItemQuantity
*/

-- Update the CategoryQuantity for the CategoryType table

UPDATE CategoryType
SET CategoryQuantity = CategoryQuantity - B.ItemQuantity
FROM CategoryType C
JOIN ItemType it ON C.CategoryId = it.CategoryId
JOIN Bill B ON B.ItemId = it.ItemId
WHERE B.BillId = 11;

-- Select the updated results
--SELECT * FROM CategoryType;







END
GO

ALTER TABLE [dbo].[CategoryType] ENABLE TRIGGER [ReduceQuantity]
GO


Exec InsertBill 5,6,1,1,'2023-08-14',1

------------------------------------------
---trigger creation-----------------

create trigger tr_insert_onbill
on Bill
after Insert
AS 
begin
	declare
	@id int
	update 



end


---Reduce
insert into bill VALUES (1, 3, 2, 3, '2023-08-14 12:00:00', 1);
insert into bill VALUES (8, 15, 2, 3, '2023-08-14 12:00:00', 1);
-- Create the trigger
Alter TRIGGER DecreaseCategoryQuantity
ON Bill
AFTER INSERT
AS
BEGIN
    -- Update the CategoryQuantity for the CategoryType table
    UPDATE ct
    SET CategoryQuantity = CategoryQuantity - B.ItemQuantity
    FROM CategoryType ct
    JOIN ItemType i ON ct.CategoryId = i.CategoryId
    JOIN Bill B ON i.ItemId = B.ItemId
	WHERE B.BillId = 14;

    -- Optionally, you can check for negative quantities and handle accordingly
    -- UPDATE ct
    -- SET CategoryQuantity = 0
    -- WHERE ct.CategoryQuantity < 0;
END;
