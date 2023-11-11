-- Active: 1695203080273@@127.0.0.1@3306@pharmacy
USE pharmacy;

INSERT INTO account (username,password,role) VALUE 
	('admin','123',0),
	('manager','123',1),
	('stocker','123',2),
	('seller','123',3);

INSERT INTO staff (nickname,citizen_id_number,fullname,birthday,qualification,contact_number) VALUES
    ('Calcifer','003121410361','Trần Thụy Ái Nhân','2003-10-06','Đang học Đại học','0857288009'),
    ('Chanh','003121410292','Nguyễn Vủ Quốc Lâm','2003-10-08','Đang học Đại học','0941545482'),
    ('NLHN','003121410339','Ngô Lê Huệ Ngân','2003-02-17','Đang học Đại học','0869037600');

CALL insert_account(1,1);
CALL insert_account(2,3);
CALL insert_account(3,2);

INSERT INTO customer (name,contact_number) VALUES
    ('Guest', ''),
    ('Duy Khang', '0358808913'),
    ('Kế Cường', '0336773026'),
    ('Lag', '0865674317'),
    ('Thư NT', '0368779041');

INSERT INTO `supplier`(`name`,`contact_number`,`address`) VALUES 
	('Công ty TNHH Mediphar USA','0903850866','Xã Đức Hòa Hạ, Huyện Đức Hòa, Tỉnh Long An'),
    ('Công ty cổ phần Traphaco','18006612','75 Yên Ninh, Ba Đình, Hà Nội'),
    ('Công ty cổ phần dược Hậu Giang','02923891433','288 Bis Nguyễn Văn Cừ, P. An Hòa, Q. Ninh Kiều, TP Cần Thơ'),
    ('Công ty cổ phần dược phẩm Hà Tây','0433522525','10A Quang Trung, Hà Đông, Hà Nội'),
    ('Công ty cổ phần hóa dược phẩm Mekophar','02838650258','297/5 Lý Thường Kiệt, Quận 11, Tp Hồ Chí Minh');

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

INSERT INTO substance(name) VALUES
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

INSERT INTO product (barcode,name,category_id, current_import_price,unit,saleprice, retail_unit,retail_saleprice, extra_information) VALUES
    ('VD-22387-15','Salonpas',2,'20000','Hộp','25000', 'Miếng','1500',
    'Hoạt chất: Methyl salicylate 6,29%, L- Menthol 5,71%, dL – Camphor 1,24 %, Tocopherol acetate 2,00% ...
	Công dụng: Dùng giảm đau , kháng viêm trong các cơn đau Đối tượng sử dụng: Người lớn và trẻ em trên 12 tuổi.
	Hình thức: Cao dán ngoài da.
	Thương hiệu: Hisamitsu Pharmaceutical.
	Nơi sản xuất: Công ty cổ phần dược phẩm Dược Phẩm Hisamitsu (Việt Nam).');

INSERT INTO import_invoice(staff_id, supplier_id) VALUES (1,3);
INSERT INTO import_detail(import_invoice_id, product_id, barcode, name, mfg_date, exp_date, unit, number, import_price) VALUES 
	(1,1,'VD-22387-15','Salonpas','2023-01-07','2026-01-07','Hộp',100,'18000');
CALL export_for_retail(1,5,20);

INSERT INTO sale_invoice(staff_id,customer_id,point) VALUES (2,1,10);
INSERT INTO sale_detail(sale_invoice_id,product_id,name,unit,unit_price,number) VALUES 
	(1,1,'Salonpas','Hộp',25000,4);
