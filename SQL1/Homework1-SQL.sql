CREATE DATABASE ZooManagement5;

USE ZooManagement5;

CREATE TABLE Animals1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TypeOfAnimal VARCHAR(30),
    NumberOfAnimal INT,
);

CREATE TABLE Species1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NameOfSpecies VARCHAR(20),
    NumberOfSpecies INT,
    AnimalsId INT REFERENCES Animals1(Id),
);

CREATE TABLE CareTakers1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(30),
    LastName VARCHAR(30),
    AreaOfWork VARCHAR(20),
    AnimalsId INT REFERENCES Animals1(Id),
);

CREATE TABLE ZooAreas1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NameOfTheArea VARCHAR(20),
    CareTakersId INT REFERENCES CareTakers1(Id),
);

CREATE TABLE Visitors1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DayOfTheWeek VARCHAR(30),
    NumbersOfVisitors INT,
    AnimalsId INT REFERENCES Animals1(Id),
);

CREATE TABLE Tickets1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Validity VARCHAR(30),
    Price MONEY,
    VisitorsId INT REFERENCES Visitors1(Id),
);

CREATE TABLE ZooDetails1
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ZooName VARCHAR(30),
    StreetName VARCHAR(30),
    StreetNumber INT,
    City VARCHAR(20),
);


INSERT INTO Animals1
VALUES('Carnivore type', 100);
INSERT INTO Animals1
VALUES('Herbivore type', 80);
INSERT INTO Animals1
VALUES('Flying type', 120);
INSERT INTO Animals1
VALUES('Fish type', 200);
INSERT INTO Animals1
VALUES('Endangered animals', 40);
INSERT INTO Animals1
VALUES('Insects type', 150);

SELECT *
FROM Animals1;

INSERT INTO Species1
VALUES('Lion', 10, 1);
INSERT INTO Species1
VALUES('Wolf', 15, 1);
INSERT INTO Species1
VALUES('Giraffe', 2, 2);
INSERT INTO Species1
VALUES('Vulture', 10, 3);
INSERT INTO Species1
VALUES('Salamanders', 16, 4);
INSERT INTO Species1
VALUES('Shark',14, 4);
INSERT INTO Species1
VALUES('Otter', 10, 5);
INSERT INTO Species1
VALUES('Spiders', 20, 6);
INSERT INTO Species1
VALUES('Iguana', 1, 5);
INSERT INTO Species1
VALUES('Fox', 10, 1);
INSERT INTO Species1
VALUES('Tiger', 4, 1);
INSERT INTO Species1
VALUES('Hawk', 7, 3);
INSERT INTO Species1
VALUES('Scorpion', 18, 6);

SELECT *
FROM Species1;

INSERT INTO CareTakers1
VALUES('Iohanis', 'Klaus', 'NORTH AREA', 1);
INSERT INTO CareTakers1
VALUES('Ponta', 'Victor', 'SOUTH AREA', 2);
INSERT INTO CareTakers1
VALUES('Iliescu', 'Ion', 'EAST AREA', 3);
INSERT INTO CareTakers1
VALUES('Basescu', 'Traian', 'WEST AREA', 4);
INSERT INTO CareTakers1
VALUES('Vanghelie', 'Marian', 'EAST AREA', 5);
INSERT INTO CareTakers1
VALUES('Dragnea', 'Liviu', 'NORTH AREA', 6);

SELECT *
FROM CareTakers1;

INSERT INTO ZooAreas1
VALUES('NORTH AREA', 1);
INSERT INTO ZooAreas1
VALUES('NORTH AREA', 6);
INSERT INTO ZooAreas1
VALUES('EAST AREA', 3);
INSERT INTO ZooAreas1
VALUES('EAST AREA', 5);
INSERT INTO ZooAreas1
VALUES('WEST AREA', 4);
INSERT INTO ZooAreas1
VALUES('SOUTH AREA', 2);

SELECT *
FROM ZooAreas1;

INSERT INTO Visitors1
VALUES('Monday', 200, 1);
INSERT INTO Visitors1
VALUES('Tuesday', 260, 2);
INSERT INTO Visitors1
VALUES('Wednesday', 276, 3);
INSERT INTO Visitors1
VALUES('Thursday', 189, 4);
INSERT INTO Visitors1
VALUES('Friday', 234, 5);
INSERT INTO Visitors1
VALUES('Saturday', 400, 6);
INSERT INTO Visitors1
VALUES('Sunday', 500, 1);

SELECT *
FROM Visitors1;

INSERT INTO Tickets1
VALUES('One day', 20.5 , 1);
INSERT INTO Tickets1
VALUES('One week',100 , 2);
INSERT INTO Tickets1
VALUES('One month', 250 , 4);

SELECT *
FROM Tickets1;


INSERT INTO ZooDetails1
VALUES('Magic Zoo', 'Independentei', 23, 'Brasov');

SELECT *
FROM ZooDetails1;
