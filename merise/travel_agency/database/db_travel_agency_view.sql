USE db_travel_agency;
GO

-- 2)	Sélectionner tous les clients (code et nom de son commercial inclus). 
CREATE VIEW Clients_Info
AS
SELECT client_id, client_firstname, client_lastname, client_email, client_phone, com_code, com_name
FROM Clients
	INNER JOIN Comercials
		ON client_com_code = Comercials.com_code;

-- 6)	Sélectionner toutes les réservations non payées (code et nom de client inclus).
CREATE VIEW Unpaid_Reservations
AS
SELECT Reserve.client_id, client_firstname, client_lastname, trip_title
FROM Reserve
	INNER JOIN Clients
		ON Clients.client_id = Reserve.client_id
	INNER JOIN Trips
		ON Reserve.trip_code = Trips.trip_code
WHERE Reserve.order_paid = 0;

-- 8)	Sélectionnez tous les voyages (nom de la ville, code pays et nom du pays inclus).
CREATE VIEW Trips_Info
AS
SELECT 
	Trips.trip_code AS Numero_Offre, 
	trip_title AS Titre, 
	CONCAT(city_name, ' ', country_code, ' ', country_name) AS Destination,
	DATEDIFF(DAY, trip_start, trip_end) AS Duree,
	CONCAT(trip_price, ' €') AS Tarif
FROM Transit
	INNER JOIN Trips
		ON Transit.trip_code = Trips.trip_code
	INNER JOIN Cities
		ON Transit.city_code = Cities.city_code
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code;

SELECT * FROM Clients_Info;
SELECT * FROM Unpaid_Reservations;
SELECT * FROM Trips_Info;