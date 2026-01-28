
create database LPU_Db;

use LPU_Db;

create Schema PankajBatch;

create table PankajBatch.Person(
Id int primary key identity(1,1),
Name varchar(20) not null,
Age int,
Address varchar(50),
PhoneNo varchar(10)
);		

create table Dummy(dummyID uniqueidentifier,
name varchar(15));

Select * from Dummy;

insert into Dummy(name) values('Mahi');
insert into Dummy(name) values('Naina');
insert into Dummy(name) values('Suryansh');

create Type Address from Varchar(50) not null;
 
drop table Dummy;

create Table StudentInfo(RollNo int Primary Key,
Name varchar(15) not null,
Age smallint not null,
LocalAddress Address,
PerAddress Address
);

select * from StudentInfo;

insert Into StudentInfo(Name,Age,PerAddress,LocalAddress,RollNo) Values('Suryansh Shukla',24,'Tilak Nagar, Auraiya, Uttar Pradesh,206122','ParkView Residency, Law Gate, Phagwara, Punjab',68);

create type EmailAddress from varchar


use Northwind;

Select count(*) from Customers;

Select count(*) from [Order Details];

use AdventureWorks2022;

Alter User Andres With Default_schema=Sales;

Alter Table StudentInfo add PhoneNo varchar(10);

Alter table StudentInfo add SchoolName Varchar(10) default 'RKVM';

insert into StudentInfo(RollNo,Name,Age,LocalAddress,PerAddress,PhoneNo) values(102,'Maahu',19,'Delhi','Amritsar','9343239798'); 

Select * from StudentInfo;


create table StudentMarks(srNo int identity(1000,1) Primary key,
RollNo int references dbo.StudentInfo(RollNo),
phy int not null,chem int not null, Maths int not null,TotalMarks as (phy+chem+Maths), Perc as((phy+chem+Maths)/3));

select * from StudentMarks;

select * from StudentInfo;

Insert into StudentMarks(RollNo,phy,chem,Maths) values(68,85,65,75);
Insert into StudentMarks(RollNo,phy,chem,Maths) values(102,95,85,87);
Insert into StudentMarks(RollNo,phy,chem,Maths) values(103,55,65,45);
Insert into StudentMarks(RollNo,phy,chem,Maths) values(104,67,66,35);

select * from 

SP_HELP;

Insert Into StudentInfo(RollNo,Name,Age,LocalAddress,PerAddress) values(103,'Naina Singh',10,'Delhi','Ambarsar');

Update StudentInfo set Age=19 where RollNo=103;

Alter Table StudentInfo add Constraint Chk_Age check (Age>18 and Age<60);

Create  Default Agedefault as 18 
Go 
Exec sp_bindefault phone_no_default,'Customers.Phone'

CREATE Default DF_HOMETOWN as 'Pune'
Go
Exec sp_bindefault DF_HOMETOWN,
'StudentInfo.LocalAddress'

Select * from Person;

Exec sp_bindefault DF_HOMETOWN,
'Person.Address'

Insert Into Person(Name,Age,PhoneNo) Values
('Nishant',21,'5664498765'),
('Suryansh Shukla',24,'8755896556'),
('Maahi',19,'9343239798');

Alter table Person add SocialStatus varchar(10);

CREATE RULE SocialStatus_Rule
AS @SocialStatus IN('un-Married','Married','Widow','Divorcee');

exec sp_bindrule SocialStatus_Rule,'Person.SocialStatus'

declare @num1 as int
set @num1=100;
declare @num2 as int 
set @num2=200;

declare @numResult as int 
set @numResult =@num1 +@num2;
print @numResult;

print 'The Sum of '+cast(@num1 as varchar)+' and '+cast(@num2 as varchar)+' is '+cast(@numResult as varchar);