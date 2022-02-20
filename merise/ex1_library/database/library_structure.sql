CREATE DATABASE db_library;

USE db_library;

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

CREATE TABLE States
(state_id INT NOT NULL IDENTITY,
state_condition VARCHAR(30),
CONSTRAINT PK_state_id PRIMARY KEY (state_id));

CREATE TABLE Collection_points
(collection_point_id INT NOT NULL IDENTITY,
collection_point_name VARCHAR(50),
CONSTRAINT PK_collection_point_id PRIMARY KEY (collection_point_id));

CREATE TABLE Writers
(writer_id INT NOT NULL IDENTITY,
writer_firstname VARCHAR(50) NOT NULL,
writer_lastname VARCHAR(50) NOT NULL,
CONSTRAINT PK_writer_id PRIMARY KEY (writer_id));

CREATE TABLE Publishers
(publisher_id INT NOT NULL IDENTITY,
publisher_name VARCHAR(50) NOT NULL,
CONSTRAINT PK_publisher_id PRIMARY KEY (publisher_id));

CREATE TABLE Borrows
(borrow_id INT NOT NULL IDENTITY,
borrow_date DATE NOT NULL,
borrow_late BIT NOT NULL,
borrow_number TINYINT NOT NULL,
customer_id INT,
CONSTRAINT PK_borrow_id PRIMARY KEY (borrow_id),
CONSTRAINT FK_Borrows_customer_id FOREIGN KEY (customer_id) REFERENCES CUstomers (customer_id));

CREATE TABLE Books
(book_isbn VARCHAR(50) NOT NULL,
book_title VARCHAR(64) NOT NULL,
book_purchasedate DATE NOT NULL,
state_id INT NOT NULL,
writer_id INT NOT NULL,
publisher_id INT NOT NULL,
collection_point_id INT NOT NULL,
borrow_id INT,
CONSTRAINT PK_book_isbn PRIMARY KEY (book_isbn),
CONSTRAINT FK_Books_state_id FOREIGN KEY (state_id) REFERENCES States (state_id),
CONSTRAINT FK_Books_author_firstname FOREIGN KEY (writer_id) REFERENCES Writers (writer_id),
CONSTRAINT FK_Book_publisher_id FOREIGN KEY (publisher_id) REFERENCES Publishers (publisher_id),
CONSTRAINT FK_Books_collection_point_id FOREIGN KEY (collection_point_id) REFERENCES Collection_points (collection_point_id),
CONSTRAINT FK_Books_borrow_id FOREIGN KEY (borrow_id) REFERENCES Borrows (borrow_id));
