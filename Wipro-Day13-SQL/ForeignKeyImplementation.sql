create database ForeignKey1DB;
use  ForeignKey1DB;


--parent table 
create table Courses(
  CourseId int Primary Key,
  CourseName varchar(100) not null,
  DurationMonths int check (DurationMonths>0)
  ) 
  --there can not be a student without values of course
  --first we have to insert values for courses table then we will insert student in wipro university only
  --second i can have students in wipro university



  insert into Courses values(101,'full stack .net',6)
  insert into Courses values(102,'Data Engineering',8)
  insert into Courses values(103,'cloud',5)

  select *from Courses;


CREATE TABLE WiproUniversity (--child table
    StudentId INT PRIMARY KEY,
    Email VARCHAR(100) UNIQUE,
    Age INT CHECK (Age >= 18),
    CourseId INT,
    Constraint FK_Students_Courses
    Foreign key (CourseId)
    references Courses(CourseId)
);


insert into WiproUniversity values(1,'mounika@gmail.com',20,101)
insert into WiproUniversity values(2,'minni@gmail.com',22,102)
insert into WiproUniversity values(3,'sara@gmail.com',19,103)
insert into WiproUniversity values(3,'sara@gmail.com',19,105)--will give error beacuse courseid is not there 105

delete from Courses where CourseId=101;--this wont work bacuase offoreign key




select *from WiproUniversity;


--to deleet course id we use cascade delete
CREATE TABLE NewStudents (--child table
    StudentId INT PRIMARY KEY,
    Email VARCHAR(100) UNIQUE,
    Age INT CHECK (Age >= 18),
    CourseId INT,
    Constraint FK1_Students_Courses
    Foreign key (CourseId)
    references Courses(CourseId)
    on delete cascade
);
select *from NewStudents;

insert into NewStudents values(1,'mounika@gmail.com',20,101)
insert into NewStudents values(2,'minni@gmail.com',22,102)
insert into NewStudents values(3,'sara@gmail.com',19,103)
insert into NewStudents values(3,'sara@gmail.com',19,105)--this wont work

delete from NewStudents where CourseId=101;