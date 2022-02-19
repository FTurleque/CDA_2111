CREATE DATABASE db_horses_care;

GO

USE db_horses_care;

CREATE TABLE Horses
(horse_registration_id INT NOT NULL,
horse_birthday DATE NOT NULL,
horse_breed VARCHAR(20),
horse_primary_color VARCHAR(10) NOT NULL,
horse_gender VARCHAR(1) NOT NULL,
horse_birth_location VARCHAR(20) NOT NULL,
CONSTRAINT PK_horse_registration_id PRIMARY KEY (horse_registration_id));

CREATE TABLE People
(person_id INT NOT NULL,
person_lastname VARCHAR(12) NOT NULL,
person_firstname VARCHAR(32),
person_street VARCHAR(255) NOT NULL,
person_city VARCHAR(32),
person_zipcode VARCHAR(5) NOT NULL,
CONSTRAINT PK_person_id PRIMARY KEY (person_id));

CREATE TABLE Care
(horse_registration_id INT NOT NULL,
person_id INT NOT NULL,
activity_name VARCHAR(50) NOT NULL,
activity_date DATE NOT NULL,
CONSTRAINT PK_care PRIMARY KEY (horse_registration_id, person_id));

CREATE TABLE Companies
(company_siren VARCHAR(2) NOT NULL,
company_name VARCHAR(24) NOT NULL,
person_id INT NOT NULL,
CONSTRAINT PK_company_siren PRIMARY KEY (company_siren),
CONSTRAINT FK_People_person_id FOREIGN KEY (person_id) REFERENCES People (person_id));

