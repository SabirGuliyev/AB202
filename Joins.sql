CREATE DATABASE AB202Relation

USE AB202Relation


CREATE TABLE Universities(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
UniversityId INT REFERENCES Universities(Id)
)


SELECT s.Name, u.Name AS [University name] FROM Students AS s
FULL OUTER JOIN Universities AS u
ON s.UniversityId=u.Id
WHERE s.UniversityId IS NULL



CREATE TABLE Positions(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) UNIQUE NOT NULL,
DependId INT REFERENCES Positions(Id)
)


SELECT p.Name, Depend.Name AS [Depend On] FROM Positions AS p
LEFT JOIN Positions AS Depend
ON p.DependId=Depend.Id