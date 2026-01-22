create database JoinsDemoDB;
use JoinsDemoDB;

--course(master table)
--Students(transaction table)
--Trainers(self join use cases)



CREATE TABLE MyCourses (
    CourseId INT PRIMARY KEY,
    CourseName VARCHAR(100)
);

CREATE TABLE My_Students (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    CourseId INT
);

CREATE TABLE Trainers (
    TrainerId INT PRIMARY KEY,
    TrainerName VARCHAR(50),
    ManagerId INT
);

insert into My_Students values
(1,'Rahul',101),
(1,'Rahul',101),
(1,'Rahul',101),
(1,'Rahul',101),

INSERT INTO Trainers VALUES
(1, 'Arjun', NULL),
(2, 'Ravi', NULL),
(3, 'Sena', 1),
(4, 'Kiran', 2);


INSERT INTO MyCourses VALUES
(101, 'Full Stack'),
(102, 'Data Engineering'),
(103, 'Cloud');

INSERT INTO My_Students VALUES
(1, 'Rahul', 101),
(2, 'Neha', 102),
(3, 'Amit', 101),
(4, 'Sonal', NULL);




select *from MyCourses,My_Students, Trainers;
select *from MyCourses;
select *from My_Students;
select *from Trainers;


/*types of joins
inner-return common in both table
*/


SELECT 
    s.StudentName,
    c.CourseName
FROM My_Students s
INNER JOIN MyCourses c
ON s.CourseId = c.CourseId;


/*Left join- wil return all left table record+matched right record
-list of all student +those not enrolled also*/

SELECT s.StudentName, s.StudentId, c.CourseName, c.CourseId
FROM My_Students s
LEFT JOIN MyCourses c
ON s.CourseId = c.CourseId;


/*right join :all rigt record +match record in left table
--it will display all courses if there is no enrolled student*/
-- It will display all courses even if there is no enrolled student
SELECT s.StudentName, s.StudentId, c.CourseName, c.CourseId
FROM My_Students s
right join MyCourses c
ON s.CourseId = c.CourseId;


/*
-full outer join
-return all record from both tables
*/

SELECT s.StudentName, s.StudentId, c.CourseName, c.CourseId
FROM My_Students s
full outer join MyCourses c
ON s.CourseId = c.CourseId;


/*
self join: ex-trainer manager hierarchy
           ex- university hod and faculty hierarchy
-table joins to itself
*/

select t1.TrainerName as Trainers,
 t2.TrainerName as Manager
 from Trainers t1
 left join Trainers t2
 on t1.ManagerId=t2.TrainerId;



 /*Cross join:returns cartesian product
 -all possible student and course combination
 -majorly used in testing and simulation
 */

 select s.StudentName, c.CourseName
 from My_Students s
 cross join MyCourses c;

 
 /*
 --union:combine result and remove duplicate
 --list of all people in the system
 */
 select StudentName from My_Students
 union
 select TrainerName from Trainers;


 /*
 intersect:return common record
 */
 select StudentName from My_Students
intersect
 select TrainerName from Trainers;



 /*
 there is no student who is also a trainer
 */



 /*
 minus:people who are students but not trainers
 */
 select StudentName from My_Students
expect
 select TrainerName from Trainers;