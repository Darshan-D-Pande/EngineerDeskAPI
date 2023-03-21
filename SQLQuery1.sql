create database EngineersDesk


use EngineersDesk
--creating table
create table Employee(
	
	EmpId int identity not null,
	EmpName varchar(100) null,
	City varchar(100) null,
	DOJ Datetime null,
Salary money not null

);


--inserting data in table

insert into Employee values('Darshan','Pune',GETDATE()-10,60000);
insert into Employee values('Pawan','Jalgaon',GETDATE()-40,70000);
select * from Employee;

delete from Employee where EmpId=2;

truncate table employee;