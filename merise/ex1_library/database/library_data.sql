USE db_library;
GO

IF NOT EXISTS (SELECT * FROM Customers)
BEGIN
	INSERT INTO Customers (customer_firstname, customer_lastname, customer_street_nb, customer_street, customer_postal_code, customer_city, customer_deposit)
	VALUES	('Fabrice', 'Turleque', 10, 'Chemin du petit pont', 69200, 'Mulhouse', 100),
			('Nicholas', 'Dupuis', 200, 'Boulevard des nations', 69200, 'Mulhouse', 100),
			('Gabrielle', 'Alonso', 4, 'Place général DE Gaulle', 69100, 'Mulhouse', 100),
			('Galahad', 'Bornad', 250, 'Rue de Camelot', 69150, 'Mulhouse', 100),
			('Jim', 'Kurk', 1, 'Chemin de l Enterprise', 69200, 'Mulhouse', 100),
			('Lorenzo', 'Lamas', 150, 'Boulevard de Belcourt', 69050, 'Mulhouse', 100),
			('Duncan', 'McLeod', 19, 'Place du chavalier sans tête', 69100, 'Mulhouse', 100),
			('Conor', 'McLeod', 50, 'Rue de Grande Bretagne', 69150, 'Mulhouse', 100)
END

IF NOT EXISTS (SELECT * FROM Collection_points)
BEGIN
	INSERT INTO Collection_points (collection_point_name)
	VALUES ('Onion'), ('Gaston'), ('Primarium'), ('Gargamel'), ('Veritas')
END

IF NOT EXISTS (SELECT * FROM States)
BEGIN
	INSERT INTO States (state_condition)
	VALUES ('Très mauvais'), ('Mauvais'), ('Passable'), ('Bon'), ('Très bon'), ('Comme neuf'), ('Neuf')
END

IF NOT EXISTS (SELECT * FROM Writers)
BEGIN
	INSERT INTO Writers (writer_firstname, writer_lastname)
	VALUES ('Stephen', 'King'), ('Frank', 'Herbert'), ('J.K.', 'Rowling'), ('Stephenie', 'Meyer'), ('William', 'Shakespeare')
END

IF NOT EXISTS (SELECT * FROM Publishers)
BEGIN
	INSERT INTO Publishers (publisher_name)
	VALUES ('Gallimard'), ('Albin Michel'), ('Livre de poche'), ('J ais lu'), ('Jean-Claude Lattès'), ('Robert Laffont')
END

IF NOT EXISTS (SELECT * FROM Books)
BEGIN
	INSERT INTO Books (book_isbn, book_title, book_writer_id, book_publisher_id, book_state_id, book_collection_point_id, book_purchasedate)
	VALUES	
	('978-2070294305', 'Carrie', 1, 1, 3, 2, '2021-09-15'), 
	('978-2226014870', 'Cujo', 1, 2, 4, 1, '2000-10-01'), 
	('978-2709610209', 'Le Fléau', 1, 5, 6, 3, '1999-05-21'),
	('978-2226220585', 'Dôme ', 1, 2, 4, 5, '2005-04-01'),
	('2-221-02602-0', 'Dune', 2, 6, 4, 5, '2002-02-22'),
	('2-221-00775-1', 'L Empereur-Dieu de Dune', 2, 6, 4, 5, '1998-04-22'),
	('978-2226014870', 'Cujo', 1, 2, 1, 1, '2007-12-07'), 
	('978-2709610209', 'Le Fléau', 1, 2, 2, 2, '1989-07-30'),
	('2-07-051842-6', 'Harry Potter à l école des sorciers', 3, 1, 4, 2, '2021-09-15'), 
	('2-07-052455-8', 'Harry Potter et la Chambre des secrets', 3, 1, 5, 1, '2000-10-01'), 
	('978-2070615360', 'Harry Potter et les Reliques de la Mort', 3, 1, 5, 3, '2020-05-21'),
	('548SM', 'Tentation', 4, 1, 4, 4, '2004-02-18'), 
	('824SM', 'Twilight 2', 4, 2, 5, 1, '2017-12-25'), 
	('657SM', 'Twilight 5', 4, 4, 4, 5, '2008-06-21'),
	('978-2226014870', 'Cujo', 1, 2, 4, 4, '1982-05-13'),
	('978-2070294305', 'Carrie', 1, 1, 3, 5, '1976-04-23'),
	('978-2709610209', 'Le Fléau', 1, 5, 6, 4, '1991-04-01'),
	('978-2226220585', 'Dôme', 1, 5, 7, 4, '1991-04-01'),
	('978-2226033819', 'Running Man', 1, 5, 7, 5, '1987-05-21'),
	('2-221-02602-0', 'Dune', 2, 6, 3, 3, '1985-02-22'),
	('2-221-00775-1', 'L Empereur-Dieu de Dune', 2, 6, 7, 1, '1982-04-22'),
	('2-07-051842-6', 'Harry Potter à l école des sorciers', 3, 1, 7, 5, '1998-10-09'),
	('2-07-052455-8', 'Harry Potter et la Chambre des secrets', 3, 2, 7, 4, '1999-03-23'),
	('978-2070615360', 'Harry Potter et les Reliques de la Mort', 3, 1, 6, 3, '2008-10-21')
END

/*
SELECT * FROM Books;

INSERT INTO Publishers (publisher_name)
VALUES
*/
