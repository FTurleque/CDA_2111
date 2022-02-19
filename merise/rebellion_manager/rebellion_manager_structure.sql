CREATE DATABASE db_rebellion_manager;

GO

USE db_rebellion_manager;

CREATE TABLE Rebellions
(rebellion_leader_name VARCHAR(50) NOT NULL,
CONSTRAINT PK_rebellion_leader_name PRIMARY KEY (rebellion_leader_name));

CREATE TABLE States
(state_id INT NOT NULL IDENTITY(1,1),
state_name VARCHAR(50) NOT NULL,
CONSTRAINT PK_state_id PRIMARY KEY (state_id));

CREATE TABLE Actions_type
(action_id INT NOT NULL IDENTITY,
action_name VARCHAR(20),
CONSTRAINT PK_action_id PRIMARY KEY (action_id));

CREATE TABLE Ranks
(rank_id BIGINT NOT NULL IDENTITY(1,1),
rank_name VARCHAR(15) NOT NULL,
rank_star_number TINYINT,
CONSTRAINT PK_rank_id PRIMARY KEY (rank_id));

CREATE TABLE Jobs
(job_id BIGINT NOT NULL IDENTITY,
job_name VARCHAR(20) NOT NULL,
job_specialisation VARCHAR(25),
CONSTRAINT PK_job_id PRIMARY KEY (job_id));

CREATE TABLE Coordinates
(coordinate_date_time DATETIME NOT NULL,
coordinate_reference VARCHAR(20) NOT NULL,
coordintate GEOGRAPHY NOT NULL,
CONSTRAINT PK_coordinate_date_time PRIMARY KEY (coordinate_date_time));

CREATE TABLE Empires
(empire_name VARCHAR(50) NOT NULL,
empire_leader_name VARCHAR(50) NOT NULL,
rebellion_leader_name VARCHAR(50),
CONSTRAINT PK_empire_name PRIMARY KEY (empire_name),
CONSTRAINT FK_Rebellions_leader_name FOREIGN KEY (rebellion_leader_name) REFERENCES Rebellions (rebellion_leader_name));

CREATE TABLE Galaxies
(galaxy_code SMALLINT IDENTITY,
galaxy_name VARCHAR(30) NOT NULL,
coordinate_date_time DATETIME,
CONSTRAINT PK_galaxy_code PRIMARY KEY (galaxy_code),
CONSTRAINT FK_Galaxies_coordinate_date_time FOREIGN KEY (coordinate_date_time) REFERENCES Coordinates (coordinate_date_time));

CREATE TABLE Global_systems
(global_system_code INT NOT NULL IDENTITY(1,1),
global_system_star_name VARCHAR(50),
coordinate_date_time DATETIME,
galaxy_code SMALLINT NOT NULL,
CONSTRAINT PK_solar_system_code PRIMARY KEY (global_system_code),
CONSTRAINT FK_Solar_systems_coordinate_date_time FOREIGN KEY (coordinate_date_time) REFERENCES Coordinates (coordinate_date_time),
CONSTRAINT FK_Solar_systems_galaxy_code FOREIGN KEY (galaxy_code) REFERENCES Galaxies (galaxy_code));

CREATE TABLE Missions
(code_mission VARCHAR(50) NOT NULL,
mission_ship_required SMALLINT NOT NULL,
space_mission BIT NOT NULL,
space_craft_number_required TINYINT,
coordinate_date_time DATETIME,
action_id INT NOT NULL,
CONSTRAINT PK_code_mission PRIMARY KEY (code_mission),
CONSTRAINT FK_Missions_coodinate_date_time FOREIGN KEY (coordinate_date_time) REFERENCES Coordinates (coordinate_date_time),
CONSTRAINT FK_Missions_action_id FOREIGN KEY (action_id) REFERENCES Actions_type (action_id));

CREATE TABLE Celestial_objects
(celestial_object_code VARCHAR(20) NOT NULL,
celestial_object_type VARCHAR(10) NOT NULL,
celestial_object_name VARCHAR(24),
celestial_object_size INT NOT NULL,
celestial_object_mass INT NOT NULL,
celestial_object_submissions BIT NOT NULL,
coordinate_date_time DATETIME NOT NULL,
state_id INT NOT NULL,
rebellion_leader_name VARCHAR(50),
empire_name VARCHAR(50),
global_system_code INT NOT NULL,
code_mission VARCHAR(50),
CONSTRAINT PK_celestial_object_code PRIMARY KEY (celestial_object_code),
CONSTRAINT FK_Celestial_objects_coordinate_date_time FOREIGN KEY (coordinate_date_time) REFERENCES Coordinates (coordinate_date_time),
CONSTRAINT FK_Celestial_objects_state_id FOREIGN KEY (state_id) REFERENCES States (state_id),
CONSTRAINT FK_Celestial_objects_rebellion_leader_name FOREIGN KEY (rebellion_leader_name) REFERENCES Rebellions (rebellion_leader_name),
CONSTRAINT FK_Celestial_objects_empire_name FOREIGN KEY (empire_name) REFERENCES Empires (empire_name),
CONSTRAINT FK_Celestial_objects_global_system_code FOREIGN KEY (global_system_code) REFERENCES Global_systems (global_system_code),
CONSTRAINT FK_Celestial_objects_code_mission FOREIGN KEY (code_mission) REFERENCES Missions (code_mission));

CREATE TABLE Ships
(ship_code VARCHAR(10) NOT NULL,
ship_type VARCHAR(25), 
ship_action_radius BIGINT NOT NULL,
ship_pilot_number TINYINT NOT NULL,
ship_max_speed BIGINT NOT NULL,
ship_engine_type VARCHAR(25) NOT NULL,
ship_crew_min TINYINT NOT NULL,
ship_crew_max SMALLINT NOT NULL,
ship_code_1 VARCHAR(10),
empire_name VARCHAR(50),
coordinate_date_time DATETIME,
action_id INT NOT NULL,
code_mission VARCHAR(50),
state_id INT NOT NULL,
rebellion_leader_name VARCHAR(50),
CONSTRAINT PK_ship_code PRIMARY KEY (ship_code),
CONSTRAINT FK_Ships_ship_code_1 FOREIGN KEY (ship_code_1) REFERENCES Ships (ship_code),
CONSTRAINT FK_Ships_empire_name FOREIGN KEY (empire_name) REFERENCES Empires (empire_name),
CONSTRAINT FK_Ships_coordinate_date_time FOREIGN KEY (coordinate_date_time) REFERENCES Coordinates (coordinate_date_time),
CONSTRAINT FK_Ships_action_id FOREIGN KEY (action_id) REFERENCES Actions_type (action_id),
CONSTRAINT FK_Ships_code_mission FOREIGN KEY (code_mission) REFERENCES Missions (code_mission),
CONSTRAINT FK_Ships_state_id FOREIGN KEY (state_id) REFERENCES States (state_id),
CONSTRAINT FK_Ships_rebellion_leader_name FOREIGN KEY (rebellion_leader_name) REFERENCES Rebellions (rebellion_leader_name));

CREATE TABLE Crews
(crew_code INT NOT NULL,
ship_code VARCHAR(10),
CONSTRAINT PK_crew_code PRIMARY KEY (crew_code),
CONSTRAINT FK_Crews_ship_code FOREIGN KEY (ship_code) REFERENCES Ships (ship_code));

CREATE TABLE Persons
(person_matricule INT NOT NULL,
person_species VARCHAR(50) NOT NULL,
person_last_name VARCHAR(50) NOT NULL,
person_first_name VARCHAR(50) NOT NULL,
person_age SMALLINT NOT NULL,
empire_name VARCHAR(50),
rank_id BIGINT NOT NULL,
job_id BIGINT NOT NULL,
rebellion_leader_name VARCHAR(50),
crew_code INT,
CONSTRAINT PK_person_matricule PRIMARY KEY (person_matricule),
CONSTRAINT FK_Persons_empire_name FOREIGN KEY (empire_name) REFERENCES Empires (empire_name),
CONSTRAINT FK_Persons_rank_id FOREIGN KEY (rank_id) REFERENCES Ranks (rank_id),
CONSTRAINT FK_Persons_job_id FOREIGN KEY (job_id) REFERENCES Jobs (job_id),
CONSTRAINT FK_Persons_rebellion_leader_name FOREIGN KEY (rebellion_leader_name) REFERENCES Rebellions (rebellion_leader_name),
CONSTRAINT FK_Persons_crew_code FOREIGN KEY (crew_code) REFERENCES Crews (crew_code));

