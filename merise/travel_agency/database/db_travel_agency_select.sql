USE db_travel_agency;
GO

-- 1)	Afficher les informations de toutes les villes (informations du pays incluses).
SELECT city_name, country_name, country_code
FROM Cities
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code;

-- 2)	S�lectionner tous les clients (code et nom de son commercial inclus). 
-- Voir comment r�cup�rer le nom du commercial quand il est remplac�
SELECT client_id, client_firstname, client_lastname, client_email, client_phone, com_code, com_name
FROM Clients
	INNER JOIN Comercials
		ON client_com_code = Comercials.com_code;
--WHERE com_code = ALL (SELECT CASE WHEN com_code_ramplace = NULL THEN com_code_ramplace ELSE com_code END AS com_code FROM Comercials)

-- 3)	S�lectionner le client n�3 (code et nom du commercial associ� inclus).
-- Voir comment r�cup�rer le nom du commercial quand il est remplac�
SELECT client_id, client_firstname, client_lastname, client_email, client_phone, com_code, com_name
FROM Clients
	INNER JOIN Comercials
		ON client_com_code = Comercials.com_code
WHERE client_id =3;

-- 4)	S�lectionner tous les clients ayant r�serv� au moins un voyage (le nombre de voyages r�serv�s inclus).
SELECT client_id, client_firstname, client_lastname, client_email, client_phone
FROM Clients
WHERE client_id IN (SELECT Reserve.client_id FROM Reserve GROUP BY client_id HAVING COUNT(client_id) > 0);

-- 5)	S�lectionner le dernier voyage du client n�3 (nom de la ville et du pays inclus).


-- 6)	S�lectionner toutes les r�servations non pay�es (code et nom de client inclus).
SELECT Reserve.client_id, client_firstname, client_lastname, trip_title
FROM Reserve
	INNER JOIN Clients
		ON Clients.client_id = Reserve.client_id
	INNER JOIN Trips
		ON Reserve.trip_code = Trips.trip_code
WHERE Reserve.order_paid = 0;

-- 7)	Afficher le total pay� par le client n�3 (pour chaque voyage : prix * nombre de places r�serv�es).
SELECT DISTINCT Trips.trip_code, trip_title, trip_price * Reserve.order_quantity AS Somme_total
FROM Reserve
	INNER JOIN Trips
		ON Reserve.trip_code = Trips.trip_code
WHERE Reserve.client_id = 3;

-- 8)	S�lectionnez tous les voyages (nom de la ville, code pays et nom du pays inclus).
SELECT 
	Trips.trip_code AS Numero_Offre, 
	trip_title AS Titre, 
	CONCAT(city_name, ' ', country_code, ' ', country_name) AS Destination,
	DATEDIFF(DAY, trip_start, trip_end) AS Duree,
	CONCAT(trip_price, ' �') AS Tarif
FROM Transit
	INNER JOIN Trips
		ON Transit.trip_code = Trips.trip_code
	INNER JOIN Cities
		ON Transit.city_code = Cities.city_code
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code
ORDER BY Numero_Offre;

-- 9)	S�lectionnez tous les voyages d�j� pass�s.
SELECT 
	Trips.trip_code AS Numero_Offre_Expiree, 
	trip_title AS Titre, 
	CONCAT(city_name, ' ', country_code, ' ', country_name) AS Destination,
	DATEDIFF(DAY, trip_start, trip_end) AS Duree,
	CONCAT(trip_price, ' �') AS Tarif
FROM Transit
	INNER JOIN Trips
		ON Transit.trip_code = Trips.trip_code
	INNER JOIN Cities
		ON Transit.city_code = Cities.city_code
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code
WHERE trip_end < GETDATE()
ORDER BY Numero_Offre_Expiree;

-- 10)	S�lectionnez les voyages au d�part de Mulhouse.
SELECT 
	Trips.trip_code AS Numero_Offre, 
	trip_title AS Titre, 
	CONCAT(city_name, ' ', country_code, ' ', country_name) AS Destination,
	DATEDIFF(DAY, trip_start, trip_end) AS Duree,
	CONCAT(trip_price, ' �') AS Tarif
FROM Transit
	INNER JOIN Trips
		ON Transit.trip_code = Trips.trip_code
	INNER JOIN Cities
		ON Transit.city_code = Cities.city_code
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code
WHERE Trips.city_code_start_end in (SELECT city_code FROM Cities WHERE city_name = 'Mulhouse')
ORDER BY Numero_Offre;

-- 11)	S�lectionnez les voyages � destination de Mulhouse.
SELECT 
	Trips.trip_code AS Numero_Offre, 
	trip_title AS Titre, 
	CONCAT(city_name, ' ', country_code, ' ', country_name) AS Destination,
	DATEDIFF(DAY, trip_start, trip_end) AS Duree,
	CONCAT(trip_price, ' �') AS Tarif
FROM Transit
	INNER JOIN Trips
		ON Transit.trip_code = Trips.trip_code
	INNER JOIN Cities
		ON Transit.city_code = Cities.city_code
	INNER JOIN Countries
		ON Cities.city_country_code = Countries.country_code
WHERE Transit.city_code in (SELECT city_code FROM Cities WHERE city_name = 'Mulhouse')
ORDER BY Numero_Offre;

-- 12)	S�lectionner tous les commerciaux.
SELECT * FROM Comercials;

-- 13)	S�lectionner le commercial n�4.
SELECT *
FROM Comercials 
WHERE com_code = 4;

-- 14)	S�lectionner le commercial li� au client n�2.
SELECT * 
FROM Comercials
WHERE com_code IN (SELECT client_com_code FROM Clients WHERE Clients.client_id = 2);


SELECT * FROM Cities;
SELECT * FROM Countries;
SELECT * FROM Themes;
SELECT * FROM Benefits;
SELECT * FROM Clients;
SELECT * FROM Trips;
SELECT * FROM Propose;
SELECT * FROM Provide;
SELECT * FROM Reserve;