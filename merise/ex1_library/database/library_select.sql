USE db_library;

SELECT * FROM db_library.customers;

INSERT INTO customers
(
    customer_id, 
    customer_firstname, 
    customer_lastname, 
    customer_address, 
    customer_deposit, 
    customer_loans_date, 
    customer_loans_nb, 
    customer_loans_late
)
VALUES
