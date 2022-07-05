use test_task;

insert into product
values
('banana'),
('apple'),
('tea'),
('chocolate');

insert into category
values
('fruits'),
('drinks'),
('sweets');

insert into product_category_connection
values
(1, 1),
(2, 1),
(3, 2),
(4, 3);
