create table categoria(
id int identity(1,1) primary key,
categoria varchar(25)
)

create table sub_categoria(
id_sub int identity(1,1) primary key,
id_categoria int not null,
sub_categoria varchar(25) not null
)

insert into categoria values('Varios')
insert into sub_categoria values(4,'Cascos')

update categoria set categoria = 'Eléctronica' where id = 2

select * from categoria
select * from sub_categoria