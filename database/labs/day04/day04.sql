use Company_SD;

--1. Display (Using Union Function)
	--a. The name and the gender of the dependence that's gender is Female and depending on Female Employee.
	--b. And the male dependence that depends on Male Employee.
select d.Sex, d.Dependent_name
from Dependent as d
join Employee as e
on d.ESSN = e.SSN
where d.Sex = 'F'
	and e.Sex = 'F'
union
select d.Sex, d.Dependent_name
from Dependent as d
join Employee as e
on d.ESSN = e.SSN
where d.Sex = 'M'
	and e.Sex = 'M'

--2. For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pname, sum(w.Hours) as 'total hours'
from Works_for as  w
join Project as p
on w.Pno = p.Pnumber
join Employee as e
on w.ESSn =  e.SSN
group by p.Pname


--3. Display the data of the department which has the smallest employee ID over all employees' ID.
select d.*
from Departments as d
join Employee as e
on e.Dno = d.Dnum
where e.SSN = (select min(SSN) from Employee)


--4. For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname, max(e.salary) as 'max salary', min(e.salary) as 'min salary', avg(e.salary) as 'average salary'
from Departments as d
join Employee as e
on e.Dno = d.Dnum
group by d.Dname


--5. List the full name of all managers who have no dependents.
select e.Fname+' '+e.Lname as 'full name'
from Employee as e
join Departments as d
on d.MGRSSN = e.SSN
where e.SSN not in (select ESSN from Dependent)

--5. using join
select e.Fname+' '+e.Lname as 'full name'
from Employee as e
join Departments as d
on d.MGRSSN = e.SSN
left join Dependent as c
on e.SSN = c.ESSN
where c.ESSN is null

--6. For each department
	-- if its average salary is less than the average salary of all employees
	-- display its number, name and number of its employees.
select d.Dnum, d.Dname, count(e.SSN)
from Departments as d
join Employee as e
on e.Dno = d.Dnum
group by d.Dnum, d.Dname
having avg(e.salary) < (select avg(salary) from Employee)

--7. Retrieve a list of employee’s names and the projects names they are working on 
	--ordered by department number and within each department, ordered alphabetically by name, first name.
select e.Fname+' '+e.Lname as 'name', p.Pname
from Works_for as w
join Employee as e
on w.ESSn= e.SSN
join Project as p
on w.Pno = p.Pnumber
order by e.Dno, e.Fname

--8. Try to get the max 2 salaries using sub query
select max(salary) as 'second max', (select max(Salary) from Employee) as 'max'
from Employee
where Salary < (select max(Salary) from Employee)


--9. Get the full name of employees that is similar to any dependent name
select e.Fname+' '+e.Lname
from Employee as e
join Dependent as d 
on e.Fname+' '+e.Lname = d.Dependent_name


--10. Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
select e.SSN, e.Fname+' '+e.Lname
from Employee as e
where exists (select 1 from Dependent as d where d.ESSN = e.SSN)


--11. In the department table insert new department called "DEPT IT”, with id 100,
	--employee with SSN = 112233 as a manager for this department. The start date for this 
	--manager is '1-11-2006'
insert into Departments(Dname, Dnum, MGRSSN,[MGRStart Date])
values ('DEPT IT', 100, 112233, '1/11/2006')


--12. Do what is required if you know that :
	-- Mrs.Noha Mohamed(SSN=968574) moved to be the manager of the new department (id = 100),
	--and they give you(your SSN = 102672) her position (Dept. 20 manager) 
		--a. First try to update her record in the department table
		--b. Update your record to be department 20 manager.
begin try
	begin transaction
	update Departments
	set 
		MGRSSN = 968574,
		[MGRStart Date] = getdate()
	where Dnum = 100

	update Departments
	set 
		MGRSSN = 102672,
		[MGRStart Date] = getdate()
	where Dnum = 20
	commit
end try
begin catch
	rollback
end catch
--c. Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update Employee
set Superssn = 102672
where SSN = 102660


--13. Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344)
	--so try to delete his data from your database in case you know that you will be temporarily in his position.
	--Hint: (Check if Mr. Kamel has dependents,
	--works as a department manager, supervises any employees or works in any projects and handle these cases).
begin try
	begin transaction
	
	--dependent check
	if exists (select 1 from Dependent where ESSN = 223344)
	begin 
		delete 
		from Dependent
		where ESSN = 223344
	end

	--supervises check
	if exists (select 1 from Employee where Superssn = 223344)
	begin 
		update Employee
		set Superssn = 102672
		where Superssn = 223344
	end

	--projects check
	if exists (select 1 from Works_for where ESSn = 223344)
	begin 
		update Works_for
		set ESSn = 102672
		where ESSn = 223344
	end

	--delete kamel 
	delete 
	from Employee 
	where ssn = 223344

	commit 
end try
begin catch
	rollback
end catch

--14. Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee
set Salary = Salary + Salary*0.3
where ssn in
		(select w.ESSn 
		from Project as p  
		join Works_for as  w
		on w.Pno = p.Pnumber
		where p.Pname = 'Al Rabwah')
