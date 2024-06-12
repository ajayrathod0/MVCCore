create database APICoreDB
go
use APICoreDB
go
create table Product
(
Id int primary key identity,
Name varchar(50),
Price int
)
go
select * from Product