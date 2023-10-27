
CREATE DATABASE AB202

USE AB202


DROP TABLE Students

CREATE TABLE Students(
 Id int PRIMARY KEY IDENTITY,
 [Name] varchar(25) NOT NULL,
 Surname varchar(25) DEFAULT 'XXX',
 Age int CHECK(Age>=0 and Age<=100),
 Email varchar(25) UNIQUE
)

--ALTER TABLE Students ADD MName varchar(250), FinC0de int

--ALTER TABLE Students DROP COLUMN FName
TRUNCATE TABLE Students
INSERT INTO Students VALUES
(1,'Shems','Behbudova',23,'fidan@gmail.com'),
(2,'Azer','Qasimzade',19,'azer@gmail.com')


INSERT INTO Students(Name,Age,Email) VALUES ('Amin',19,'amin@gmail.com')

UPDATE Students SET Surname='Pashayev' WHERE Id=3

DELETE FROM Students WHERE Id=2


--SELECT Name+' '+Surname AS Fullname FROM Students WHERE Age>19 and Age<24
--SELECT Name+' '+Surname AS Fullname FROM Students
--SELECT Name,Surname AS Fullname FROM Students WHERE Name like '_min%'




