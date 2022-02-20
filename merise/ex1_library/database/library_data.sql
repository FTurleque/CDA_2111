USE db_library;

INSERT INTO Customers (customer_firstname, customer_lastname, customer_street_nb, customer_street, customer_postal_code, customer_city, customer_deposit)
VALUES	('Fabrice', 'Turleque', 10, 'Chemin du petit pont', 69200, 'Mulhouse', 100),
		('Nicholas', 'Dupuis', 200, 'Boulevard des nations', 69200, 'Mulhouse', 100),
		('Gabrielle', 'Alonso', 4, 'Place général DE Gaulle', 69100, 'Mulhouse', 100),
		('Galahad', 'Bornad', 250, 'Rue de Camelot', 69150, 'Mulhouse', 100),
		('Jim', 'Kurk', 1, 'Chemin de l Enterprise', 69200, 'Mulhouse', 100),
		('Lorenzo', 'Lamas', 150, 'Boulevard de Belcourt', 69050, 'Mulhouse', 100),
		('Duncan', 'McLeod', 19, 'Place du chavalier sans tête', 69100, 'Mulhouse', 100),
		('Conor', 'McLeod', 50, 'Rue de Grande Bretagne', 69150, 'Mulhouse', 100)

INSERT INTO Collection_points (collection_point_name)
VALUES ('Onion'), ('Gaston'), ('Primarium'), ('Gargamel'), ('Veritas')

INSERT INTO States (state_condition)
VALUES ('Très mauvais'), ('Mauvais'), ('Passable'), ('Bon'), ('Très bon'), ('Comme neuf'), ('Neuf')

INSERT INTO Writers (writer_firstname, writer_lastname)
VALUES ('Stephen', 'King'), ('Frank', 'Herbert'), ('J.K.', 'Rowling'), ('Stephenie', 'Meyer'), ('William', 'Shakespeare')

INSERT INTO Publishers (publisher_name)
VALUES ('Gallimard'), ('Albin Michel'), ('Livre de poche'), ('J ais lu')

INSERT INTO Books (book_isbn, book_title, writer_id, publisher_id, state_id, collection_point_id, book_purchasedate)
VALUES	('7895SK', 'Carrie', 1, 1, 5, 2, '2022-09-15'), ('654SK', 'Cujo', 1, 2, 4, 1, '2000-10-01'), ('664SK', 'Le Fléau', 1, 2, 6, 3, '1999-05-21'),
		('785FH', 'Dune', 2, 4, 7, 5, '2002-02-22'), ('624FH', 'Cujo', 2, 3, 1, 1, '2007-12-07'), ('664SK', 'Le Fléau', 2, 4, 2, 3, '1989-07-30'),
		('5548JKR', 'Harry Potter 1', 3, 2, 4, 2, '2022-09-15'), ('8524JKR', 'Harry Potter 2', 3, 2, 5, 1, '2000-10-01'), ('1234JKR', 'Harry Potter 7', 3, 2, 7, 3, '1999-05-21'),
		('548SM', 'Twilight 1', 4, 1, 4, 4, '2004-02-18'), ('824SM', 'Twilight 2', 4, 2, 5, 1, '2017-12-25'), ('657SM', 'Twilight 5', 4, 4, 4, 5, '2008-06-21')



SELECT * FROM Books;

/*
INSERT INTO Publishers (publisher_name)
VALUES
*/
