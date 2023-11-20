DROP DATABASE IF EXISTS pharmacy;
CREATE DATABASE pharmacy;
USE pharmacy;

-- -- -- -- -- TABLES -- -- -- -- --
CREATE TABLE title (
	id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL
);

CREATE TABLE staff (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nickname VARCHAR(16) UNIQUE NOT NULL,
    citizen_id_number VARCHAR(12) UNIQUE NOT NULL,
    fullname VARCHAR(50) NOT NULL,
    birthday DATETIME NOT NULL,
    gender BOOLEAN DEFAULT TRUE,
    qualification VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) NOT NULL,
    address VARCHAR(100),
    start_date DATETIME DEFAULT CURRENT_DATE(),
    resignation_date DATETIME
);

CREATE TABLE account (
    id INT PRIMARY KEY,
    username VARCHAR(16),
    password VARCHAR(16),
    role TINYINT DEFAULT 3,
    avatar TEXT,
    CONSTRAINT fk_account_staff FOREIGN KEY (id) REFERENCES staff(id) ON DELETE CASCADE
);

CREATE TABLE reset_request_tmp (
    id INT PRIMARY KEY,
    CONSTRAINT fk_request_reset_password FOREIGN KEY (id) REFERENCES account(id)
);

CREATE TABLE customer (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) UNIQUE NOT NULL,
    total_point SMALLINT UNSIGNED DEFAULT 0
);

CREATE TABLE supplier (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) UNIQUE NOT NULL,
    address VARCHAR(100) NOT NULL
);

CREATE TABLE category (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE country (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE substance (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE product (
    id INT AUTO_INCREMENT PRIMARY KEY,
    stack VARCHAR(10), 
    barcode VARCHAR(16) UNIQUE,
    name VARCHAR(50) NOT NULL,
    category_id INT NOT NULL,
    expiry TINYINT UNSIGNED,
    current_import_price DECIMAL(10,0) NOT NULL,
    unit VARCHAR(25) NOT NULL,
    saleprice DECIMAL(10,0),
    retail_unit VARCHAR(25) NOT NULL,
    retail_saleprice DECIMAL(10,0),
    retail_number INT DEFAULT 0,
    extra_information TEXT,
    image TEXT,
    is_on_sale BOOLEAN DEFAULT TRUE,
    is_existing BOOLEAN DEFAULT TRUE,
    CONSTRAINT fk_info_cate FOREIGN KEY (category_id) REFERENCES category(id) ON DELETE CASCADE
);

CREATE TABLE product_batch (
    local_code VARCHAR(13) PRIMARY KEY, 
    product_id INT NOT NULL,
    mfg_date DATETIME,
    exp_date DATETIME,	
    number INT DEFAULT 0,
    CONSTRAINT fk_batch_product FOREIGN KEY (product_id) REFERENCES product(id)
);

CREATE TABLE trash_tmp (
    product_id INT PRIMARY KEY,
    CONSTRAINT fk_trash_product FOREIGN KEY (product_id) REFERENCES product(id)
);								

CREATE TABLE import_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code VARCHAR(16) UNIQUE NOT NULL,
    time_init DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    supplier_id	INT NOT NULL,
    CONSTRAINT fk_import_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_import_supplier FOREIGN KEY (supplier_id) REFERENCES supplier(id)
);
	
CREATE TABLE import_detail (
    import_invoice_id INT NOT NULL,
    product_id INT NOT NULL,
    barcode VARCHAR(16) UNIQUE,
    name VARCHAR(50) NOT NULL,
	mfg_date DATETIME,
	exp_date DATETIME,
    unit VARCHAR(25) NOT NULL,
    number INT DEFAULT 1,
    import_price DECIMAL (10,0) NOT NULL,	
    CONSTRAINT pk_import_detail PRIMARY KEY(import_invoice_id, product_id),
    CONSTRAINT fk_detail_import FOREIGN KEY (import_invoice_id) REFERENCES import_invoice(id),
    CONSTRAINT fk_import_product FOREIGN KEY (product_id) REFERENCES product(id)
);

CREATE TABLE sale_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code VARCHAR(16) UNIQUE NOT NULL,
    time_init DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    customer_id	INT DEFAULT 1,
	point SMALLINT UNSIGNED DEFAULT 0,
    CONSTRAINT fk_sale_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_sale_customer FOREIGN KEY (customer_id) REFERENCES customer(id)
);

CREATE TABLE sale_detail (
    sale_invoice_id	INT NOT NULL,
    product_id INT NOT NULL,
    name VARCHAR(50) NOT NULL,
    unit VARCHAR(25) NOT NULL,
    unit_price DECIMAL(10,0) NOT NULL,
    number INT DEFAULT 1,
    CONSTRAINT pk_sale_detail PRIMARY KEY(sale_invoice_id, product_id),
    CONSTRAINT fk_detail_sale FOREIGN KEY (sale_invoice_id) REFERENCES sale_invoice(id),
    CONSTRAINT fk_sale_product FOREIGN KEY (product_id) REFERENCES product(id)
);			

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

DELIMITER //
-- -- -- -- -- TRIGGERS -- -- -- -- --
CREATE TRIGGER auto_product_local_code
        BEFORE INSERT ON product_batch 
        FOR EACH ROW
BEGIN
    DECLARE code VARCHAR(13);
    DECLARE pid VARCHAR(5);
    DECLARE timeid VARCHAR(6);
    DECLARE num INT;
       
    SELECT LPAD(id,5,0) INTO pid
    FROM product WHERE product.id = NEW.product_id;

	SET timeid = DATE_FORMAT(CURRENT_TIMESTAMP,"%d%m%y");

    SET code = CONCAT('P',pid,timeid,'%');
    SELECT COUNT(*) INTO num
    FROM product_batch WHERE local_code LIKE code;
    
    SET code = CONCAT('P',pid,timeid,CHAR(ASCII('A')+num));
    SET NEW.local_code = code;
END//

CREATE TRIGGER auto_import_code
        BEFORE INSERT ON import_invoice 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'import_invoice' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('IM',LPAD(newid,5,0));
END//

CREATE TRIGGER auto_sale_code
        BEFORE INSERT ON sale_invoice 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'sale_invoice' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('SA',LPAD(newid,5,0));
END//

CREATE TRIGGER auto_update_total_point
        AFTER INSERT ON sale_invoice 
        FOR EACH ROW
BEGIN
    UPDATE customer SET total_point = total_point + NEW.point
	WHERE customer.id = NEW.customer_id;
END//

CREATE TRIGGER auto_insert_storage_product
		AFTER INSERT ON import_detail 
		FOR EACH ROW
BEGIN
	INSERT INTO product_batch(product_id, mfg_date, exp_date, number)
	VALUES (NEW.product_id,NEW.mfg_date,NEW.exp_date,NEW.number);
END//

CREATE TRIGGER auto_update_storage_number
        AFTER INSERT ON sale_detail 
        FOR EACH ROW
BEGIN
    DECLARE u VARCHAR(25);
    DECLARE ru VARCHAR(25);
    DECLARE lc VARCHAR(13);
    DECLARE n INT;
    DECLARE nb INT;

	SELECT unit INTO u
	FROM product WHERE id = NEW.product_id;
	SELECT retail_unit INTO ru
	FROM product WHERE id = NEW.product_id;
		
	IF NEW.unit = ru THEN
      	UPDATE product SET retail_number = retail_number - NEW.number
		WHERE id = NEW.product_id;
	ELSEIF NEW.unit = u THEN
		SET n = NEW.number;
    	WHILE n > 0 DO 
        	SELECT local_code INTO lc
            FROM product_batch
            WHERE product_id = NEW.product_id AND number > 0
            ORDER BY exp_date ASC LIMIT 1;

			SELECT number INTO nb
            FROM product_batch
            WHERE local_code = lc;
			
            IF nb >= n THEN
            	UPDATE product_batch SET number = nb - n
				WHERE local_code = lc;
				SET n = 0;
            ELSE
            	UPDATE product_batch SET number = 0
				WHERE local_code = lc;
                SET n = n - nb;
            END IF;
        END WHILE;
	END IF;
END//

-- -- -- -- -- PROCEDURES -- -- -- -- --
CREATE PROCEDURE login(user VARCHAR(16), pass VARCHAR(16))
BEGIN
    DECLARE acc_id INT;
    DECLARE role_number INT;
    DECLARE avt TEXT;

    IF EXISTS(SELECT id FROM account WHERE username=user AND password=pass) THEN 
        SELECT id INTO acc_id FROM account WHERE username=user AND password=pass;
        SELECT role INTO role_number FROM account WHERE id=acc_id;
        SELECT avatar INTO avt FROM account WHERE id=acc_id;
        SELECT acc_id, user, role_number, avt;
    ELSE
        SELECT null, null, null, null;
    END IF;
END//

CREATE PROCEDURE insert_account(staff_id INT, role_number INT)
BEGIN
    DECLARE user VARCHAR(16);
    DECLARE pass VARCHAR(16);
    
    SELECT citizen_id_number INTO user
    FROM staff WHERE staff.id=staff_id;
    
    SELECT DATE_FORMAT(birthday,"%d%m%Y") INTO pass
    FROM staff WHERE staff.id=staff_id;
    
    INSERT INTO account(id,username,password,role)
    VALUES (staff_id, user, pass, role_number);
END//
	
CREATE PROCEDURE export_for_retail(product_id INT, number INT, capacity INT)
BEGIN
    DECLARE lc VARCHAR(13);
    DECLARE n INT;
    DECLARE nb INT;

	SET n = number;
    WHILE n > 0 DO
		SELECT local_code INTO lc
		FROM product_batch
		WHERE product_batch.product_id = product_id AND product_batch.number > 0
		ORDER BY exp_date ASC LIMIT 1;

		SELECT product_batch.number INTO nb
		FROM product_batch
		WHERE local_code = lc;
			
		IF n > nb THEN
			UPDATE product_batch SET product_batch.number = 0
			WHERE local_code = lc;
			SET n = n - nb;
		ELSE
			UPDATE product_batch SET product_batch.number = product_batch.number - n
			WHERE local_code = lc;
			SET n = 0;
		END IF;
	END WHILE;
	
	UPDATE product SET retail_number = retail_number+(number*capacity);
END//
