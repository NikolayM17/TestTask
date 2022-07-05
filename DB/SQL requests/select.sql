use test_task;

select product.name as product, category.name as category
	from product
	join product_category_connection on product_category_connection.product_id = product.id
	join category on category.id = product_category_connection.category_id;