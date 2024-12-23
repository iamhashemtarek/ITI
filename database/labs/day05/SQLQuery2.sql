--Part-1: Use ITI DB
use ITI;

--⦁	Retrieve number of students who have a value in their age. 
select count(st_age)
from Student;

--⦁	Get all instructors Names without repetition
select distinct ins_name
from Instructor

--⦁	Display student with the following Format (use isNull function)
		--Student ID	Student Full Name	Department name
select St_Id, ISNULL(St_Fname, '') + ' ' + ISNULL(St_Lname, '') as fullname
from Student

--⦁	Display instructor Name and Department Name 
select i.Ins_Name, d.Dept_Name
from Instructor as i
join Department as d on i.Dept_Id = d.Dept_Id

--Note: display all the instructors if they are attached to a department or not
select i.Ins_Name, ISNULL(d.Dept_name, 'N/A')
from Instructor as i
left join Department as d on i.Dept_Id = d.Dept_Id

--⦁	Display student full name and the name of the course he is taking --For only courses which have a grade  
select s.St_Fname + ' ' + s.St_Lname  as fullname, c.Crs_Name
from Student as s
join Stud_Course as sc on s.St_Id = sc.St_Id
join Course as c on sc.Crs_Id = c.Crs_Id
where sc.Grade is not null


--⦁	Display number of courses for each topic name
select t.Top_Name, COUNT(c.Crs_Id) as number_of_courses
from Course as c
join Topic as t on c.Top_Id = t.Top_Id
group by t.Top_Name

--⦁	Display max and min salary for instructors
select 'max salary' as salary,  MAX(Salary)
from Instructor
union 
select 'min salary' as salary, MIN(salary)
from Instructor

select MAX(salary) as max_salary, min(salary) as min_salary
from Instructor

--⦁	Display instructors who have salaries less than the average salary of all instructors.
select Ins_Name, Salary
from Instructor
where Salary < (select AVG(salary) from Instructor)

--⦁	Display the Department name that contains the instructor who receives the minimum salary.
select i.Ins_Name, i.Salary, d.Dept_Name
from Instructor as i 
join Department as d on i.Dept_Id = d.Dept_Id
where i.Salary = (select min(salary) from Instructor)

--⦁	 Select max two salaries in instructor table. 
with rankedSalaries as (
	select Salary, DENSE_RANK() over (order by salary desc)  as DR
	from Instructor
)
select distinct salary 
from rankedSalaries
where DR <=2
order by salary desc

--⦁	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
select Ins_Name, coalesce(Salary,  'bonus') as salary
from Instructor

--⦁	Select Average Salary for instructors 
select AVG(salary) as average_salary
from Instructor

--⦁	Select Student first name and the data of his supervisor 
select s.St_Fname, sv.*
from Student as s
join Student as sv on s.St_super = sv.St_Id

--⦁	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
with rankedSalaries as (
	select Dept_id, Salary, DENSE_RANK() over (partition by Dept_id order by salary desc) as DR
	from Instructor 
	where salary is not null
)
select  Dept_id, salary 
from rankedSalaries
where DR <= 2

--⦁	 Write a query to select a random student from each department.  “using one of Ranking Functions”
with randomStudent as (
	select Dept_id, ISNULL(St_Fname, '') + ' '+ ISNULL(St_Lname,'')  as fullname, ROW_NUMBER() over (partition by Dept_Id order by NEWID()) as RN
	from Student
)
select Dept_Id, fullname
from randomStudent
where RN = 1;