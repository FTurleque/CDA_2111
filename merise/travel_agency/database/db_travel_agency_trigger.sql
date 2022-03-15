USE db_travel_agency;
GO

CREATE TRIGGER Ajouter_client
ON Clients
FOR INSERT
AS
BEGIN
	SET NOCOUNT ON

	IF (NOT EXISTS (SELECT Clients.client_email 
					FROM Clients, inserted 
					WHERE Clients.client_email = inserted.client_email) 
					AND ((SELECT inserted.client_email FROM inserted) LIKE '%@%.%') 
					AND ((SELECT inserted.client_added FROM inserted) < GETDATE()))
	BEGIN
		INSERT INTO Clients
		SELECT	client_firstname, client_lastname, client_email, client_phone, client_added, client_password, client_com_code
		FROM inserted
	END
	ELSE 
	BEGIN
		ROLLBACK TRANSACTION
		PRINT('Problème dans les données.')
	END
END
/*
CREATE TRIGGER Ajouter_client
ON Clients
FOR INSERT
AS
BEGIN
	SET NOCOUNT ON

	IF (NOT EXISTS (SELECT Clients.client_email 
					FROM Clients, inserted 
					WHERE Clients.client_email = inserted.client_email) 
					AND ((SELECT inserted.client_email FROM inserted) LIKE '%@%.%') 
					AND ((SELECT inserted.client_added FROM inserted) < GETDATE()))
		INSERT INTO Clients
		SELECT	client_firstname, client_lastname, client_email, client_phone, client_added, client_password, client_com_code
		FROM inserted
	ELSE 
		ROLLBACK TRANSACTION
		PRINT('Problème dans les données.')
END
*/
SELECT * FROM Clients;
GO

-- Add a client
CREATE PROCEDURE Add_Client
	@client_lastname VARCHAR(32),
	@client_firstname VARCHAR(32),
	@client_email VARCHAR(128),
	@client_phone VARCHAR(16),
	@client_added DATE,
	@client_password VARCHAR(60),
	@client_com_code INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Clients VALUES 
		(@client_lastname, @client_firstname, @client_email, @client_phone, @client_added, @client_password, @client_com_code)
END
GO

-- Add a trip
CREATE PROCEDURE Add_Trip
	@trip_title VARCHAR(128),
	@trip_available INT,
	@trip_start DATETIME,
	@trip_end DATETIME,
	@trip_price SMALLMONEY,
	@trip_overview VARCHAR(max),
	@trip_description VARCHAR(max),
	@city_code_start_end INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Clients VALUES 
		(@trip_title, @trip_available, @trip_start, @trip_end, @trip_price, @trip_overview, @city_code_start_end)
END
GO

CREATE PROCEDURE Update_Client
	@client_id INT,
	@field_to_update VARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @client_lastname VARCHAR(32),
			@client_firstname VARCHAR(32),
			@client_email VARCHAR(128),
			@client_phone VARCHAR(16),
			@client_added DATE,
			@client_password VARCHAR(60),
			@client_com_code INT
	-- IF (@field_to_update = (SELECT client_lastname FROM Clients WHERE client_id = @client_id)
	BEGIN
	UPDATE Clients
		SET client_lastname = @client_lastname,
			client_firstname = @client_firstname,
			client_email = @client_email,
			client_phone = @client_phone,
			client_added = @client_added,
			client_password = @client_password,
			client_com_code = @client_com_code
	WHERE client_id = @client_id;
END

EXEC Add_Client 'Fab', 'TU', 'ftu@gmail.com', '0665445494',  '2021-06-12', 'eeeeeee', 2

SELECT * FROM Clients