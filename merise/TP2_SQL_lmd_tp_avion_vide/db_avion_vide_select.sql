USE db_avion_vide
GO

-- 1	Quels sont les vols au départ de Paris entre 12h et 14h ?
SELECT *
FROM Vols WHERE vd = 'Paris' AND hd >= 12 AND hd <= 14;

-- 2	Quels sont les pilotes dont le nom commence par "S" ?
SELECT *
FROM Pilotes WHERE 'S' = SUBSTRING(pil_nom, 1, 1);

-- 3	Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent.
SELECT DISTINCT av_loc, COUNT(av) AS nb_avion, MIN(av_capacite) AS min_capacite, MAX(av_capacite) AS max_capacite
FROM Avions
GROUP BY av_loc;

-- 4	Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion.
SELECT av_loc, AVG(av_capacite) AS moyenne_capacite, av_type
FROM Avions
GROUP BY av_loc, av_type;

-- 5	Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ?
SELECT DISTINCT av_loc, AVG(av_capacite) AS moyenne_capacity
FROM Avions
GROUP BY av_loc
HAVING COUNT(av_loc) > 1;

-- 6	Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un Airbus 
SELECT pil_nom, pil_adresse
FROM Pilotes
WHERE pil_adresse IN (SELECT av_loc FROM Avions WHERE av_marque = 'AIRBUS');

-- 7	Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ?
SELECT DISTINCT pil_nom
FROM Vols
	INNER JOIN Pilotes
		ON Vols.pilote = Pilotes.pil
WHERE Vols.avion IN (SELECT av FROM Avions WHERE av_marque = 'AIRBUS') AND Pilotes.pil_adresse in (SELECT Avions.av_loc FROM Avions WHERE Avions.av_marque = 'AIRBUS');

-- 8	Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans la ville de localisation d'un Airbus ?
SELECT DISTINCT pil_nom
FROM Vols
	INNER JOIN Pilotes
		ON Vols.pilote = Pilotes.pil
WHERE Vols.avion  IN (SELECT av FROM Avions WHERE av_marque = 'AIRBUS') OR Pilotes.pil_adresse in (SELECT Avions.av_loc FROM Avions WHERE Avions.av_marque = 'AIRBUS');


-- 9	Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?
SELECT DISTINCT pil_nom
FROM vols 
	INNER JOIN pilotes ON vols.pilote=pilotes.pil
	INNER JOIN avions ON vols.avion= avions.av
WHERE av_marque='AIRBUS' and pilotes.pil_adresse <> avions.av_loc;

-- 10	Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?
SELECT vol, vd, va
FROM Vols
WHERE	vd IN (SELECT vd FROM Vols INNER JOIN Pilotes ON Vols.pilote = Pilotes.pil WHERE Pilotes.pil_nom = 'SERGE') AND 
		va IN (SELECT va FROM Vols INNER JOIN Pilotes ON Vols.pilote = Pilotes.pil WHERE Pilotes.pil_nom = 'SERGE') AND 
		vol <> All (SELECT vol FROM Vols INNER JOIN Pilotes ON Vols.pilote = Pilotes.pil WHERE Pilotes.pil_nom = 'SERGE');

-- 11	Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).
SELECT P1.pil_nom, P2.pil_nom
FROM Pilotes AS P1
	FULL JOIN Pilotes  AS P2
		ON P1.pil_adresse = P2.pil_adresse
WHERE P1.pil > P2.pil;

-- 12	Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ?
SELECT pil_nom
FROM Vols
	INNER JOIN Pilotes
		ON Vols.pilote = Pilotes.pil
WHERE Vols.avion IN (SELECT avion FROM Vols WHERE pilote = 1) AND Pilotes.pil <> 1; 

-- 13	Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée.
SELECT Pilotes.pil_nom, Vols.vd, Vols.va, Pilotes.pil_adresse, Avions.av_loc
FROM Vols
	INNER JOIN Avions
		ON Vols.avion = Avions.av
	INNER JOIN Pilotes
		ON Vols.pilote = Pilotes.pil
WHERE Vols.vd = Avions.av_loc AND Vols.va = Pilotes.pil_adresse

-- 14	Sélectionner les numéros des pilotes qui conduisent tous les Airbus ? Aucun vue que 2 Type
-- 14	Sélectionner les numéros des pilotes qui conduisent que des Airbus ?
SELECT DISTINCT pilote 
FROM Vols
EXCEPT
SELECT pilote
FROM Vols
WHERE avion IN (SELECT av FROM Avions WHERE av_marque <> 'AIRBUS');

