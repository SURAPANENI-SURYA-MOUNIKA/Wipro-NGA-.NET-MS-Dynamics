create database Mounika;
Use Mounika;
CREATE TABLE FPO(
FPOID INT IDENTITY(1,1) Primary KEY,
FPOName VARCHAR(100) NOT NULL, 
myState VARCHAR(50) NOT NULL, 
MemberCount INT CHECK(MemberCount>0), 
Registrations DATE NOT NULL);


INSERT into FPO(FPOName, myState, MemberCount, Registrations)
VALUES('greenharvest FPO', 'Andhra', 250,'2022-08-23'),
('Agro unity FPO','Nuzvid', 180,'2023-05-12');

--create another table

CREATE TABLE FPO1(
FPOID INT IDENTITY(1,1) Primary KEY,
FPOName VARCHAR(100) NOT NULL, 
myState VARCHAR(50) NOT NULL, 
MemberCount INT CHECK(MemberCount>0), 
Registrations DATE NOT NULL);

--inserting values
INSERT into FPO1(FPOName, myState, MemberCount, Registrations)
VALUES('greenharvest FPO', 'Andhra', 250,'2022-08-23'),
('agro unity FPO', 'Nuzvid', 180, '2023-08-23');


select *from FPO1;
select *from FPO1 where MemberCount>200;
select FPOName, myState FROM FPO1 where MemberCount<200;



--updating values
update FPO1 set MemberCount=300 where FPOName='greenharvest FPO';
select *from FPO1;

--diff between delet and drop i ssms
DELETE from FPO1
 where FPOName='Agro unity FPO';
 select *from FPO1;

 --drop
 Drop table FPO1;



