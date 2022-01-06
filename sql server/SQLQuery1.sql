create database TutorialDB

create table Tutorial(TutorialId int, Tutorialname varchar(100) , TutorialDsec varchar(max))

insert into Tutorial values( 1 , 'java' , 'multithreading' )
insert into Tutorial values (2 ,  'C#' ,'oops')
insert into Tutorial values (3 ,'Python','new')

select tutorialname from tutorial

select * from Tutorial

delete from Tutorial

delete from tutorial where tutorialid = 2

alter table tutorial add  published varchar(100)

update tutorial set published = 'priya'

update tutorial set published = 'revathi' where tutorialname = 'java'