

create database US_BANGLA_AIRLINES
use US_BANGLA_AIRLINES
create table Airport
(
	City varchar(100),
	Airport_Name varchar(100),
	ID int,
	Airplane_Id int
);



create table Employee
(
	Emp_Name varchar(100),
	Emp_ID int Identity(1,1) primary key,
	Age int,
	Salary int,
	Gender varchar(10),
	PhoneNO varchar (20)
)
create table Emp_user
(
	password varchar(20) not null,
	username varchar(20) not null primary key,
	Emp_ID int identity(1,1) unique not null FOREIGN KEY REFERENCES Employee(Emp_ID)

)


create table Passenger
(
	
	P_Name varchar(100) not null,
	P_ID int Not Null Identity(1,1) primary key,
	Country varchar(100) not null,
	P_Address varchar(100) not null,
	gender varchar(10) not null,
	PhoneNO varchar(20),
	Email varchar(50)

)
create table Psngr_user
(
	password varchar(20) not null,
	username varchar(20) not null primary key,
	P_ID int identity(1,1) not null FOREIGN KEY REFERENCES Passenger(P_ID)

)




create table Tickets
(
	
	ticket_num int Identity(1,1) primary key,
	Flight_No int,
	Amount int,
	P_ID int FOREIGN KEY REFERENCES Passenger(P_ID),
	Destination varchar(100),
	Depr_Hr varchar(100),
	Airplane_Id int,
	Depr_date date,
	Airlines_company varchar(100)
)

insert into Flights values('Dhakha','Biman Bangladesh Airlines',111)

create table Airlines_company
(
	country varchar(100),
	Name varchar(100),
	ID int
)
create table booking
(
	Destination varchar(100),
	Airlines_company varchar(100),
	Amount int,
	Departure_date date,
	P_ID int not null FOREIGN KEY REFERENCES Passenger(P_ID),
	importance varchar(20)

)

create table admin
(
	username varchar(20) not null primary key,
	password varchar(20) not null
	
)


insert into admin values('admin','admin')

insert into Passenger values('Dhakha','Shahjalal International Airport',07802,340)
drop table admin
select * from Passenger

SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email
FROM Passenger p
INNER JOIN Psngr_user u ON p.P_ID=u.P_ID
where username = 'rahim12' and password = '12'


SELECT e.Emp_ID as Your_ID,e.Emp_Name as Your_Name ,e.Gender as Your_Gender,e.PhoneNO,e.Salary
FROM Employee e
INNER JOIN Emp_user u ON e.Emp_ID=u.Emp_ID
where username = 'Abul1'

select * from Passenger

 UPDATE Passenger
SET P_Name = 'Alfred Schmidt', Country= 'Frankfurt',P_Address='fran',gender='female',PhoneNO='9998990',Email='fran@gamil.com'
WHERE P_ID = '1';

select Count(*) AS TOTAL_PASSENGERS from Passenger

SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email,t.Airlines_company,t.Airplane_Id,t.Amount,t.Depr_date,t.Depr_Hr,t.Destination,t.Flight_No,t.ticket_num FROM Passenger p INNER JOIN Tickets t ON p.P_ID=t.P_ID inner join Psngr_user ps on ps.P_ID=p.P_ID where ps.username='emon29959' and ps.password = '1234'
select * from booking
delete from booking where P_ID= 

insert into booking values()


DELETE FROM Passenger where P_ID =
DELETE FROM Psngr_user where P_ID =
DELETE FROM Tickets where P_ID =
DELETE FROM booking where P_ID =3


select Tickets.P_ID as Passenger_ID, Count(Tickets.P_ID) as Total_Ticket,Passenger.P_Name,Passenger.PhoneNO from Tickets inner join Passenger on Passenger.P_ID = Tickets.P_ID 
group by Tickets.P_ID,Passenger.P_Name,Passenger.PhoneNO
having Count(Tickets.P_ID) > 1 

select SUM(Salary) as Total_Summation_of_Salary from Employee
select AVG(Salary) as Total_Summation_of_Salary from Employee
select * from Employee where Salary > (select salary from Employee where Emp_ID= )
				
SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email,t.Airlines_company,t.Airplane_Id,t.Amount,t.Depr_date,t.Depr_Hr,t.Destination,t.Flight_No,t.ticket_num FROM Passenger p 
INNER JOIN Tickets t ON p.P_ID=t.P_ID 
inner join Psngr_user ps on ps.P_ID=p.P_ID where ps.username='emon29959' and ps.password = 'emon'				
			 