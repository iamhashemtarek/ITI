use Company_SD;

--1. Display the Department id, name and id and the name of its manager.
select d.Dnum, d.Dname, e.SSN, e.Fname+' '+e.Lname as 'name'
from Departments as d
inner join Employee as e
on d.MGRSSN = e.SSN

--2. Display the name of the departments and the name of the projects under its control.
select d.Dname, ISNULL(p.Pname, 'no projects yet') as 'project name'
from Departments as d
left join  Project as p
on p.Dnum = d.Dnum

--3. Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select e.Fname+' '+e.Lname as name,  d.*
from Employee as e
inner join Dependent as d
on d.ESSN = e.SSN

--4. Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber, Pname, Plocation
from Project
where City in ('Cairo', 'Alex')

--5. Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project
where Pname like 'a%'

--6. display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee
where Dno = 30 
	and salary between 1000 and  2000

--7. Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select e.Fname+' '+e.Lname as name
from Employee as e
inner join Works_for as w
on w.ESSn = e.SSN
inner join Project as p
on p.Pnumber = w.Pno
where e.Dno = 10 
	and w.Hours >= 10
	and p.Pname = 'AL Rabwah'

--8. Find the names of the employees who directly supervised with Kamel Mohamed.
select e.Fname+' '+e.Lname as name
from Employee as e
inner join Employee as mng
on e.Superssn = mng.SSN
where (mng.Fname+' '+mng.Lname) = 'Kamel Mohamed'

--9. Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.Fname+' '+e.Lname as name, p.Pname
from Employee as e
inner join Works_for as w
on w.ESSn = e.SSN
inner join Project as p
on w.Pno = p.Pnumber
order by p.Pname asc

--10. For each project located in Cairo City , find the project number, 
-- the controlling department name ,the department manager last name ,address and birthdate.
select p.Pnumber, d.Dname, mng.Lname, mng.Address, mng.Bdate
from Project as p
inner join Departments as d
on p.Dnum = d.Dnum
inner join Employee as mng
on d.MGRSSN = mng.SSN
where p.City = 'Cairo'

--11. Display All Data of the managers
select e.*
from Employee as e
inner join Departments as d
on d.MGRSSN = e.SSN

--12. Display All Employees data and the data of their dependents even if they have no dependents
select e.*, d.*
from Employee as e
left join Dependent as d
on d.ESSN = e.SSN

--13. Insert your personal data to the employee table as a new employee in department 
	--number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee
values ('hashem', 'tarek', 102672, '1/9/2000', 'birket elsabaa', 'M', 3000, 112233, null)

--14. Insert another employee with personal data your friend as new employee in 
	--department number 30, SSN = 102660, but don’t enter any value for salary or 
	--supervisor number to him.
insert into Employee(Fname, Lname, SSN, Dno)
values ('yomna', 'elgazar', 102660, 30)

--15. Upgrade your salary by 20 % of its last value
update Employee
set
	Salary  = Salary + (0.2*Salary)
where SSN = 102672
