USE db_travel_agency;
GO

IF NOT EXISTS (SELECT * FROM Countries)
BEGIN
	INSERT INTO Countries (country_name, country_code)
	VALUES ('France','FR'),('Allemagne','DE'),('Belgique','BE'),('Italie','IT'),('Maroc','MA'),('Ukraine','UA'),('Écosse','GB')
END

IF NOT EXISTS (SELECT * FROM Cities)
BEGIN
	INSERT INTO Cities (city_name, city_country_code)
	VALUES ('Paris','FR'),('Mulhouse','FR'),('Rust','DE'),('Bruxelles','BE'),('Milan','IT'),('Rome','IT'),('Chernobyl','UA'),('Édimbourg','GB'), ('Marrakech', 'MA')
END

IF NOT EXISTS (SELECT * FROM Themes)
BEGIN
	INSERT INTO Themes (theme_name)
	VALUES ('Montagne'), ('Plage'), ('Soleil'), ('Sports d’hiver'), ('Sports nautiques'), ('Culture'), ('Gastronomique'), ('Aventure')
END

IF NOT EXISTS (SELECT * FROM Benefits)
BEGIN
	INSERT INTO Benefits (benefit_name, benefit_score)
	VALUES ('All inclusive', 5),('Service d’étage', 1),('Piscine', 2),('Piscine chauffée', 3),('Coach sportif', 5),('Pratique du golf', 4)
END

IF NOT EXISTS (SELECT * FROM Comercials)
BEGIN
	INSERT INTO Comercials (com_name, com_password, com_code_ramplace)
	VALUES	('NATHALIE', 'Xion@54zER', NULL),('JAMES', 'BonD07+?Edz', 5),('JANE', 'Doe@?DuajOI', NULL),
			('CARMEN', 'VyCtual!Lis', NULL),('LUCAS', 'Darwin31-MoI', NULL)
END

IF NOT EXISTS (SELECT * FROM Clients)
BEGIN
	INSERT INTO Clients (client_firstname, client_lastname, client_email, client_phone, client_password, client_added, client_com_code) VALUES 
	('Jean-Louis', 'Durant', 'jdurant@outlook.com', '+33 530651505', 'XXXXXXX', '2018-05-12', 1),
	('Lois', 'Layne', 'llayne@cfr.fr', '+33 265781845', 'xxxxxxxxx', '2018-08-30', 3),
	('Clarck', 'Kent', 'ckent@super.com', '+34 8654565', '.......', '2018-01-20', 4),
	('Barry', 'Allen', 'ballen@speed.de', '+49 465458765', '........', '2018-02-05', 2),
	('Bruce', 'Wayne', 'bwayne@man.bat', '+61 555625545', 'xxxxxxxxxx', '2018-03-01', 5)
END

IF NOT EXISTS (SELECT * FROM Trips)
BEGIN
	INSERT INTO Trips (trip_title, trip_available, trip_start, trip_end, trip_price, trip_overview, city_code_start_end) VALUES 
	('Séjour touristique', 100, '2019-05-01T12:20:00', '2019-05-08T12:20:00', 899, 'Découvrez tous les site les plus fantasique du Marrakech.', 5),
	('Séjour Gastronomique', 230, '2019-03-20T15:30:00', '2019-03-25T15:30:00', 399, 'Dégustez les bons petits plats régional de Mulhouse.', 1),
	('Voyage Aventure', 50, '2019-09-10T05:15:11', '2019-09-13T05:15:11', 1299, 'Pensez à prendre votre compteur Geiger ;)', 6),
	('Destination Vert-Bouteille', 300, '2019-08-20T09:45:31', '2019-08-26T09:45:31', 849, 'Pensez à ne pas trop lever le coude :D !!!!', 4),
	('Europa Park', 1500, '2019-03-20T08:10:00', '2019-03-22T08:10:00', 99, 'Attachez votre ceinture ca va décoller !!!!', 2)
END

IF NOT EXISTS (SELECT * FROM Transit)
BEGIN
	INSERT INTO Transit (city_code, trip_code, step_start, step_end)
	VALUES	(9, 1, '2019-05-02T00:20:00', '2019-05-08T00:20:00'),
			(2, 2, '2019-03-20T17:30:00', '2019-03-25T13:30:00'),
			(7, 3, '2019-09-10T10:15:11', '2019-09-13T00:15:11'),
			(8, 4, '2019-08-20T11:45:31', '2019-08-26T07:45:31'),
			(3, 5, '2019-03-20T10:10:00', '2019-03-22T06:10:00')
END

IF NOT EXISTS (SELECT * FROM Propose)
BEGIN
	INSERT INTO Propose (trip_code, theme_code)
	VALUES (1, 2),(1, 3),(2, 7),(3, 8),(3, 6),(4, 4),(5, 3),(5, 5),(5, 8)
END

IF NOT EXISTS (SELECT * FROM Provide)
BEGIN
	INSERT INTO Provide (trip_code, benefit_code)
	VALUES (1,2),(1,3),(2,6),(2,5),(3,1),(3,4),(4,5),(4,6),(5,3),(5,6)
END

IF NOT EXISTS (SELECT * FROM Reserve)
BEGIN
	INSERT INTO Reserve (client_id, trip_code, order_quantity, order_paid)
	VALUES (2,5,2,1),(3,5,5,1),(3,3,3,1),(4,1,5,DEFAULT)
END
