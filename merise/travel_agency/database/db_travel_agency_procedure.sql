USE db_travel_agency;
GO

-- Add a client
CREATE OR ALTER PROCEDURE Add_Client
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
CREATE OR ALTER PROCEDURE Add_Trip
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
	IF NOT EXISTS (SELECT * FROM Trips WHERE trip_title = @trip_title AND trip_start = @trip_start)
	BEGIN
		INSERT INTO Trips VALUES 
			(@trip_title, @trip_available, @trip_start, @trip_end, @trip_price, @trip_overview, @trip_description, @city_code_start_end)
		PRINT('Inserted !')
	END
	ELSE
	BEGIN
		PRINT('Not inserted !')
	END
END
GO

-- EXEC Add_Trip 'NewToto', 100, '2020-05-01T12:20:00', '2020-05-08T12:20:00', 899, 'Découvrez tous les site les plus fantasique du Marrakech.', NULL, 5

SELECT * FROM Trips
GO
-- update of a single field 
CREATE OR ALTER PROCEDURE Update_Client
	@client_id INT,
	@field_to_update VARCHAR(max),
	@data_to_update VARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
	IF (EXISTS (SELECT client_id FROM Clients WHERE client_id = @client_id))
	BEGIN
		IF (@field_to_update = 'client_lastname')
		BEGIN
			UPDATE Clients
			SET client_lastname = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_lastname !')
		END
		IF (@field_to_update = 'client_firstname')
		BEGIN
			UPDATE Clients
			SET client_firstname = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_firstname !')
		END
		IF (@field_to_update = 'client_email')
		BEGIN
			UPDATE Clients
			SET client_email = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_email !')
		END
		IF (@field_to_update = 'client_phone')
		BEGIN
			UPDATE Clients
			SET client_phone = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_phone !')
		END
		IF (@field_to_update = 'client_password')
		BEGIN
			UPDATE Clients
			SET client_password = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_password !')
		END
		IF (@field_to_update = 'client_com_code')
		BEGIN
			UPDATE Clients
			SET client_com_code = @data_to_update
			WHERE client_id = @client_id
		PRINT('Updated client_com_code !')
		END
	END
	ELSE
		PRINT('Not updated !')
END
GO

CREATE OR ALTER PROCEDURE All_Update_Client
	@client_id INT,
	@client_lastname VARCHAR(32),
	@client_firstname VARCHAR(32),
	@client_email VARCHAR(128),
	@client_phone VARCHAR(16),
	@client_added DATE,
	@client_password VARCHAR(60),
	@client_com_code INT NOT NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (EXISTS (SELECT client_id FROM Clients WHERE client_id = @client_id))
	BEGIN
		UPDATE Clients
			SET client_lastname = @client_lastname,
				client_firstname = @client_firstname,
				client_email = @client_email,
				client_phone = @client_phone,
				client_added = @client_added,
				client_password = @client_password,
				client_com_code = @client_com_code
		WHERE client_id = @client_id
		PRINT('Updated !')
	END
	ELSE
		PRINT('Not updated !')
END
GO



EXEC Update_Client 1, 'client_firstname', 'Jean'

SELECT * FROM Clients