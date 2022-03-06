IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_avion_vide')
BEGIN
	CREATE DATABASE db_avion_vide;
END
GO

USE db_avion_vide
GO

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Avion' AND xtype = 'U')
BEGIN
	CREATE TABLE Avion
	(av INT NOT NULL IDENTITY(100, 1),
	av_marque VARCHAR(15) NOT NULL,
	av_type VARCHAR(15) NOT NULL,
	av_capacite INT NOT NULL,
	av_loc VARCHAR(15) NOT NULL,
	CONSTRAINT PK_Avion_av PRIMARY KEY (av));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Pilote' AND xtype = 'U')
BEGIN
	CREATE TABLE Pilote
	(pil INT NOT NULL IDENTITY,
	pil_nom VARCHAR(15) NOT NULL,
	pil_adresse VARCHAR(15) NOT NULL,
	CONSTRAINT PK_Pilote_pil PRIMARY KEY (pil));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Vol' AND xtype = 'U')
BEGIN
	CREATE TABLE Vol
	(vol VARCHAR(15) NOT NULL,
	avion INT NOT NULL,
	pilote INT NOT NULL,
	vd VARCHAR(15) NOT NULL,
	va VARCHAR(15) NOT NULL,
	hd INT NOT NULL,
	ha INT NOT NULL,
	CONSTRAINT PK_Vol PRIMARY KEY (vol),
	CONSTRAINT FK_Vol_avion FOREIGN KEY (avion) REFERENCES Avion (av),
	CONSTRAINT FK_Vol_pilote FOREIGN KEY (pilote) REFERENCES Pilote (pil));
END
