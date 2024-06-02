create Database EFCoreDB

go

use EFCoreDB

go

create table Category
(
Id int primary key identity,
Name varchar(50),
SellerName varchar(100)
)
go
insert into Category values ('Mens Wear', 'Lee Cooper')
go

select * from Category

