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
		PRINT('Probl�me dans les donn�es.')
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
		PRINT('Probl�me dans les donn�es.')
END
*/
SELECT * FROM Clients;