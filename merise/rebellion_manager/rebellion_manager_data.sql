USE db_rebellion_manager;

GO

INSERT INTO Rebellions (rebellion_leader_name)
VALUES ('Bushbé')

INSERT INTO States (state_name)
VALUES ('Acide'), ('Basique'), ('Neutre')

INSERT INTO Actions_type (action_name)
VALUES ('Interception'), ('Défense'), ('Combat'), ('Transport'), ('Espionnage'), ('Exploration')

INSERT INTO Ranks (rank_name, rank_star_number) -- rank_star_number Facultatif a vérifier où l'intégrer
VALUES ('Amiral'), ('Capitaine'), ('Commander'), ('Officier'), ('Officier Chef')

INSERT INTO Jobs (job_name, job_specialisation) -- job_specialisation Facultatif a vérifier où l'intégrer
VALUES	('Médecin'), ('Pilote'), ('Espion'), ('Scientifique'), ('Ingégnieur'), ('Sécurité'), 
		('Communication'), ('Xenolinguistique'), ('Fantassin'), ('Dirigeant')

INSERT INTO Empires (empire_name, empire_leader_name)
VALUES	('Klingon', 'Kahless'), ('Romuliens', 'Hiren'), ('Starfleet', 'J.Archer'), ('Merise', 'Impératrice'),
		('Vulcain', 'Spok'), ('Terrien', 'Maconcon')

INSERT INTO Galaxies (galaxy_name)
VALUES ('La voie lactée'), ('Pégase'), ('Sygnus')

INSERT INTO Global_systems (global_system_star_name, galaxy_code)
VALUES	('Aldébaran', 2), ('Soleil', 1), ('Copernic', 1), ('Cervantes', 3), ('Lich', 2), ('Titawin', 1), ('Sirius', 2), 
		('Polaris', 3), ('Gomeïsa', 2), ('Astérope', 3), ('Icarus', 1)

INSERT INTO Celestial_objects (celestial_object_code, celestial_object_type, celestial_object_size, celestial_object_mass, celestial_object_submissions)
VALUES

/*
INSERT INTO Actions_type (action_id, action_name) 
VALUES (1, 'Interception'),(2, 'Défense'), (3, 'Combat'), (4, 'Transport'), (5, 'Espionnage'),(6, 'Exploration')

INSERT INTO Jobs (job_id, job_name)
VALUES (1, 'Médecin'), (2, 'Pilote'),(3, 'Espion'),(4, 'Scientifique'), (5, 'Communication'), (6, 'Xenolinguistique'), (7, 'Infirmier'), (8, 'fantassin'), (9, 'Dirigeant')

INSERT INTO Jobs (job_id, job_name, job_specialisation)
VALUES (1, 'Médecin', NULL), (2, 'Pilote', 'Space-Craft')
*/