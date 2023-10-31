CREATE DATABASE AB202View

USE AB202View


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(25) NOT NULL,
Surname VARCHAR(25) DEFAULT 'XXX',
Point INT CHECK(Point BETWEEN 0 AND 100)
)

CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(1),
MinGrade INT CHECK(MinGrade BETWEEN 0 AND 100),
MaxGrade INT CHECK(MaxGrade BETWEEN 0 AND 100)
)

CREATE TABLE Clothes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(50) NOT NULL,
)

CREATE TABLE Sizes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(50) NOT NULL,
)

CREATE TABLE ClotheSizes(
Id INT PRIMARY KEY IDENTITY,
ClotheId INT FOREIGN KEY REFERENCES Clothes(Id),
SizeId INT FOREIGN KEY REFERENCES Sizes(Id)

)


CREATE TABLE KHProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL,
Price DECIMAL(6,2) NOT NULL
)
CREATE TABLE IrshadProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL,
Price DECIMAL(6,2) NOT NULL
)

ALTER TABLE IrshadProducts DROP COLUMN Cost 

--SELECT Name FROM KHProducts
--UNION ALL
--SELECT Name FROM IrshadProducts

--SELECT Name FROM KHProducts
--EXCEPT
--SELECT Name FROM IrshadProducts

--SELECT Name FROM IrshadProducts
--INTERSECT
--SELECT Name FROM KHProducts
--SELECT c.Name,s.Name Size FROM Clothes AS c
--CROSS JOIN Sizes AS s



--SELECT * FROM ()

CREATE VIEW GetStudentsGrades
AS
SELECT Name+' '+Surname AS 'Fullname',g.Letter as Grade, s.Point AS GradePoint FROM Students AS s
JOIN Grades AS g
ON s.Point BETWEEN g.MinGrade and g.MaxGrade
WHERE s.Point>60


SELECT MIN(r.GradePoint) FROM (SELECT GradePoint FROM GetStudentsGrades WHERE GradePoint>60) AS r



CREATE VIEW GetCLothesSizes
AS
SELECT c.Id,c.Name AS ClothesName, s.Name AS Size FROM Clothes AS c
JOIN ClotheSizes AS cs
ON c.Id=cs.ClotheId
JOIN Sizes AS s
ON cs.SizeId=s.Id


SELECT * FROM GetCLothesSizes 

SELECT * FROM GetCLothesSizes WHERE LEN(Size)>1




--WHERE LEN(c.Name)>5
--GROUP BY c.Name,c.Id
--HAVING COUNT(s.Name)>3