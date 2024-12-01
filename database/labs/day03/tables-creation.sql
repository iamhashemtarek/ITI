create database Day03;
use Day03;
create table instructor 
(
	id int not null primary key,
	first_name varchar(50) not null,
	last_name varchar(50),
	date_of_birth date not null,
	age as datediff(year, getdate(), date_of_birth),
	address varchar(255) check(address in ('cairo', 'alex')),
	hire_date date not null default getdate(),
	overtime decimal(10,2) unique ,
	salary decimal(10,2) default 3000 check(salary between 1000 and 5000),
	net_salary as (salary + overtime) persisted
);

create table course 
(
	id int not null primary key,
	name varchar(50) not null,
	duration tinyint not null unique
);

create table teach
(
	instructor_id int,
	course_id int,
	constraint teach_pk primary key(instructor_id, course_id),
	constraint teach_instructor_fk foreign key(instructor_id)
		references instructor(id) 
		on delete cascade
		on update cascade,
	constraint teach_course_fk foreign key(course_id)
		references course(id) 
		on delete cascade
		on update cascade
);

create table lab
(
	id int not null primary key,
	location varchar(255),
	capacity tinyint check(capacity <= 20),
	course_id int,
	constraint lab_course_fk foreign key(course_id)
		references course(id)
		on delete cascade
		on update cascade
);