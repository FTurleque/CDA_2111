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

CREATE OR ALTER PROCEDURE Update_Client
	@client_id INT,
	@field_to_update VARCHAR(10),
	@data_to_update VARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
	IF (EXISTS (SELECT client_id FROM Clients WHERE client_id = @client_id))
	BEGIN
		DECLARE @update_clients TABLE (
				client_lastname VARCHAR(32),
				client_firstname VARCHAR(32),
				client_email VARCHAR(128),
				client_phone VARCHAR(16),
				client_added DATE,
				client_password VARCHAR(60),
				client_com_code INT);

		UPDATE Clients
			SET client_firstname =
			(CASE 
				WHEN @field_to_update = client_lastname THEN @data_to_update
				WHEN @field_to_update = 'client_firstname' THEN @data_to_update
				WHEN @field_to_update = client_email THEN @data_to_update
				WHEN @field_to_update = client_phone THEN @data_to_update
				WHEN @field_to_update = client_password THEN @data_to_update
				WHEN @field_to_update = CAST(client_com_code AS VARCHAR) THEN @data_to_update
				END)
			OUTPUT deleted.client_firstname AS BeforeValue, @data_to_update AS AfterValue
			WHERE client_id = @client_id
		PRINT('Updated !')
	END
	ELSE
		PRINT('Not updated !')
END

EXEC Update_Client 1, 'client_firstname', 'Jean_Pierre'

SELECT * FROM Clients