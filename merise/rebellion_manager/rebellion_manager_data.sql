USE db_rebellion_manager;

GO

INSERT INTO Rebellions (rebellion_leader_name)
VALUES ('Bushb�')

INSERT INTO States (state_name)
VALUES ('Acide'), ('Basique'), ('Neutre')

INSERT INTO Actions_type (action_name)
VALUES ('Interception'), ('D�fense'), ('Combat'), ('Transport'), ('Espionnage'), ('Exploration')

INSERT INTO Ranks (rank_name, rank_star_number) -- rank_star_number Facultatif a v�rifier o� l'int�grer
VALUES ('Amiral'), ('Capitaine'), ('Commander'), ('Officier'), ('Officier Chef')

INSERT INTO Jobs (job_name, job_specialisation) -- job_specialisation Facultatif a v�rifier o� l'int�grer
VALUES	('M�decin'), ('Pilote'), ('Espion'), ('Scientifique'), ('Ing�gnieur'), ('S�curit�'), 
		('Communication'), ('Xenolinguistique'), ('Fantassin'), ('Dirigeant')

INSERT INTO Empires (empire_name, empire_leader_name)
VALUES	('Klingon', 'Kahless'), ('Romuliens', 'Hiren'), ('Starfleet', 'J.Archer'), ('Merise', 'Imp�ratrice'),
		('Vulcain', 'Spok'), ('Terrien', 'Maconcon')

INSERT INTO Galaxies (galaxy_name)
VALUES ('La voie lact�e'), ('P�gase'), ('Sygnus')

INSERT INTO Global_systems (global_system_star_name, galaxy_code)
VALUES	('Ald�baran', 2), ('Soleil', 1), ('Copernic', 1), ('Cervantes', 3), ('Lich', 2), ('Titawin', 1), ('Sirius', 2), 
		('Polaris', 3), ('Gome�sa', 2), ('Ast�rope', 3), ('Icarus', 1)

INSERT INTO Celestial_objects (celestial_object_code, celestial_object_type, celestial_object_size, celestial_object_mass, celestial_object_submissions)
VALUES

/*
INSERT INTO Actions_type (action_id, action_name) 
VALUES (1, 'Interception'),(2, 'D�fense'), (3, 'Combat'), (4, 'Transport'), (5, 'Espionnage'),(6, 'Exploration')

INSERT INTO Jobs (job_id, job_name)
VALUES (1, 'M�decin'), (2, 'Pilote'),(3, 'Espion'),(4, 'Scientifique'), (5, 'Communication'), (6, 'Xenolinguistique'), (7, 'Infirmier'), (8, 'fantassin'), (9, 'Dirigeant')

INSERT INTO Jobs (job_id, job_name, job_specialisation)
VALUES (1, 'M�decin', NULL), (2, 'Pilote', 'Space-Craft')
*/