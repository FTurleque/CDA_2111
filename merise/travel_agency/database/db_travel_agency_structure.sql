IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_travel_agency')
BEGIN
	CREATE DATABASE db_travel_agency;
END
GO

USE db_travel_agency;
GO

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Countries' AND xtype='U')
BEGIN
	CREATE TABLE Countries
	(country_code VARCHAR(2) NOT NULL, -- Vérifier ISO 3166
	country_name VARCHAR(128) NOT NULL,
	CONSTRAINT PK_country_code PRIMARY KEY (country_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Cities' AND xtype='U')
BEGIN
	CREATE TABLE Cities
	(city_code INT NOT NULL IDENTITY,
	city_name VARCHAR(128) NOT NULL,
	city_country_code VARCHAR(2) NOT NULL,
	CONSTRAINT PK_city_code PRIMARY KEY (city_code),
	CONSTRAINT FK_Cities_city_country_code FOREIGN KEY (city_country_code) REFERENCES Countries (country_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Themes' AND xtype='U')
BEGIN
	CREATE TABLE Themes
	(theme_code INT NOT NULL IDENTITY,
	theme_name VARCHAR(32) NOT NULL,
	theme_description NVARCHAR(max),
	CONSTRAINT PK_theme_code PRIMARY KEY (theme_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Benefits' AND xtype='U')
BEGIN
	CREATE TABLE Benefits
	(benefit_code INT NOT NULL IDENTITY,
	benefit_name VARCHAR(32) NOT NULL,
	benefit_description NVARCHAR(max),
	benefit_score TINYINT NOT NULL CHECK(benefit_score >=0 AND benefit_score <=5),
	benefit_commentaire VARCHAR(255),
	CONSTRAINT PK_benefit_code PRIMARY KEY (benefit_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Trips' AND xtype='U')
BEGIN
	CREATE TABLE Trips
	(trip_code INT NOT NULL IDENTITY,
	trip_title VARCHAR(128) NOT NULL,
	trip_available INT NOT NULL CHECK(trip_available >= 0),
	trip_start DATETIME NOT NULL, -- « 2020-03-29 20:31:47 »
	trip_end DATETIME NOT NULL, -- [Y-M-D H:i:s]
	trip_price SMALLMONEY NOT NULL CHECK(trip_price > 0),
	trip_overview VARCHAR(max) NOT NULL,
	trip_description VARCHAR(max),
	city_code_start_end INT NOT NULL,
	CONSTRAINT PK_trip_code PRIMARY KEY (trip_code),
	CONSTRAINT FK_Trips_city_code FOREIGN KEY (city_code_start_end) REFERENCES Cities (city_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Propose' AND xtype='U')
BEGIN
	CREATE TABLE Propose
	(trip_code INT NOT NULL,
	theme_code INT NOT NULL,
	CONSTRAINT PK_Propose PRIMARY KEY (trip_code, theme_code),
	CONSTRAINT FK_Propose_trip_code FOREIGN KEY (trip_code) REFERENCES Trips (trip_code),
	CONSTRAINT FK_Propose_theme_code FOREIGN KEY (theme_code) REFERENCES Themes (theme_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Provide' AND xtype='U')
BEGIN
	CREATE TABLE Provide
	(trip_code INT NOT NULL,
	benefit_code INT NOT NULL,
	CONSTRAINT PK_Provide PRIMARY KEY (trip_code, benefit_code),
	CONSTRAINT FK_Provide_trip_code FOREIGN KEY (trip_code)  REFERENCES Trips (trip_code),
	CONSTRAINT FK_Provide_benefit_code FOREIGN KEY (benefit_code) REFERENCES Benefits (benefit_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Transit' AND xtype='U')
BEGIN
	CREATE TABLE Transit
	(city_code INT NOT NULL,
	trip_code INT NOT NULL,
	step_start DATETIME NOT NULL, -- [Y-M-D H:i:s]
	step_end DATETIME NOT NULL, -- [Y-M-D H:i:s]
	CONSTRAINT PK_Transit PRIMARY KEY (city_code, trip_code),
	CONSTRAINT FK_Transit_city_code FOREIGN KEY (city_code) REFERENCES Cities (city_code),
	CONSTRAINT FK_Transit_trip_code FOREIGN KEY (trip_code)  REFERENCES Trips (trip_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Comercials' AND xtype='U')
BEGIN
	CREATE TABLE Comercials
	(com_code INT NOT NULL IDENTITY,
	com_name VARCHAR(64) NOT NULL,
	com_password VARCHAR(60) NOT NULL, -- chiffré (BCRYPT)
	com_code_ramplace INT,
	CONSTRAINT PK_com_code PRIMARY KEY (com_code),
	CONSTRAINT FK_com_code_ramplace FOREIGN KEY (com_code_ramplace) REFERENCES Comercials (com_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Clients' AND xtype='U')
BEGIN
	CREATE TABLE Clients
	(client_id INT NOT NULL IDENTITY,
	client_lastname VARCHAR(32) NOT NULL,
	client_firstname VARCHAR(32) NOT NULL,
	client_email VARCHAR(128) NOT NULL UNIQUE, -- format email
	client_phone VARCHAR(16) NOT NULL,-- format international
	client_added DATE NOT NULL, --  [Y-M-D]
	client_password VARCHAR(60) NOT NULL, -- chiffré (BCRYPT)
	client_com_code INT NOT NULL,
	CONSTRAINT PK_client_id PRIMARY KEY (client_id),
	CONSTRAINT FK_Clients_com_code FOREIGN KEY (client_com_code) REFERENCES Comercials (com_code));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Reserve' AND xtype='U')
BEGIN
	CREATE TABLE Reserve
	(client_id INT NOT NULL,
	trip_code INT NOT NULL,
	order_quantity SMALLINT NOT NULL,
	order_paid BIT DEFAULT 0,
	CONSTRAINT PK_Reserve PRIMARY KEY (client_id, trip_code));
END
