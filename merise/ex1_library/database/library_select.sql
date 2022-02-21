USE db_library;

SELECT * FROM Books

SELECT * 
FROM Books
INNER JOIN States
	ON Books.book_state_id = States.state_id;

SELECT 
book_isbn,
book_title,
writer_firstname,
writer_lastname,
state_condition,
book_purchasedate
FROM Books, States, Writers
	WHERE Books.book_state_id = States.state_id AND Books.book_writer_id = Writers.writer_id;

SELECT 
book_isbn,
book_title,
writer_firstname,
writer_lastname,
publisher_name,
state_condition,
book_purchasedate,
collection_point_name
FROM Books
	INNER JOIN States 
		ON Books.book_state_id = States.state_id
	INNER JOIN Writers
		ON Books.book_writer_id = Writers.writer_id
	INNER JOIN Publishers
		ON Books.book_publisher_id = Publishers.publisher_id
	INNER JOIN Collection_points
		ON Books.book_collection_point_id = Collection_points.collection_point_id
WHERE writer_lastname = 'King';