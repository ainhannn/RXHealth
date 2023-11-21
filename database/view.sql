USE pharmacy;

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
LEFT JOIN category ON product.category_id=category.id
INNER JOIN product_batch ON product.id=product_batch.product_id
GROUP BY product.barcode;


CREATE VIEW review_sale_invoice AS
SELECT 
	sale_invoice.id,
	sale_invoice.code, 
    sale_invoice.time_init, 
	sale_invoice.staff_id, 
	sale_invoice.customer_id,
    SUM(sale_detail.number*sale_detail.unit_price) AS total_amount,
	sale_invoice.point
FROM sale_invoice
LEFT JOIN sale_detail ON sale_invoice.id=sale_detail.sale_invoice_id
GROUP BY sale_invoice.id;


CREATE VIEW review_import_invoice AS
SELECT 
	import_invoice.id,
	import_invoice.code, 
    import_invoice.time_init, 
	import_invoice.staff_id, 
	import_invoice.supplier_id,
    SUM(import_detail.number*import_detail.import_price) AS total_amount
FROM import_invoice
LEFT JOIN import_detail ON import_invoice.id=import_detail.import_invoice_id
GROUP BY import_invoice.id;


CREATE VIEW best_seller_product AS
SELECT 
	product.barcode,
    product.name,
    category.name AS `cate`,
   	COUNT(sale_detail.sale_invoice_id) AS times
FROM product
LEFT JOIN category ON product.category_id=category.id
INNER JOIN sale_detail ON product.id=sale_detail.product_id
GROUP BY product.barcode;
