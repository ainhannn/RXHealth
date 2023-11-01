-- Active: 1695203080273@@127.0.0.1@3306@pharmacy
USE pharmacy;
DELIMITER //
-- -- -- -- -- TRIGGERS -- -- -- -- --
-- CREATE TRIGGER password_hasher 
--         BEFORE INSERT ON ACCOUNT
--         FOR EACH ROW
-- BEGIN
--     SET NEW.password = MD5 (NEW.password);
-- END//
 
CREATE TRIGGER auto_product_local_code
        BEFORE INSERT ON product_batch 
        FOR EACH ROW
BEGIN
    DECLARE code VARCHAR(13);
    DECLARE pid VARCHAR(5);
    DECLARE timeid VARCHAR(6);
    DECLARE num INT;
       
    SELECT LPAD(id,5,0) INTO pid
    FROM product WHERE id = NEW.product_id;

    SELECT DATE_FORMAT(date_time,"%d%m%y") INTO timeid 
    FROM import_invoice WHERE id = NEW.import_invoice_id;

    SET code = CONCAT('P',pid,timeid,'%');
    SELECT COUNT(id) INTO num
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

CREATE TRIGGER auto_export_code
        BEFORE INSERT ON export_invoice 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'export_invoice' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('EX',LPAD(newid,5,0));
END//

CREATE TRIGGER auto_inventory_code
        BEFORE INSERT ON inventory_form 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'inventory_invoice' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('IN',LPAD(newid,5,0));
END//

CREATE TRIGGER auto_order_code
        BEFORE INSERT ON order_form 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'order_form' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('OR',LPAD(newid,5,0));
END//

CREATE TRIGGER auto_payment_code
        BEFORE INSERT ON payment_invoice 
        FOR EACH ROW
BEGIN
    DECLARE newid INT;

    SELECT auto_increment INTO newid
    FROM information_schema.tables 
    WHERE table_name = 'payment_invoice' AND table_schema = 'pharmacy';

    SET NEW.code = CONCAT('PA',LPAD(newid,5,0));
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


-- tu tao product AFTER INSERT product_info
-- tu cap nhat gia ban chan = nhap * (1+rate), le = round(chan / unit.number_each_unit)
-- ngày trả nợ mặc định: Ngày 1 của tháng tiếp theo 
DELIMITER ;