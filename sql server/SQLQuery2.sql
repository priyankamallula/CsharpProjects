create database HandsOn

create table salesman(salesman_id numeric(5) , name varchar(30), city varchar(15),commission decimal(5,2), primary key (salesman_id ))

insert into salesman values(5001, 'James Hoog', 'New York' ,0.15)
insert into salesman values(5002, 'Nail Knite', 'Paris' ,0.13)
insert into salesman values(5005, 'Pit Alex', 'London' ,0.11)
insert into salesman values(5006, 'Mc Lyon', 'Paris' ,0.14)
insert into salesman values(5007, 'Paul Adam', 'Rome' ,0.13)
insert into salesman values(5003, 'Lauson Hen', 'San Jose' ,0.12)



select  name,commission from salesman

select name,city from salesman where city = 'paris'

select * from salesman