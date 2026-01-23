create database day13Sample1DB;
use  day13Sample1DB;

/*ddl, dml,aggregate, tcl,dunction with paramters and without paramters
scalar,grouping  */



--ddl
CREATE TABLE Students (
    StudentId INT PRIMARY KEY,
    Email VARCHAR(100) UNIQUE,
    Age INT CHECK (Age >= 18),
    CourseId INT
);

--dml
INSERT INTO Students VALUES (1, 'mounika@gmail.com', 20, 101);
INSERT INTO Students VALUES (2, 'mounika2@gmail.com', 22, 102);
INSERT INTO Students VALUES (3, 'mounika3@gmail.com', 19, 101);

select *from Students;
INSERT INTO Students VALUES (4, 'mounika@gmail.com', 25, 103);--will give error


--Aggregate functions 
--sum, avg,length etc
--total  no.of students
select COUNT(*) as TotalStudents from Students;


--avg marks or age
select AVG(Age) as AverageAge from Students;

---Scalar functions
select StudentId , LEN(Email) as EmailLength,
GETDATE() as currentDate
from Students;

--Grouping
select CourseId, COUNT(*) As StudentCount
from Students
Group By CourseId;

select Count(*) As TotalStudents from Students;


--Transactions
Begin Transaction;
update Students
   set Age=Age+1
   where CourseId=101;

  -- Rollback;  --age will be same beacuse of rollback

   select Age from Students;

   Commit;

   --save point
   begin transaction;
   update Students set age=25 where StudentId=2;
   save transaction s1;  --all changes will be saved till this save point
   
   update Students set Age=30 where StudentId=1;
   rollback transaction s1; --no savepoint in this only transaction
   commit;
   select *from Students;

   --Access control grant and revoke
   grant select, insert on Students to User1; --user1 is allow to perform these operations
   revoke insert on Students from User1;-- revoking user one

   --ddl alter
   alter table Students
   add Phone VARCHAR(50);

   select *from Students; --if dont want to write select command again and agin
   --creating a function that displays/ run select *from table
    
    create function dbo.fn_DisplayStudent_Table()
    returns table
    as 
    return 
    (
    select StudentId, Email, Age, CourseID from Students
    );
    --calling
    select *from dbo.fn_DisplayStudent_Table();

    --paramtered function
    create function dbo.get_StudentByCourseID(@CourseID int)
    returns table
    as
    return
    (select StudentID, Email, Age from Students
    where CourseId=@CourseID);

    --calling 

    select *from dbo.get_StudentByCourseID(105);