CREATE DATABASE AB202Procedure

USE AB202Procedure


CREATE TABLE Groups(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(10) NOT NULL,
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(25) NOT NULL,
Surname VARCHAR(25) DEFAULT 'XXX',
Point INT CHECK(Point BETWEEN 0 AND 100),
GroupId INT FOREIGN KEY REFERENCES Groups(Id) NOT NULL,
IsDeleted BIT DEFAULT 0
)

ALTER TABLE Students ADD IsDeleted BIT DEFAULT 0


ALTER PROCEDURE usp_CreateStudent(@name VARCHAR(25),@point INT,@groupId INT,@surname VARCHAR(25)='XXX')
AS
SET @name=(SELECT dbo.Capitalize(@name))
SET @surname=(SELECT dbo.Capitalize(@surname))
INSERT INTO Students VALUES(@name,@surname,@point,@groupId)




CREATE FUNCTION Capitalize(@word VARCHAR(100))
RETURNS VARCHAR(100)
AS
BEGIN
SET @word=TRIM(@word)
SET @word=UPPER(LEFT(@word,1))+LOWER(SUBSTRING(@word,2,LEN(@word)))
RETURN @word
END


EXEC usp_CreateStudent ' nuBAR ',92,1,' abUdoVA '








CREATE VIEW GetStudentsPoint
AS
SELECT s.Name+' '+s.Surname AS Fullname,s.Point,g.Name AS [Group] FROM Students AS s
JOIN Groups AS g
ON s.GroupId=g.Id






CREATE PROCEDURE usp_GetStudentsByPoint @point INT
AS
SELECT * FROM GetStudentsPoint
WHERE Point>@point


SELECT * FROM GetStudentsPoint
WHERE Point>70


SELECT * FROM GetStudentsPoint
WHERE Point>80

SELECT * FROM GetStudentsPoint
WHERE Point>90

EXEC usp_GetStudentsByPoint 70
EXEC usp_GetStudentsByPoint 80
EXEC usp_GetStudentsByPoint 90









ALTER FUNCTION GetStudentCount(@point INT)
RETURNS INT
AS
BEGIN
DECLARE @count INT
SELECT @count= COUNT(*) FROM GetStudentsPoint WHERE Point>@point
RETURN @count
END



SELECT dbo.GetStudentCount(80)




ALTER TRIGGER GetStudentsWhenDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN
DECLARE @isDeleted BIt
DECLARE @id INT
SELECT @isDeleted=IsDeleted,@id=Id FROM deleted
IF(@isDeleted=0)
 BEGIN
 UPDATE Students SET IsDeleted=1 WHERE Id=@id
 END
ELSE
 BEGIN
 DELETE FROM Students WHERE Id=@id
 END
END

DELETE FROM Students WHERE Id=5

