
-- -- -- -- -- VIEWS -- -- -- -- --
CREATE VIEW search_sale_product AS
SELECT 
	product.barcode,
    product.name,
    category.name AS `cate`,
	
    product.unit,
    product.saleprice,
   	SUM(product_batch.number) AS number,
	
    product.retail_unit,
    product.retail_saleprice,
    product.retail_number
FROM product
LEFT JOIN product_batch ON product.id=product_batch.product_id
LEFT JOIN category ON product.category_id=category.id;


CREATE VIEW review_sale_invoice AS
SELECT 
	sale_invoice.id,
	sale_invoice.code, 
    sale_invoice.time_init, 
    staff.nickname AS `staff_nickname`, 
    customer.name AS `customer_name`, 
    SUM(sale_detail.number*sale_detail.unit_price) AS total_amount,
	sale_invoice.point
FROM sale_invoice
LEFT JOIN sale_detail ON sale_invoice.id=sale_detail.sale_invoice_id
LEFT JOIN staff ON sale_invoice.staff_id=staff.id
LEFT JOIN customer ON sale_invoice.customer_id=customer.id;

CREATE VIEW best_product AS
SELECT 
	product.barcode,
    product.name,
    category.name AS `cate`,
	
    product.unit,
    product.saleprice,
   	SUM(product_batch.number) AS number,
	
    product.retail_unit,
    product.retail_saleprice,
    product.retail_number
FROM product
LEFT JOIN product_batch ON product.id=product_batch.product_id
LEFT JOIN category ON product.category_id=category.id;
