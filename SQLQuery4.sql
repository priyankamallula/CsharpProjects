

create table Customer( customer_id numeric(5),cust_name varchar(30),city varchar(15), grade numeric(3), salesman_id numeric(5),primary key(customer_id))

insert into Customer values(3002,'Nick Rimando ', ' New York ' ,100 ,5001)
insert into Customer values(3007 ,' Brad Davis ',  ' New York ', 200, 5001)
insert into Customer values(3005 , 'Graham Zusi'  , 'California', 200 ,5002)
insert into Customer values(3008 , 'Julian Green ',' London' ,   300, 5002)
insert into Customer values(3004 ,'Fabian Johnson' ,'Paris',     300,  5006)
insert into Customer values(3009 , 'Geoff Cameron'  ,' Berlin',   100,  5003)
insert into Customer values (3003 , 'Jozy Altidor '  , 'Moscow ', 200 , 5007)
insert into Customer values(3001 , 'Brad Guzan'  ,' London ',100,5005)

--select customer_id ,cust_name ,city ,grade, salesman_id from Customer where grade = 200

select count(cust_name) as 'number of customers' from customer

select city, max(grade) from customer group by city      --5

select * from Customer  

--write a SQL query to find the salesperson(s) and the customer(s) he handle. Return 
--Customer Name, city, Salesman, commission

select customer.cust_name as 'customer name', salesman.city as 'city', salesman.name as 'salesman', 
salesman.commission as 'commission' from salesman inner join customer on salesman.salesman_id = customer.salesman_id

--write a SQL query to find those salespersons who received a commission from the company more than 12%. Return Customer Name,
-- customer city, Salesman, commission.


select customer.cust_name as 'customer name', customer.city as ' customer city', salesman.name as 'salesman', 
salesman.commission as 'commission' from customer inner join salesman on customer.salesman_id = salesman.salesman_id
where salesman.commission >0.12

--write a SQL query to find those salespersons do not live in the same city where their customers live and received a commission from the
 --company more than 12%. Return Customer Name, customer city, Salesman, salesman city, commission


select customer.cust_name as 'customer name', customer.city as ' customer city', salesman.name as 'salesman', salesman.city as'salesman city',
salesman.commission as 'commission' from customer inner join salesman on salesman.salesman_id = customer.salesman_id
where salesman.commission >0.12








