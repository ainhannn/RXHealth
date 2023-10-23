-- Active: 1695203080273@@127.0.0.1@3306@pharmacy
USE pharmacy;
DELIMITER //
-- -- -- -- -- PROCEDURES -- -- -- -- --
CREATE PROCEDURE staff_insert_account(staff_id INT, role_number INT)
BEGIN
    DECLARE user VARCHAR(16);
    DECLARE pass VARCHAR(16);
    DECLARE acc_id VARCHAR(16);
    
    SELECT citizen_id_number INTO user
    FROM staff WHERE staff.id=staff_id;
    
    SELECT DATE_FORMAT(birthday,"%d%m%Y") INTO pass
    FROM staff WHERE staff.id=staff_id;
    
    INSERT INTO account(username,password,role)
    VALUES (user, pass, role_number);
    
    SELECT account.id INTO acc_id
    FROM account WHERE username=user AND password=pass;

    UPDATE staff
    SET account_id=acc_id
    WHERE staff.id=staff_id;
END//

-- Các thủ tục không thể được sử dụng trong câu lệnh SELECT trong khi hàm có thể được nhúng trong câu lệnh SELECT. Bởi vì một thủ tục có thể trả về nhiều tập kết quả nên nó không phù hợp để sử dụng trong câu lệnh SELECT.
-- Các thủ tục lưu trữ không thể được sử dụng trong các câu lệnh WHERE / HAVING / SELECT trong khi hàm thì có thể.
-- Một ngoại lệ có thể được xử lý bằng try-catch trong thủ tục lưu trữ, đối với hàm thì không thể.
-- Có thể sử dụng Transactions trong thủ tục lưu trữ, với hàm thì không thể.

-- thay doi product.rate default 
-- tinh so luong sp can date 
DELIMITER;