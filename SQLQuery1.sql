use master
go
create database banking_system
go
use banking_system
go

create table All_User(

	id int identity primary key,
	name varchar(200),
	phoneNumber varchar(200),
	[address] varchar(200),
	balance float not null,
	image image
)

create table Info(
	id int identity primary key,
	role varchar(20) not null,
	password int unique not null,
	userid int,
	foreign key(userid) references All_User(id)
)