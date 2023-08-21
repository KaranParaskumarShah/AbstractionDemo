EXEC ClientInfoff 1,'AMAN','9857556555555','AMAN@112GMAIL.COM','AMAN1234',1,'2002-08-10 12:22'
EXEC ClientInfoff 2,'DIPAK','98575565334','DIPAK@112GMAIL.COM','DIPAK1234',1,'2001-03-10 12:22'
EXEC ClientInfoff 3,'PAYAL','985755645623','PAYAL@112GMAIL.COM','PAYAL1234',2,'1998-02-10 12:22'
EXEC ClientInfoff 4,'AKSHAY','985755689888','AKSHAY@112GMAIL.COM','AKSHAY1234',1,'2000-08-10 12:22'
EXEC ClientInfoff 5,'KARAN','985755611212','KARAN@112GMAIL.COM','KARAN1234',1,'1999-12-23 12:22'
EXEC ClientInfoff 6,'RAJESH','985755643335','RAJESH@112GMAIL.COM','RAJESH1234',1,'2001-01-10 12:22'

SET IDENTITY_INSERT ClientInfo OFF;

SET IDENTITY_INSERT ClientInfo ON;

exec InsertClientInfo 101,'tITHI','985755643335','RAJESH@112GMAIL.COM','RAJESH1234',1,'2001-01-10 12:22',1

EXEC InsertClientInfo 7,'tITHI','985755643335','RAJESH@112GMAIL.COM','RAJESH1234',1,'2001-01-10 12:22',1

EXEC InsertClientInfo 9,'lolu','985755643335','RAJESH@112GMAIL.COM','RAJESH1234',1,'2001-01-10 12:22',1

EXEC InsertClientInfo 8,'lolu','985755643335','RAJESH@112GMAIL.COM','RAJESH1234',2,'2001-01-10 12:22',2



EXEC InsertClientGender 3,'OTHER'

Exec InsertItemType SingleBedsheetsWithCover,400.00,1
Exec InsertItemType DOUBLEBedsheetsWithCover,500.00,1
Exec InsertItemType SingleBedsheetsWithOutCover,300.00,1
Exec InsertItemType DoubleBedsheetsWithOutCover,420.00,1
Exec InsertItemType ACBlankets,350.00,2
Exec InsertItemType NormalBlankets,100.00,2
Exec InsertItemType NormalTowels,75.00,3
Exec InsertItemType luchavalajadaTowels,150.00,3
Exec InsertItemType NormalDoorCurtains,200.00,4
Exec InsertItemType RingDoorCurtains,340.00,4
Exec InsertItemType RingZullarDoorCurtains,450.00,4
Exec InsertItemType NormalWindowCurtains,100.00,4
Exec InsertItemType RingWindowCurtains,200.00,4
Exec InsertItemType RingZullarWindowCurtains,200.00,4
Exec InsertItemType NormalBlankets,100.00,2
Exec InsertItemType NormalBlankets,100.00,2


ALTER TABLE ClientInfo add OperationId int
Alter Table Bill add TotalBill int


CREATE TABLE Operation(OperationId int IDENTITY(1,1),OperationName varchar(50))

INSERTBILL 5,2,1,2,'2023-08-14',1

Exec InsertCategoryType 'GADLA'
EXEC InsertPaymentType 'WALLETS'
EXEC InsertOperation 'DELETE'

Exec InsertBill 1,2,1,2,'2023-08-14'
Exec InsertBill 2,2,2,2,'2023-08-14 15:30'

Exec InsertBill 4,1,4,1,'2023-08-14 16:30'
Exec InsertBill 3,3,3,1,'2023-08-14 18:30'


--itemid and itemquantity 
Update Bill set TotalBill = ItemId*ItemQuantity where BillId=1


--SELECT IT.ItemPrice*B.ItemQuantity AS TOTAL FROM Bill B INNER JOIN
--ItemType IT ON B.ItemId=IT.ItemId WHERE B.BillId=1 

UPDATE  BILL  set TOTALBILL =( SELECT IT.ItemPrice*B.ItemQuantity  FROM Bill B INNER JOIN
ItemType IT ON B.ItemId=IT.ItemId WHERE B.BillId=3) where BillId=6

UPDATE Bill
SET TOTALBILL = IT.ItemPrice * B.ItemQuantity
FROM Bill B
INNER JOIN ItemType IT ON B.ItemId = IT.ItemId
WHERE B.BillId = 7;

--I want male client purchasing 
select sum(b.totalbill) as total from ClientGender g 
join ClientInfo ci on g.ClientGenderId=ci.ClientGenderId
join bill b on b.ClientId=ci.ClientId
where g.ClientGenderId=1

select avg(b.totalbill) as average from ClientGender g 
join ClientInfo ci on g.ClientGenderId=ci.ClientGenderId
join bill b on b.ClientId=ci.ClientId
where g.ClientGenderId=1

select count(distinct(g.ClientGenderId)),g.ClientGenderName as total from ClientGender g 
join ClientInfo ci on g.ClientGenderId=ci.ClientGenderId
join bill b on b.ClientId=ci.ClientId
group by g.ClientGenderName



select STDEV(totalbill) from Bill
select var(totalbill) from bill

select * from ClientInfo order by 1 desc

SELECT * FROM PaymentType
SELECT * FROM CategoryType


SELECT * FROM ClientGender
SELECT * FROM Bill



SELECT * FROM Operation
SELECT * FROM ItemType
