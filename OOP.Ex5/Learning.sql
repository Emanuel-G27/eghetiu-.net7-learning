CREATE DATABASE Learning;

USE Learning;

CREATE TABLE Employee
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(20),
    LastName VARCHAR(20),
    YearOfBirth INT,
    City VARCHAR(30),
    NumberOfId INT,   
);

CREATE TABLE Managers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(20),
    LastName VARCHAR(20),
    YearOfBirth INT,
    PostName VARCHAR(30),
    City VARCHAR(30),
    NumberOfId INT,   
    EmployeeId INT REFERENCES Employee(Id),
);


INSERT INTO Employee
VALUES('Adi','Petrescu',1990, 'Iasi', 3434);

INSERT INTO Employee
VALUES('Ana','Ilie',1993, 'Vaslui', 3290);

INSERT INTO Employee
VALUES('Amelie','Bogdan',1997, 'Suceava', 6789);


INSERT INTO Managers
VALUES('Francisca','Ghetiu', 1994, 'Secund Manager', 'Iasi', 1000, 1);
INSERT INTO Managers
VALUES('Emanuel','Ghetiu', 1997, 'Primary Manager', 'Iasi', 2000, 2);
INSERT INTO Managers
VALUES('Noah','Ghetiu', 2022, 'BOSS Manager', 'Iasi', 10000, 3);


SELECT *
FROM Managers;


SELECT *
FROM Employee;

SELECT YearOfBirth, LastName FROM Employee
UNION ALL
SELECT NumberOfId, PostName FROM Managers

SELECT *
FROM Employee
INNER JOIN Managers ON Employee.Id = Managers.EmployeeId;

SELECT *
FROM Employee
LEFT JOIN Managers ON Employee.Id = Managers.EmployeeId;

SELECT *
FROM Employee
RIGHT JOIN Managers ON Employee.Id = Managers.EmployeeId;

SELECT *
FROM Employee
FULL OUTER JOIN Managers ON Employee.Id = Managers.EmployeeId;

SELECT City as Emi, YearOfBirth as Edi 
FROM Employee;

SELECT e.FirstName,e.City, m.EmployeeId,m.PostName
FROM Employee e
FULL OUTER JOIN Managers m ON e.Id = m.EmployeeId;

SELECT AVG(YearOfBirth) AVERAGE 
FROM Employee;

SELECT MAX(YearOfBirth) MaximumValue 
FROM Employee;

SELECT MIN(YearOfBirth) MinValue 
FROM Employee;

SELECT SUM(YearOfBirth) SumOfBirths
FROM Employee;

SELECT *
FROM Managers
ORDER BY YearOfBirth ASC;

SELECT *
FROM Managers
ORDER BY YearOfBirth DESC;

SELECT FirstName,COUNT(FirstName)Last, LastName 
FROM Employee
GROUP BY FirstName,LastName;

GO
CREATE PROCEDURE HelloEveryone
AS
BEGIN
     PRINT 'Hello everyone!';
     PRINT 'This is not a test!';
     SELECT * FROM Employee;
END
GO

exec HelloEveryone;


GO
CREATE PROCEDURE GetEmployeeById(@employeeId INT)
AS
BEGIN
     SELECT * FROM Employee WHERE Id = @employeeId;
END
GO

GO
CREATE FUNCTION dbo.GetEmployeeByIdFunction(@employeeId INT)
RETURNs VARCHAR(20)
AS
BEGIN
     DECLARE @identifier INT;
     SET @identifier = (SELECT Id FROM Employee WHERE Id = @employeeId);
     RETURN @identifier;
END;
GO

SELECT dbo.GetEmployeeByIdFunction(1);

DROP FUNCTION dbo.GetEmployeeByIdFunction;

GO
CREATE FUNCTION dbo.GetEmployeeByIdFunction(@LastName INT)
RETURNS INT
AS
BEGIN
     DECLARE @identifier VARCHAR;
     SET @identifier = (SELECT LastName FROM Employee WHERE Id = @LastName);
     RETURN @identifier;
END;
GO


