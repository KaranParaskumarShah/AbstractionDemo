create database  test
use test
create table student(sid int,sname varchar(25))
insert into student(sid,sname) values(1,'karan')
--delete from student
CREATE TABLE STUDENT1(SID INT NOT NULL,SNAME VARCHAR(25) NOT NULL,SADDRESS VARCHAR(50) NULL)
INSERT INTO STUDENT1(SID,SNAME,SADDRESS) VALUES(2,'DARJI',NULL)
INSERT INTO STUDENT1(SID,SNAME,SADDRESS) VALUES(1,'DARJI','GANDHINAGAR')
INSERT INTO STUDENT1 VALUES(3,'AMAN','KALOL')
--DELETE FROM STUDENT1 WHERE SNAME='AMAN'
select * from STUDENT1



CREATE TABLE EMPLOYEE(EMPID INT NULL,EMPNAME VARCHAR(30) NULL)
INSERT INTO EMPLOYEE VALUES(1,'RAJ')
INSERT INTO EMPLOYEE VALUES(NULL,NULL)
UPDATE EMPLOYEE SET EMPNAME='DARSHAN' WHERE EMPNAME='RAJ' 
INSERT INTO EMPLOYEE VALUES(2,'RAJESH')
SELECT * FROM EMPLOYEE

CREATE TABLE HANDLOOM(BILLID INT IDENTITY(1,1) NOT NULL,CURTAINS VARCHAR(255) NOT NULL ,STOREADDRESS VARCHAR(255))
INSERT INTO HANDLOOM(CURTAINS,STOREADDRESS) VALUES('NORMAL DOOR','SARANGPUR')

INSERT INTO HANDLOOM(CURTAINS) VALUES('RING DOOR')

INSERT INTO HANDLOOM VALUES('RING ZULLAR DOOR')

SELECT * FROM HANDLOOM

CREATE TABLE RIDDHISTORE1(LOCATIONID TINYINT,STOREID SMALLINT ,GSTNO BIGINT ,STORENAME BIT ,TOTALCOLLECTION REAL ,STOREWISECOLLECTION FLOAT ,STORENICKNAME CHAR ,STORELOCATIONNAME VARCHAR(255),STOREADDRESS TEXT ,STOREOPENIING DATE,STORETIME TIME, STORECLOSING TIMESTAMP ,STOREIMAGE IMAGE  )
INSERT INTO RIDDHISTORE1(LOCATIONID)VALUES(222)
INSERT INTO RIDDHISTORE1(LOCATIONID)VALUES(322)
INSERT INTO RIDDHISTORE1(STOREID)VALUES(31333)
INSERT INTO RIDDHISTORE1(GSTNO)VALUES(2124748364822)
INSERT INTO RIDDHISTORE1 (STORENAME)VALUES (NULL)
INSERT INTO RIDDHISTORE1 (TOTALCOLLECTION)VALUES (123.11111111111111111111)
INSERT INTO RIDDHISTORE1 (STOREWISECOLLECTION)VALUES (123.11111111111111111111)
INSERT INTO RIDDHISTORE1 (STORENICKNAME)VALUES ('S')

INSERT INTO RIDDHISTORE1 (STORENICKNAME)VALUES (67)
INSERT INTO RIDDHISTORE1 (STORELOCATIONNAME)VALUES ('rgffvregf')


SELECT * FROM RIDDHISTORE1

CREATE TABLE PARASSTORE(STOREOPENING DATETIME,STOREOPEN DATE)


INSERT INTO PARASSTORE(STOREOPEN) VALUES('1991-05-18')

INSERT INTO  PARASSTORE(STOREOPENING,STOREOPEN,GFBGFKJD) VALUES('1998-01-01 23:59:59.997','1991-05-18','23:59:59.997')


ALTER TABLE PARASSTORE ADD DATEOFBIRTH TIME

UPDATE  PARASSTORE SET DATEOFBIRTH ='23:59:59.997' WHERE 



SELECT * FROM PARASSTORE


