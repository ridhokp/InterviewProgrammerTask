--1.	Create script to create table for each object
		--a. 
		create table Employee(
			Id int identity(1,1) not null primary key,
			EmployeeId varchar(10) not null unique,
			FullName varchar(100) not null,
			BirthDate date not null,
			Address varchar(500)
		);
		--b.
		create table PositionHistory(
			Id int identity(1,1) not null primary key,
			PosId varchar(10) not null unique,
			PosTitle varchar(100) not null,
			EmployeeId varchar(10) not null,
			StartDate date not null,
			EndDate date not null
		);

--2.	Create insert script to inserting data into each table (Employee and PositionHistory)
		insert into Employee (EmployeeId,FullName,BirthDate,Address) values 
		('10105001','Ali Anton','1982-08-19','Jakarta Utara'),
		('10105002','Rara Siva','1982-01-1','Mandalika'),
		('10105003','Rini Aini','1982-02-20','Sumbawa Besar'),
		('10105004','Budi','1982-02-22','Mataram Kota');

		insert into PositionHistory (PosId,PosTitle,EmployeeId,StartDate,EndDate) values
		('50000','IT Manager','10105001','2022-01-01','2022-02-28'),
		('50001','IT Sr. Manager','10105001','2022-03-01','2022-12-31'),
		('50002','Programmer Analyst','10105002','2022-01-01','2022-02-28'),
		('50003','Sr. Programmer Analyst','10105002','2022-03-01','2022-12-31'),
		('50004','IT Admin','10105003','2022-01-01','2022-02-28'),
		('50005','IT Secretary','10105003','2022-03-01','2022-12-31');

--3.	Create query to display all employee (EmployeeId, FullName, BirthDate, Address) data with their current position information (PosId, PosTitle, EmployeeId, StartDate, EndDate).
		select 
		a.EmployeeId, a.FullName, a.BirthDate, a.Address, b.PosId, b.PosTitle, b.EmployeeId, b.StartDate, b.EndDate
		from Employee a inner join PositionHistory b on a.EmployeeId=b.EmployeeId