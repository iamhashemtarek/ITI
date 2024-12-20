use Company_SD;

--1. Display all the employees Data.
select *
from Employee

--2. Display the employee First name, last name, Salary and Department number.
select fname as "first name", lname as "last name", salary, dno as "department number"
from Employee

--3. Display all the projects names, locations and the department which is responsible about it.
select p.pname, p.plocation, d.dname
from Project as p
inner join Departments as d
on p.dnum = d.dnum

--4. If you know that the company policy is to pay an annual commission for each employee with specific percent equals 10% of his/her annual salary.
--Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
select fname + ' ' + lname as "full name", (salary*12*0.1) as "annual commission" 
from Employee

--5. Display the employees Id, name who earns more than 1000 LE monthly.
select ssn, fname+' '+lname as name
from Employee
where salary > 1000

--6. Display the employees Id, name who earns more than 10000 LE annually.
select ssn, fname+' '+lname as name
from Employee
where salary*12 > 10000

--7. Display the names and salaries of the female employees 
select fname+' '+lname as name, salary
from Employee
where sex = 'F' or sex = 'f'

--8. Display each department id, name which managed by a manager with id equals 968574.
select dnum, dname
from Departments
where MGRSSN = 968574

--9. Dispaly the ids, names and locations of the pojects which controled with department 10.
select Pnumber, Pname, Plocation
from Project
where Dnum = 10