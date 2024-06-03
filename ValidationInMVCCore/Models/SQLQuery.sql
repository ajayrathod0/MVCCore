create database ValidationDB
go
use ValidationDB
go

create table Users(
id int identity primary key,
FirstName varchar(100),
LastName Varchar(100),
Password varchar(500),
DateOfBirth datetime2
)

go

select * from users