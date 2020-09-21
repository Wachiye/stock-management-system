CREATE DATABASE stock;

USE stock;

CREATE TABLE users(
	user_id int(8) primary key,
	username varchar(30) not null,
	email varchar(100) not null unique,
	password char(64) not null,
	user_level varchar(15) not null default 'System User'
);

CREATE TABLE products(
	product_id varchar(8) primary key,
	product_name varchar(30) not null,
	description varchar(255),
	date_purchased varchar(11),
	stock_purchased int not null,
	stock_available int,
	purchase_price double(18,2),
	selling_price double(18,2)
);

CREATE TABLE suppliers(
	supplier_id int(8) primary key,
	first_name varchar(15) not null,
	last_name varchar(15) not null,
	email varchar(100),
	phone_number varchar(14) not null,
	other_number varchar(14) not null,
	products varchar(255)
);

CREATE TABLE addresses(
	user_id int primary key,
	street_name varchar(15),
	house_number int,
	postal_code varchar(15),
	region varchar(15),
	state varchar(15)
);

CREATE TABLE orders(
	order_id varchar(8) primary key,
	items int,
	supplier int,
	date_created varchar(11),
	username varchar(30),
	mode_of_payment varchar(100),
	order_status varchar(30)
);

CREATE TABLE order_items(
	order_id varchar(8),
	item_id varchar(8),
	item_name varchar(30),
	description varchar(255),
	quantity int(8)
);

CREATE TABLE purchases(
	purchase_id int(8) primary key auto_increment,
	order_id varchar(8),
	purchase_date varchar(11),
	items_paid_for int,
	total_amount double(18,2)
);

CREATE TABLE sales(
	sale_id int primary key auto_increment,
	product_id varchar(8),
	price double(18,2),
	quantity int(8),
	total_amount double(18,2),
	sale_date varchar(11)
);