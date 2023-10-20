-- Active: 1695203080273@@127.0.0.1@3306@pharmacy
USE pharmacy;

INSERT INTO account (username,password,role) VALUES
    ('admin','123',1),
    ('staff','123',2),
    ('guest','123',3);
INSERT INTO staff (nickname,citizen_id_number,fullname,birthday,qualification,contact_number,account_id) VALUES
    ('Calcifer','080303007273','Trần Thụy Ái Nhân','2003-10-06','Đang học Đại học','0857288009',1),
    ('Chanh','080000000000','Nguyễn Vủ Quốc Lâm','2003-10-08','Đang học Đại học','0941545482',2),
    ('NLHN','080303000000','Ngô Lê Huệ Ngân','2003-02-17','Đang học Đại học','0869037600',3);
INSERT INTO customer (name,contact_number) VALUES
    ('Guest', ''),
    ('Duy Khang', '0358808913'),
    ('Kế Cường', '0336773026'),
    ('Lag', '0865674317'),
    ('Thư NT', '0368779041');
INSERT INTO country(name) VALUES  
    ('Unknown'),
    ('Việt Nam'),
	('Mỹ'),
    ('Trung Quốc'),
    ('Đức'),
    ('Nhật Bản'),
    ('Ireland'),
    ('Thụy Sĩ'),
    ('Pháp'),
    ('Ý'),
    ('Ấn Độ'),
    ('Bỉ'),
    ('Anh'),
    ('Tây Ban Nha'),
    ('Brazil'),
    ('Canada'),
    ('Hàn Quốc'),
    ('Hà Lan');
INSERT INTO active_ingredient (name) VALUES
    ('Amlodipin'),
    ('Acid Salicylic'),
    ('Amoxicillin'),
    ('Alpha Chymotrypsin'),
    ('Cetirizin'),
    ('Codein camphosulfonat'),
    ('Calcium'),
    ('Clorpheniramin'),
    ('Collagen'),
    ('Dextromethorphan'),
    ('Fexofenadin'),
    ('Ibuprofen'),
    ('Loperamid'),
    ('Metformin'),
    ('Metronidazole'),
    ('Omeprazole'),
    ('Paracetamol'),
    ('Salbutamol'),
    ('Vitamin C');
INSERT INTO category (name) VALUES
    ('Thuốc kê đơn'),
    ('Thuốc không kê đơn'),
    ('Thực phẩm chức năng'),
    ('Chăm sóc cá nhân'),
    ('Dụng cụ y tế'),
    ('Thiết bị y tế');
INSERT INTO manufacturer (name) VALUES
    ('Công ty TNHH Dược phẩm Hisamitsu Việt Nam');
INSERT INTO unit (name) VALUES
    ('viên 8mg'),
    ('gói 3g'),
    ('gói 10miếng'),
    ('ống 5ml'),
    ('ống 10ml'),
    ('miếng');
INSERT INTO unit (name,number_each_unit,subunit_id) VALUES
    ('hộp 60viên',30,1);
    ('hộp 2gói',30,3);
INSERT INTO product_info (code,name,category_id,manufacturer_id,expiry,unit_id,storage_condition,note) VALUES
    ('VD-22387-15','Salonpas',2,1,36,8,
    'Bảo quản nơi khô ráo, nhiệt độ 30 độ C, tránh ẩm ướt và ánh nắng trực tiếp. Đối với những miếng cao dán đã mở mà không dùng hết, nên bọc kín sản phẩm để tránh vi khuẩn xâm nhập. Không bảo quản thuốc trong phòng tắm hay ngăn đá để tránh ảnh hưởng đến chất lượng.',
    'Salonpas là thuốc có tác dụng giảm đau chống viêm các cơn đau vai, đau lưng, đau mỏi cơ, căng cơ, bong gân, bầm tím, đau răng, đau đầu... giúp bệnh nhân thư giãn. Chỉ dùng ngoài da. Không dùng lên vùng da bị tổn thương, vết thương hở.');
    