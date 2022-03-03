IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_library')
BEGIN
CREATE DATABASE db_library;
END
GO

USE db_library;
GO

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Customers' AND xtype = 'U')
BEGIN
	CREATE TABLE Customers
	(customer_id INT NOT NULL IDENTITY,
	customer_firstname VARCHAR(50) NOT NULL,
	customer_lastname VARCHAR(50) NOT NULL,
	customer_street_nb INT NOT NULL,
	customer_street VARCHAR(255) NOT NULL,
	customer_postal_code INT NOT NULL,
	customer_city VARCHAR(50),
	customer_deposit INT NOT NULL,
	CONSTRAINT PK_customer_id PRIMARY KEY (customer_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'States' AND xtype = 'U')
BEGIN
	CREATE TABLE States
	(state_id INT NOT NULL IDENTITY,
	state_condition VARCHAR(30),
	CONSTRAINT PK_state_id PRIMARY KEY (state_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Collection_points' AND xtype = 'U')
BEGIN
	CREATE TABLE Collection_points
	(collection_point_id INT NOT NULL IDENTITY,
	collection_point_name VARCHAR(50),
	CONSTRAINT PK_collection_point_id PRIMARY KEY (collection_point_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Writers' AND xtype = 'U')
BEGIN
	CREATE TABLE Writers
	(writer_id INT NOT NULL IDENTITY,
	writer_firstname VARCHAR(50) NOT NULL,
	writer_lastname VARCHAR(50) NOT NULL,
	CONSTRAINT PK_writer_id PRIMARY KEY (writer_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Publishers' AND xtype = 'U')
BEGIN
	CREATE TABLE Publishers
	(publisher_id INT NOT NULL IDENTITY,
	publisher_name VARCHAR(50) NOT NULL,
	CONSTRAINT PK_publisher_id PRIMARY KEY (publisher_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Borrows' AND xtype = 'U')
BEGIN
	CREATE TABLE Borrows
	(borrow_id INT NOT NULL IDENTITY,
	borrow_date DATE NOT NULL,
	borrow_late BIT NOT NULL,
	borrow_number TINYINT NOT NULL,
	borrow_customer_id INT,
	CONSTRAINT PK_borrow_id PRIMARY KEY (borrow_id),
	CONSTRAINT FK_Borrows_customer_id FOREIGN KEY (borrow_customer_id) REFERENCES Customers (customer_id));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Books' AND xtype = 'U')
BEGIN
	CREATE TABLE Books
	(book_isbn VARCHAR(50) NOT NULL,
	book_title VARCHAR(64) NOT NULL,
	book_purchasedate DATE NOT NULL,
	book_state_id INT NOT NULL,
	book_writer_id INT NOT NULL,
	book_publisher_id INT NOT NULL,
	book_collection_point_id INT NOT NULL,
	book_borrow_id INT,
	CONSTRAINT PK_book_isbn PRIMARY KEY (book_isbn),
	CONSTRAINT FK_Books_state_id FOREIGN KEY (book_state_id) REFERENCES States (state_id),
	CONSTRAINT FK_Books_author_firstname FOREIGN KEY (book_writer_id) REFERENCES Writers (writer_id),
	CONSTRAINT FK_Book_publisher_id FOREIGN KEY (book_publisher_id) REFERENCES Publishers (publisher_id),
	CONSTRAINT FK_Books_collection_point_id FOREIGN KEY (book_collection_point_id) REFERENCES Collection_points (collection_point_id),
	CONSTRAINT FK_Books_borrow_id FOREIGN KEY (book_borrow_id) REFERENCES Borrows (borrow_id));
END
