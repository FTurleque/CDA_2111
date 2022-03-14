USE db_travel_agency;
GO

CREATE TRIGGER Ajouter_client
ON Clients
FOR INSERT
AS
DECLARE @ClientId INT
	SET @ClientId = (SELECT COUNT(*) FROM Clients)
BEGIN
	SET NOCOUNT ON

	DECLARE @LastName VARCHAR(32),
			@FirstName VARCHAR(32),
			@Email VARCHAR(128),
			@PhoneNumber VARCHAR(16),
			@ClientAdded DATE = GETDATE(),
			@Password VARCHAR(60),
			@ComClient INT

	IF (NOT EXISTS (SELECT * FROM Clients, inserted WHERE Clients.client_id = inserted.client_id))
		INSERT INTO Clients
		SELECT	*
		FROM inserted

END
GO

SELECT * FROM Clients;