USE db_avion_vide
GO

-- 1	Quels sont les vols au départ de Paris entre 12h et 14h ?
SELECT *
FROM Vol WHERE vd = 'Paris' AND hd >= 12 AND ha <= 14;

-- 2	Quels sont les pilotes dont le nom commence par "S" ?
SELECT *
FROM Pilote WHERE 'S' = SUBSTRING(pil_nom, 1, 1);

-- 3	Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent.
SELECT DISTINCT av_loc, COUNT(av) AS nb_avion, MIN(av_capacite) AS min_capacite, MAX(av_capacite) AS max_capacite
FROM Avion
GROUP BY av_loc;

-- 4	Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion.
SELECT av_loc, AVG(av_capacite) AS moyenne_capacite, av_type
FROM Avion
GROUP BY av_loc, av_type;

-- 5	Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ?
SELECT DISTINCT av_loc, AVG(av_capacite) AS moyenne_capacity
FROM Avion
GROUP BY av_loc
HAVING COUNT(av_loc) > 1;

-- 6	Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un Airbus 
SELECT pil_nom, pil_adresse
FROM Pilote
WHERE pil_adresse IN (SELECT av_loc FROM Avion WHERE av_marque = 'AIRBUS');

-- 7	Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ?
SELECT DISTINCT pil_nom
FROM Vol
	INNER JOIN Pilote
		ON Vol.pilote = Pilote.pil
WHERE Vol.avion IN (SELECT av FROM Avion WHERE av_marque = 'AIRBUS');

-- 8	Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?
SELECT DISTINCT pil_nom
FROM Vol
	INNER JOIN Pilote
		ON Vol.pilote = Pilote.pil
WHERE Vol.pilote IN (SELECT Pilote.pil FROM Pilote WHERE Pilote.pil_adresse <> ALL (SELECT Avion.av_loc FROM Avion WHERE av_marque = 'AIRBUS'));

-- 9	Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?
SELECT vol, vd, va
FROM Vol
WHERE	vd IN (SELECT vd FROM Vol INNER JOIN Pilote ON Vol.pilote = Pilote.pil WHERE Pilote.pil_nom = 'SERGE') AND 
		va IN (SELECT va FROM Vol INNER JOIN Pilote ON Vol.pilote = Pilote.pil WHERE Pilote.pil_nom = 'SERGE') AND 
		vol <> All (SELECT vol FROM Vol INNER JOIN Pilote ON Vol.pilote = Pilote.pil WHERE Pilote.pil_nom = 'SERGE');

-- 10	Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).
/*
SELECT P1.pil_nom, P2.pil_nom
FROM Pilote AS P1
	FULL JOIN Pilote  AS P2
		ON P1.pil_adresse = P2.pil_adresse
WHERE P1.pil_nom <> P2.pil_nom;
MAQUE A ENLEVER LES DOUBLONS
*/

-- 11	Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ?
SELECT pil_nom
FROM Vol
	INNER JOIN Pilote
		ON Vol.pilote = Pilote.pil
WHERE Vol.avion IN (SELECT avion FROM Vol WHERE pilote = 1) AND Pilote.pil <> 1; 

-- 12	Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée.


-- 13	Sélectionner les numéros des pilotes qui conduisent tous les Airbus ? Aucun vue que 2 Type
-- 13	Sélectionner les numéros des pilotes qui conduisent que des Airbus ?
SELECT DISTINCT pilote 
FROM Vol 
EXCEPT
SELECT pilote
FROM Vol
WHERE avion IN (SELECT av FROM Avion WHERE av_marque <> 'AIRBUS');
