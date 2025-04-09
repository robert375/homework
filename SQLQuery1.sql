use master
create database SEDCACADEMYDB
go

use SEDCACADEMYDB

create table Students(
id int not null,
FirstName nvarchar(10) not null,
LastName nvarchar(20) not null,
DateOfBirth int not null,
EnrolledDate int not null,
Gender nvarchar(10) not null,
NationalIDNumber int not null,
)

create table Teacher(
id int not null,
FirstName nvarchar(10) not null,
LastName nvarchar(10) not null,
DateOFBirth int not null,
AcademicRank nvarchar(10) not null,
HireDate int not null,
)

create table Grade(
id int not null,
StudentID int not null,
CourseID int not null,
TeacherID int not null,
Grade int not null,
Comment nvarchar (30) not null,
CreatedDate int not null,
)

create table Course (
id int not null,
Name nvarchar(10) not null,
Credit int not null,
AcademicYear int not null,
Semester int not null,
)

create table GradeDetails(
id int not null,
GradeID int not null,
AchievmentTypeID int not null,
AchievmentPoints int not null,
AchievmentMaxPoints int not null,
AchievmentDate int not null,
)

create table AchievmentType(
id int not null,
Name nvarchar(20) not null,
Description nvarchar(30) not null,
ParticipationRate nvarchar(10) not null,
)

insert into dbo.Students(id, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIDNumber)
values( 1, 'Robert', 'Rafailoski', 18.06, 20.10, 'Male', 1806)

insert into dbo.Teacher (id,FirstName, LastName,DateOFBirth, AcademicRank, HireDate)
values( 1, 'Ilija', 'Mitev', 21.10, 'Trainer', 1.1)

insert into Grade(id, StudentID, CourseID, TeacherID, Grade, Comment, CreatedDate)
values(1, 1, 1,1,0,'you are terrible', 10.20)
insert into Course(id, Name, Credit, AcademicYear,Semester)
values(1, 'Robert', 5, 2024, 'Summer')
insert into GradeDetails(id, GradeID, AchievmentTypeID, AchievmentPoints, AchievmentMaxPoints, AchievmentDate)
values( 1, 1,1,10,20, 10.10)
insert into AchievmentType( id, Name, Description, ParticipationRate)
values(1, 'Robert','you are the worst', 20%)
