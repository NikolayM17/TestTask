use test_task;
go

create trigger product_insert
on product
after insert
as
insert into product_category_connection
values ((select ident_current('product')), 4);