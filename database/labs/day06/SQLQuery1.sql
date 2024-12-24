-- Use ITI DB
use ITI;

--⦁ Create a scalar function that takes date and returns Month name of that date.
CREATE FUNCTION getMonth(@date Date) 
RETURNS VARCHAR(20)
AS
	BEGIN
		RETURN FORMAT(@date, 'MMMM');
	END

SELECT dbo.getMonth(GETDATE()) AS MonthName;

--⦁ Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
DROP FUNCTION IF EXISTS dbo.getValuesBtwTwoIntegers
CREATE FUNCTION getValuesBtwTwoIntegers(@num1 INT, @num2 INT)
RETURNS @t TABLE (
	val INT
)
AS 
	BEGIN
		DECLARE @start INT = @num1+1;
		WHILE @start < @num2
			BEGIN
				INSERT INTO @T (val)
				VALUES (@start);
				SET @start += 1
			END
		RETURN;
	END

select * from getValuesBtwTwoIntegers(1, 5);

--⦁ Create inline function that takes Student No and returns Department Name with Student full name.
CREATE FUNCTION getStudentDept(@id INT)
RETURNS TABLE 
AS 
	RETURN (
		SELECT D.Dept_Name
		FROM Student AS S
		JOIN Department AS D ON S.Dept_Id = D.Dept_Id
		WHERE S.St_Id = @id
	)

select * from getStudentDept(10);

--⦁Create a scalar function that takes Student ID and returns a message to user 
	--⦁If first name and Last name are null then display 'First name & last name are null'
	--⦁If First name is null then display 'first name is null'
	--⦁If Last name is null then display 'last name is null'
	--⦁Else display 'First name & last name are not null'
CREATE FUNCTION checkStudentName(@id INT)
RETURNS VARCHAR(100)
AS 
	BEGIN
		DECLARE @firstName varchar(50) = (select St_Fname from Student where St_Id = @id)
		DECLARE @lastName varchar(50) = (select St_Lname from Student where St_Id = @id)
		DECLARE @nameStatus VARCHAR(100)

		SET @nameStatus = 
			CASE 
				WHEN @firstName IS NULL THEN 'first name is null'
				WHEN @lastName IS NULL	THEN 'last name is null'
				WHEN @firstName IS NOT NULL AND @lastName IS NOT NULL THEN 'first name and last name are null'
				else 'first name and last name are not null'
			END 
		RETURN @nameStatus
	END

select dbo.checkStudentName(6)

--⦁	Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 
DROP FUNCTION IF EXISTS dbo.getManagerInfo
CREATE FUNCTION getManagerInfo(@id INT)
RETURNS TABLE
AS 
	RETURN (
		SELECT D.Dept_Name, I.Ins_Name, D.Manager_hiredate
		FROM Instructor AS I
		JOIN Department AS D ON D.Dept_Manager = I.Ins_Id
		WHERE I.Ins_Id = @id
	)

select * from getManagerInfo(2)

--⦁	Create multi-statements table-valued function that takes a string
	--If string='first name' returns student first name
	--If string='last name' returns student last name 
	--If string='full name' returns Full Name from student table 
	--Note: Use “ISNULL” function
DROP FUNCTION IF EXISTS getStudentName
CREATE FUNCTION getStudentName(@id int, @type VARCHAR(50))
RETURNS @t TABLE (
	name varchar(100)
)
AS 
	BEGIN
		IF @type = 'first name'
			begin
				insert into @t
				select ISNULL(St_Fname, 'unknown')
				from Student
				where St_Id = @id
			end
		ELSE IF @type = 'last name'
			begin
				insert into @t
				select ISNULL(St_Lname, 'unknown')
				from Student
				where St_Id = @id
			end
		ELSE IF @type = 'full name'
			begin
				insert into @t
				select St_Fname + ' ' + St_Lname
				from Student
				where St_Id = @id
			end
		ELSE 
			insert into @t
			values ('unknown')
	RETURN
	END

select * from getStudentName(1, 'first name')
select * from getStudentName(1, 'last name')
select * from getStudentName(1, 'full name')

--⦁	Write a query that returns the Student No and Student first name without the last char
select St_Id, SUBSTRING(St_Fname, 1, LEN(St_Fname)-1) 
from Student

--⦁	Wirte query to delete all grades for the students Located in SD Department 4

update Stud_Course
set 
	Grade = null
where St_Id in (
	select s.St_Id
	from Student as s
	join Department as d on s.Dept_Id = d.Dept_Id
	where d.Dept_Name = 'SD'
)

--⦁Using Merge statement between the following two tables [User ID, Transaction Amount]
drop database if exists day6Task;
create database day6Task;

use day6Task;

drop table if exists dailyTx;
create table dailyTx(
	userId int primary key,
	amount int not null
)

drop table if exists LastTx;
create table LastTx(
	userId int primary key,
	amount int not null
)

insert into dailyTx
values 
	(1,1000),
	(2, 2000),
	(3, 1000)

insert into lastTx
values 
	(1,4000),
	(4, 2000),
	(2, 10000)

merge lastTx as t
using dailyTx as s
on t.userId = s.userId
when matched  then
	update set t.amount += s.amount
when not matched  then
	insert
	values (s.userId, s.amount);

select * from LastTx