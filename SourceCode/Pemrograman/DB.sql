CREATE DATABASE toko;
GO

USE toko;
GO

CREATE TABLE barang (
  KODE VARCHAR(50) PRIMARY KEY,
  [NAME] VARCHAR(50),
  PRICE INT
);

INSERT INTO barang (KODE, [NAME], PRICE) VALUES
	('ITEM1', 'Beras', 500),
	('ITEM2', 'Gula', 10),
	('ITEM3', 'Garam', 100),
	('ITEM4', 'Minyak Goreng', 95),
	('ITEM5', 'Susu', 150);

CREATE TABLE order_detail (
  [No] INT,
  ORD_KODE VARCHAR(50),
  KODE VARCHAR(50),
  QTY INT
);

INSERT INTO order_detail ([No], ORD_KODE, KODE, QTY) VALUES
	(1, 'ORD1', 'ITEM3', 3),
	(2, 'ORD1', 'ITEM5', 6),
	(3, 'ORD1', 'ITEM4', 2),
	(4, 'ORD2', 'ITEM1', 1),
	(5, 'ORD3', 'ITEM3', 5),
	(6, 'ORD3', 'ITEM1', 2);

CREATE TABLE order_header (
  [No] INT,
  CUSTOMER VARCHAR(50),
  ORD_KODE VARCHAR(50),
  [DATE] DATE
);

INSERT INTO order_header ([No], CUSTOMER, ORD_KODE, [DATE]) VALUES
	(1, 'Andi', 'ORD1', '2020-03-25'),
	(2, 'Winda', 'ORD2', '2020-05-12'),
	(3, 'Iwan', 'ORD3', '2020-05-15');
