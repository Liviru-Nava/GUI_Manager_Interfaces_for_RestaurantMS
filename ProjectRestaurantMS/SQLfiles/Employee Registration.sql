create database RestaurantManagementSystem;

use RestaurantManagementSystem;



create table EmployeeReg
(
Employee_ID varchar(10) primary key not null, 
Position varchar(20) not null, 
First_Name varchar(30) not null, 
Last_Name varchar(30) not null, 
Gender varchar(50) not null, 
Email varchar(50) not null,
Telephone varchar(10) not null, 
Address varchar(50) not null, 
Date_of_Birth date not null, 
Age int not null, 
Username varchar(50) not null, 
Password varchar(30) not null, 
User_Image image not null
);

drop table EmployeeReg;
select* from EmployeeReg;
truncate table EmployeeReg;

insert into EmployeeReg
values ('EMP00001', 'Manager', 'Liviru', 'Nava', 'Male', 'liviru123@gmail.com', 
'0711047585', 'Colombo', '8-7-2023', 23, 'Yahiko', 'Ambuja', '0xd234');