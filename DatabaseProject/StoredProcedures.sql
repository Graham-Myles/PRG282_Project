CREATE PROCEDURE spDeleteStudent(
@Id int
)
AS
BEGIN 
DELETE FROM StudentInfo 
WHERE StudentID= @Id
END


CREATE PROCEDURE spUpdateStudent(
@Id int,
@Name varchar(20),
@Surname varchar(20),
@Image image ,
@Dob date,
@Gender varchar(20),
@Phone varchar(20),
@Adress varchar(20),
@MdCode int
)
AS
BEGIN 
UPDATE StudentInfo 
SET StudentID = @Id,
StudentName=@Name ,
StudentSurname=@Surname ,
StudentImage=@Image  ,
DOB=@Dob ,
Gender=@Gender ,
PhoneNumber=@Phone ,
Adress=@Adress ,
ModuleCode=@MdCode
END

CREATE PROCEDURE spAddStudent(
@ID int,
@name varchar(20),
@surname varchar(20),
@image image ,
@dob date,
@gender varchar(20),
@phone varchar(20),
@adress varchar(20),
@mdCode int
)
AS
BEGIN 
INSERT INTO StudentInfo 
VALUES (@ID ,
@name ,
@surname ,
@image  ,
@dob ,
@gender ,
@phone ,
@adress ,
@mdCode)
END

CREATE PROCEDURE spSearchStudent(
@Id int
)
AS
BEGIN 
SELECT * FROM StudentInfo 
WHERE StudentID= @Id
END
