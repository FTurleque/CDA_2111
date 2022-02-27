USE db_exo_franck;
GO

IF NOT EXISTS (SELECT * FROM Dept, Emp)
BEGIN
	INSERT INTO Dept(deptno,	dname,			loc)
	VALUES			(10,		'ACCOUNTING',	'NEW YORK'),
					(20,		'RESEARCH',		'DALLAS'),
					(30,		'SALES',		'CHICAGO'),
					(40,		'OPERATIONS',	'BOSTON')

	INSERT INTO Emp (empno, ename,		job,			mgr,	hiredate,	sal,	comm, deptno) 
	VALUES			(7369, 'SMITH',		'CLERK',		7902, '1980-12-17', 800,	NULL,	20),
					(7499, 'ALLEN',		'SALESMAN',		7698, '1981-02-20', 1600,	300,	30),
					(7521, 'WARD',		'SALESMAN',		7698, '1981-02-22', 1250,	500,	30),
					(7566, 'JONES',		'MANAGER',		7839, '1981-04-02', 2975,	NULL,	20),
					(7654, 'MARTIN',	'SALESMAN',		7698, '1981-09-28', 1250,	1400,	30),
					(7698, 'BLAKE',		'MANAGER',		7839, '1981-05-01', 2850,	NULL,	30),
					(7782, 'CLARK',		'MANAGER',		7839, '1981-07-09', 2450,	NULL,	10),
					(7788, 'SCOTT',		'ANALYST',		7566, '1982-12-09', 3000,	NULL,	20),
					(7839, 'KING',		'PRESIDENT',	NULL, '1981-11-17', 5000,	NULL,	10),
					(7844, 'TURNER',	'SALESMAN',		7698, '1981-09-08', 1500,	0,		30),
					(7876, 'ADAMS',		'CLERK',		7788, '1983-01-12', 1100,	NULL,	20),
					(7900, 'JAMES',		'CLERK',		7698, '1981-12-03', 950,	NULL,	30),
					(7902, 'FORD',		'ANALYST',		7566, '1981-12-03', 3000,	NULL,	20),
					(7934, 'MILLER',	'CLERK',		7782, '1982-01-23', 1300,	NULL,	10)
END

IF NOT EXISTS (SELECT * FROM Projet)
BEGIN
	INSERT INTO Projet	(project_nb, project_name, project_budget)
	VALUES				(101,		'ALPHA',		96000),
						(102,		'BETA',			82000),
						(103,		'GAMMA',		15000)
END
