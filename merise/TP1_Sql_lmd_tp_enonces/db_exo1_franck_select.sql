USE db_exo_franck;
GO

-- Partie 1
-- 1.	Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
SELECT ename, job, empno, sal
FROM Emp;

SELECT ename, job, empno, sal
FROM Emp 
WHERE deptno = 10;

-- 2.	Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT ename, job, sal
FROM Emp
WHERE job = 'MANAGER' AND sal > 2800;

-- 3.	Donner la liste des MANAGER n'appartenant pas au département 30
SELECT *
FROM Emp
WHERE job = 'MANAGER' AND deptno <> 30;

-- 4.	Liste des employés de salaire compris entre 1200 et 1400
SELECT *
FROM Emp
	WHERE sal >= 1200 AND sal <= 1400;

-- 5.	Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT *
FROM Emp
WHERE deptno <= 30 AND deptno <> 20
ORDER BY ename ASC;

-- 6.	Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT *
FROM Emp
WHERE deptno = 30
ORDER BY sal ASC;

-- 7.	Liste de tous les employés classés par emploi et salaires décroissants
SELECT *
FROM Emp
	ORDER BY job DESC, sal DESC

-- 8.	Liste des différents emplois
SELECT DISTINCT job
FROM Emp;

-- 9.	Donner le nom du département où travaille ALLEN
SELECT dname
FROM Emp
	INNER JOIN Dept 
		ON Emp.deptno = Dept.deptno
WHERE ename = 'ALLEN';

-- 10.	Liste des employés avec nom du département, nom, job, salaires classés par noms de départements et par salaires décroissants.
SELECT dname, ename, job, sal
FROM Emp
	INNER JOIN Dept
		ON Emp.deptno = Dept.deptno
ORDER BY dname DESC, sal DESC;

-- 11.	Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT ename, sal, comm, sal + comm AS calc
FROM Emp
WHERE job = 'SALESMAN';

-- 12.	Liste des employés du département 20 : nom, job, date d'embauche sous forme VEN 28 FEV 1997'
/*declare @Existingdate datetime
Set @Existingdate=GETDATE()
Select CONVERT(varchar,@Existingdate,107) as [MMM DD,YYYY]*/
SELECT ename, job, FORMAT (hiredate, 'dddd dd MMM yyyy')
FROM Emp
WHERE deptno = 20;

-- 13.	Donner le salaire le plus élevé par département
SELECT DISTINCT dname, MAX(sal) AS max_sal 
FROM Emp
	INNER JOIN Dept
		ON Emp.deptno = Dept.deptno
GROUP BY dname;

-- 14.	Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT dname, job, COUNT(ename) AS enumber, SUM(sal) AS sumsal, AVG(sal) AS average
FROM Emp
	INNER JOIN Dept
	ON Emp.deptno = Dept.deptno
GROUP BY dname, job
ORDER BY dname;

-- 15.	Même question mais on se limite aux sous-ensembles d'au moins 2 employés
SELECT DISTINCT dname, job, COUNT(ename) AS enumber, SUM(sal) AS sumsal, AVG(sal) AS average
FROM Emp
	FULL JOIN Dept
		ON Emp.deptno = Dept.deptno
GROUP BY dname, job
HAVING COUNT(ename) > 1
ORDER BY dname;

-- 16.	Liste des employés (Nom, département, salaire) de même emploi que JONES
SELECT ename, dname, sal, job
FROM Emp
	INNER JOIN Dept
		ON Emp.deptno = Dept.deptno
WHERE (SELECT job FROM Emp WHERE ename = 'JONES') = job;

-- 17.	Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
SELECT ename, sal
FROM Emp
WHERE sal > (SELECT AVG(sal) FROM Emp);

-- 18.	Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet (5 caractères) OK

-- 19.	Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102

ALTER TABLE Emp
ADD project_number INT;

ALTER TABLE Emp
ADD CONSTRAINT FK_Emp_project_nb FOREIGN KEY (project_number) REFERENCES Projet (project_nb);

SELECT * FROM Emp;

UPDATE Emp
SET project_number = 101 
WHERE deptno = 30 AND job = 'SALESMAN';

UPDATE Emp
SET project_number = 102 
WHERE deptno <> 30  AND job <> 'SALESMAN';

-- 20.	 Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Employees_info' AND type = 'V')
BEGIN
	CREATE VIEW Employees_info
	AS
	SELECT ename, job, dname, project_name
	FROM Emp
		INNER JOIN Dept 
			ON Emp.deptno = Dept.deptno
		INNER JOIN Projet
			ON Emp.project_number = Projet.project_nb;
END

-- 21.	A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet
SELECT * 
FROM Employees_info
ORDER BY dname, project_name;

-- 22.	Donner le nom du projet associé à chaque manager
SELECT ename, job, project_name
FROM Emp
	INNER JOIN Projet 
		ON Emp.project_number = Projet.project_nb
WHERE job = 'MANAGER';



-- Partie 2
-- 1.	Afficher la liste des managers des départements 20 et 30
SELECT ename, job, deptno
FROM Emp
WHERE job = 'MANAGER' AND deptno <> 10;

-- 2.	Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
SELECT ename, job, hiredate
FROM Emp 
WHERE job <> 'MANAGER' AND FORMAT(hiredate, 'yyyy') = 1981;

-- 3.	Afficher la liste des employés ayant une commission
SELECT *
FROM Emp
WHERE comm IS NOT NULL;

-- 4.	Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB  les derniers embauches d'abord.
SELECT ename, deptno, job, hiredate
FROM Emp
ORDER BY deptno, job, hiredate DESC;

-- 5.	Afficher la liste des employés travaillant à DALLAS
SELECT *
FROM Emp
	INNER JOIN Dept
		ON Emp.deptno = Dept.deptno
WHERE loc = 'DALLAS';

-- 6.	Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.
SELECT MANAGER.ENAME AS ManagerName, MANAGER.HIREDATE AS ManagerHiredate, EMP.ENAME AS EmployeeName, EMP.HIREDATE AS EmployeeHiredate
FROM EMP
	INNER JOIN EMP AS MANAGER 
		ON EMP.MGR = MANAGER.EMPNO
WHERE EMP.HIREDATE < MANAGER.HIREDATE;

-- 7.	Lister les numéros des employés n'ayant pas de subordonné.
SELECT empno, ename
FROM Emp
WHERE empno NOT IN (SELECT mgr FROM Emp WHERE mgr IS NOT NULL);

-- 8.	Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.
SELECT ename, hiredate
FROM Emp
WHERE (SELECT hiredate FROM Emp WHERE ename = 'BLAKE') > hiredate;

-- 9.	Afficher les employés embauchés le même jour que FORD.
SELECT *
FROM Emp
WHERE (SELECT hiredate FROM Emp WHERE ename = 'FORD') = hiredate;

-- 10.	Lister les employés ayant le même manager que CLARK.
SELECT *
FROM Emp
WHERE mgr = (SELECT mgr FROM Emp WHERE ename = 'CLARK');

-- 11.	Lister les employés ayant même job et même manager que TURNER.
SELECT *
FROM Emp
WHERE job = (SELECT job FROM Emp WHERE ename = 'TURNER') AND mgr = (SELECT mgr FROM Emp WHERE ename = 'TURNER');

-- 12.	Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.
SELECT empno, ename, job, hiredate, dname, loc, project_number
FROM Emp
	INNER JOIN Dept 
		ON Emp.deptno = Dept.deptno
WHERE dname = 'RESEARCH' AND hiredate IN (SELECT hiredate FROM Emp INNER JOIN Dept ON Emp.deptno = Dept.deptno WHERE dname = 'SALES');

-- 13.	Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.
SELECT ename, FORMAT(hiredate, 'dddd') AS week_day
FROM Emp;

-- 14.	Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.
SELECT 
ename,
DATEDIFF(MONTH, hiredate, GETDATE()) AS number_of_months
FROM Emp;

-- 15.	Afficher la liste des employés ayant un M et un A dans leur nom.
SELECT *
FROM Emp
WHERE  CHARINDEX('M', ename) > 0 AND CHARINDEX('A', ename) > 0;


-- 16.	Afficher la liste des employés ayant deux 'A' dans leur nom.
SELECT *
FROM Emp
WHERE  ename LIKE '%A%A%';

-- 17.	Afficher les employés embauchés avant tous les employés du département 10.
SELECT *
FROM Emp
WHERE hiredate < ALL (SELECT hiredate FROM Emp WHERE deptno = 10);

-- 18.	Sélectionner le métier où le salaire moyen est le plus faible.
SELECT job, AVG(sal) FROM Emp
GROUP BY job
HAVING AVG(sal) <= ALL(SELECT AVG(sal) FROM Emp GROUP BY job);

-- 19.	Sélectionner le département ayant le plus d'employés.
SELECT deptno, COUNT(empno) AS nombre_employees
FROM Emp
GROUP BY deptno
HAVING COUNT(empno) >= ALL (SELECT COUNT(empno) FROM Emp GROUP BY deptno);

-- 20.	Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
SELECT deptno, CAST(CAST(COUNT(deptno) AS REAL) * 100 / (SELECT COUNT(deptno) FROM Emp) AS DECIMAL(5,2)) AS Pourcentage
FROM Emp
GROUP BY deptno;
