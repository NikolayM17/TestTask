use test_task;

create table product(
	id int primary key identity,
	name varchar(50)
);

create table category(
	id int primary key identity,
	name varchar(50)
);

create table product_category_connection(
	product_id int references product(id),
	category_id int references category(id),
);
