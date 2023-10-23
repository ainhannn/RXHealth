-- Active: 1695203080273@@127.0.0.1@3306@pharmacy
DROP DATABASE IF EXISTS pharmacy;
CREATE DATABASE pharmacy;
USE pharmacy;

-- -- -- -- -- TABLES -- -- -- -- --
CREATE TABLE category (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);
CREATE TABLE active_ingredient (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);
CREATE TABLE manufacturer (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);
CREATE TABLE country (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) UNIQUE NOT NULL
);
CREATE TABLE unit (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(15) UNIQUE NOT NULL,
    number_each_unit INT DEFAULT 0,
    subunit_id INT,
    CONSTRAINT fk_unit_unit FOREIGN KEY (subunit_id) REFERENCES unit(id) ON DELETE SET NULL
);
CREATE TABLE provider (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) UNIQUE NOT NULL,
    address VARCHAR(100) NOT NULL,
    debt DECIMAL(10,0) DEFAULT 0,
    payment_date DATETIME,
    cycle VARCHAR(30)
);
CREATE TABLE customer (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) UNIQUE NOT NULL,
    total_point SMALLINT UNSIGNED DEFAULT 0
);
CREATE TABLE account (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(16) UNIQUE NOT NULL,
    password VARCHAR(16) NOT NULL,
    role TINYINT DEFAULT 3
);
CREATE TABLE staff (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nickname VARCHAR(16) UNIQUE NOT NULL,
    citizen_id_number VARCHAR(12) UNIQUE NOT NULL,
    fullname VARCHAR(50) NOT NULL,
    birthday DATETIME NOT NULL,
	gender BOOLEAN DEFAULT TRUE,
    qualification VARCHAR(50) NOT NULL,
    contact_number VARCHAR(12) UNIQUE NOT NULL,
    address VARCHAR(100),
    account_id INT UNIQUE,
    start_date DATETIME DEFAULT CURRENT_DATE(),
    resignation_date DATETIME,
    CONSTRAINT fk_staff_account FOREIGN KEY (account_id) REFERENCES account(id) ON DELETE SET NULL
);

CREATE TABLE product_info (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    name VARCHAR(50) NOT NULL,
    category_id INT NOT NULL,
    manufacturer_id INT NOT NULL,
    made_in INT DEFAULT 1,
    expiry TINYINT UNSIGNED,
    unit_id INT NOT NULL,
    storage_condition TEXT,
    note TEXT,
    image TEXT,
    CONSTRAINT fk_info_cate FOREIGN KEY (category_id) REFERENCES category(id) ON DELETE CASCADE,
    CONSTRAINT fk_info_manu FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(id),
    CONSTRAINT fk_info_country FOREIGN KEY (made_in) REFERENCES country(id),
    CONSTRAINT fk_info_unit FOREIGN KEY (unit_id) REFERENCES unit(id)
);
CREATE TABLE product_extra_ingredient (
    product_id INT NOT NULL,
    active_ingredient_id INT NOT NULL,
    dosage DECIMAL(6,4) NOT NULL,
    PRIMARY KEY(product_id, active_ingredient_id),
    CONSTRAINT fk_extra_product FOREIGN KEY (product_id) REFERENCES product_info(id),
    CONSTRAINT fk_info_ingredient FOREIGN KEY (active_ingredient_id) REFERENCES active_ingredient(id)
);								
CREATE TABLE order_form (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id int NOT NULL,
    provider_id	INT NOT NULL,
    CONSTRAINT fk_order_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_order_provider FOREIGN KEY (provider_id) REFERENCES provider(id)
);	
CREATE TABLE order_detail (
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    number INT DEFAULT 1,
    CONSTRAINT pk_order_detail PRIMARY KEY(order_id, product_id),
    CONSTRAINT fk_detail_order FOREIGN KEY (order_id) REFERENCES order_form(id),
    CONSTRAINT fk_order_info FOREIGN KEY (product_id) REFERENCES product_info(id)
);			
CREATE TABLE payment_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    provider_id	INT NOT NULL,
    content	VARCHAR(50),
    amount DECIMAL(10,0),
    paid DECIMAL(10,0),
    CONSTRAINT fk_payment_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_payment_provider FOREIGN KEY (provider_id) REFERENCES provider(id)
);	
CREATE TABLE import_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    provider_id	INT NOT NULL,
    total_number INT DEFAULT 0,
	total_amount DECIMAL(10,0) DEFAULT 0,
    CONSTRAINT fk_import_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_import_provider FOREIGN KEY (provider_id) REFERENCES provider(id)
);
CREATE TABLE import_detail (
    import_invoice_id INT NOT NULL,
    product_id INT NOT NULL,
    order_number INT,
    actual_number INT,
    import_unit_price DECIMAL (10,0),	
    CONSTRAINT pk_import_detail PRIMARY KEY(import_invoice_id, product_id),
    CONSTRAINT fk_detail_import FOREIGN KEY (import_invoice_id) REFERENCES import_invoice(id),
    CONSTRAINT fk_import_info FOREIGN KEY (product_id) REFERENCES product_info(id)
);
CREATE TABLE product (
    id INT PRIMARY KEY,
    stack VARCHAR(10),
    total_number INT DEFAULT 0,
    total_subunit_number INT DEFAULT 0,
    about_to_expire_number INT DEFAULT 0,
    rate DECIMAL(6,4) DEFAULT '0.15',
    is_on_sale BOOLEAN DEFAULT TRUE,
    is_existing BOOLEAN DEFAULT TRUE,
    CONSTRAINT fk_product_info FOREIGN KEY (id) REFERENCES product_info(id)
);
CREATE TABLE trash_tmp (
    id INT PRIMARY KEY,
    CONSTRAINT fk_trash_product FOREIGN KEY (id) REFERENCES product(id)
);								
CREATE TABLE inventory_form (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    CONSTRAINT fk_inventory_staff FOREIGN KEY (staff_id) REFERENCES staff(id)
);
CREATE TABLE inventory_detail (
    inventory_form_id INT NOT NULL,
	product_id INT NOT NULL,
    actual_number INT,
    standard_number INT,
    CONSTRAINT pk_inventory_detail PRIMARY KEY(inventory_form_id, product_id),
    CONSTRAINT fk_detail_inventory FOREIGN KEY (inventory_form_id) REFERENCES inventory_form(id),
    CONSTRAINT fk_inventory_product FOREIGN KEY (product_id) REFERENCES product(id)
);
CREATE TABLE product_batch (
    id INT AUTO_INCREMENT PRIMARY KEY,
    local_code CHAR(9) UNIQUE NOT NULL,
    import_invoice_id INT NOT NULL,
    product_id INT NOT NULL,
    manufacture_date DATETIME,
    number INT DEFAULT 0,
    subunit_number INT DEFAULT 0,
    sale_unit_price	DECIMAL(10,0) DEFAULT 0,
    sale_subunit_price DECIMAL(10,0) DEFAULT 0,
    CONSTRAINT fk_batch_import_detail FOREIGN KEY (import_invoice_id, product_id) REFERENCES import_detail(import_invoice_id, product_id),
    CONSTRAINT fk_batch_product FOREIGN KEY (product_id) REFERENCES product(id)
);
CREATE TABLE export_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    total_number INT DEFAULT 0,
    CONSTRAINT fk_export_staff FOREIGN KEY (staff_id) REFERENCES staff(id)
);
CREATE TABLE export_detail (
    export_invoice_id INT NOT NULL,
    product_batch_id INT NOT NULL,
    number INT NOT NULL,
    reason VARCHAR(50),	
    CONSTRAINT pk_export_detail PRIMARY KEY(export_invoice_id, product_batch_id),
    CONSTRAINT fk_detail_export FOREIGN KEY (export_invoice_id) REFERENCES export_invoice(id),
    CONSTRAINT fk_export_product FOREIGN KEY (product_batch_id) REFERENCES product_batch(id)
);
CREATE TABLE sale_invoice (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code CHAR(16) UNIQUE NOT NULL,
    date_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    staff_id INT NOT NULL,
    customer_id	INT NOT NULL,
    total_number INT DEFAULT 0,
	total_amount DECIMAL(10,0) DEFAULT 0,
    discount DECIMAL(6,4) DEFAULT '0',
	final_amount DECIMAL(10,0),
    cash DECIMAL(10,0),
    point SMALLINT UNSIGNED,
    CONSTRAINT fk_sale_staff FOREIGN KEY (staff_id) REFERENCES staff(id),
    CONSTRAINT fk_sale_customer FOREIGN KEY (customer_id) REFERENCES customer(id)
);
CREATE TABLE sale_detail (
    sale_invoice_id	INT NOT NULL,
    product_batch_id INT NOT NULL,
    unit_id INT NOT NULL,
    number INT DEFAULT 1,
    unit_price DECIMAL(10,0),
    CONSTRAINT pk_sale_detail PRIMARY KEY(sale_invoice_id, product_batch_id),
    CONSTRAINT fk_detail_sale FOREIGN KEY (sale_invoice_id) REFERENCES sale_invoice(id),
    CONSTRAINT fk_sale_batch FOREIGN KEY (product_batch_id) REFERENCES product_batch(id),
    CONSTRAINT fk_sale_unit FOREIGN KEY (unit_id) REFERENCES unit(id)
);						

-- -- -- -- -- TRIGGERS -- -- -- -- --
-- tu sinh ma hoa don 
-- tu tao product AFTER INSERT product_info
-- tu cap nhat gia ban chan = nhap * (1+rate), le = round(chan / unit.number_each_unit)
-- ngày trả nợ mặc định: Ngày 1 của tháng tiếp theo 





