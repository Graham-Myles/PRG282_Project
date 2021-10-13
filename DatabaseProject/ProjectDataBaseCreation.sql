CREATE DATABASE  PRG282Project 



CREATE TABLE StudentInfo (
StudentID int,
StudentName varchar(20),
StudentSurname varchar(20),
StudentImage image,
DOB date,
Gender varchar(20),
PhoneNumber text,
Adress text, 
ModuleCode int

)


CREATE TABLE MDInfo (
ModeluID int,
ModuleName text,
ModuleDescription  varchar(200),
OnlineResources text 
)

Insert into StudentInfo (StudentID,StudentName,StudentSurname,DOB,Gender,PhoneNumber,Adress,ModuleCode)
values
(1,'Leon','Stassen','1999-08-21','Male','07965472001','7 Wondertak',1),
(2,'Micheal','Falk','2001-01-10','Male','08425703001','20 Jandraad',2),
(3,'Graham','Myles','2001-08-08','Male','07936501996','16 Harts',3),
(4,'Marlou','Froneman','2001-05-03','Male','0798041961','51 Hull',4)

INSERT INTO MDInfo 
VALUES
(1,'LPR281','Linear Programing concepts and overall optimization ','https://s2.smu.edu/~olinick/cse3360/lectures/lp_assumptions.html'),
(2,'DBD281','Using SQL with databases and uses for SQL  ','https://www.w3schools.com/sql/sql_create_table.asp'),
(3,'INF281','Uses for inforamtion systems adn overall implimantation of these systems in a business  ','https://en.wikipedia.org/wiki/Information_system'),
(4,'PPM281','Project Managemant overview ','https://search.visymo.com/ws?q=explain%20project%20management&asid=vis_za_gc4_15&mt=b&nw=g&de=c&ap=&ac=5017&cid=8114547083&aid=82089324125&locale=en_ZA&gclid=Cj0KCQjwwY-LBhD6ARIsACvT72Pj8NeloYZOoHb-dtswHEPKXXIAyol5VI4KNUMM_eIMA3KmkJtvjykaArpQEALw_wcB')

UPDATE StudentInfo 
set StudentImage=(  SELECT * FROM  OPENROWSET  (BULK  'C:\Users\Marlouf\Desktop\DatabaseProject\Images\Pic1.jpg',SINGLE_BLOB) as Image)
Where StudentID= '1'
UPDATE StudentInfo 
set StudentImage=(  SELECT * FROM  OPENROWSET  (BULK  'C:\Users\Marlouf\Desktop\DatabaseProject\Images\Pic2.jpeg',SINGLE_BLOB) as Image)
Where StudentID= '2'
UPDATE StudentInfo 
set StudentImage=(  SELECT * FROM  OPENROWSET  (BULK  'C:\Users\Marlouf\Desktop\DatabaseProject\Images\Pic3.jpg',SINGLE_BLOB) as Image)
Where StudentID= '3'
UPDATE StudentInfo 
set StudentImage=(  SELECT * FROM  OPENROWSET  (BULK  'C:\Users\Marlouf\Desktop\DatabaseProject\Images\Pic4.jpg',SINGLE_BLOB) as Image)
Where StudentID= '4'