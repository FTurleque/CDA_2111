IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_exo_franck')
BEGIN
CREATE DATABASE db_exo_franck;
END
GO

USE db_exo_franck;
GO

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Dept' AND xtype = 'U')
BEGIN
	CREATE TABLE Dept
	(deptno INT NOT NULL,
	dname VARCHAR(15) NOT NULL,
	loc VARCHAR(15) NOT NULL,
	CONSTRAINT PK_deptno PRIMARY KEY (deptno));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Projet' AND xtype = 'U')
BEGIN
CREATE TABLE Projet
	(project_nb INT NOT NULL,
	project_name VARCHAR(5) NOT NULL,
	project_budget INT NOT NULL,
	CONSTRAINT PK_project_nb PRIMARY KEY (project_nb),
	CONSTRAINT CK_project_nb CHECK(project_nb < 999));
END

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'Emp' AND xtype = 'U')
BEGIN
	CREATE TABLE Emp
	(empno INT NOT NULL,
	ename VARCHAR(15) NOT NULL,
	job VARCHAR(15) NOT NULL,
	mgr INT,
	hiredate DATE NOT NULL,
	sal INT NOT NULL,
	comm INT, 
	deptno INT NOT NULL,
	CONSTRAINT PK_empno PRIMARY KEY (empno),
	CONSTRAINT FK_Emp_deptno FOREIGN KEY (deptno) REFERENCES Dept (deptno),
	CONSTRAINT FK_Emp_mgr FOREIGN KEY (mgr) REFERENCES Emp (empno));
END

