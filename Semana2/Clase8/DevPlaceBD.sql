CREATE DATABASE DevPlaceBD

use DevPlaceBD

CREATE TABLE Tecnologia (
	IdTecnologia INT IDENTITY (1,1) NOT NULL,
	nombreTecnologia VARCHAR(50) NOT NULL
	PRIMARY KEY (IdTecnologia)
);

CREATE TABLE Curso (
	idCurso INT NOT NULL IDENTITY,
	IdTecnologia INT,
	nombreCurso VARCHAR(50) NOT NULL,
	fechaInicio DATETIME,
	fechaFinal DATETIME,
	cantidadAlumnos INT,
	PRIMARY KEY (idCurso),
	FOREIGN KEY (IdTecnologia) REFERENCES Tecnologia (IdTecnologia)
);

INSERT INTO Tecnologia (nombreTecnologia) VALUES ('.NET'),
												 ('C#'),
												 ('JAVA');

SELECT * FROM Tecnologia;

INSERT INTO Curso (IdTecnologia, nombreCurso, fechaInicio, fechaFinal, cantidadAlumnos) VALUES (1, '.Net', '2022-03-01', '2022-06-01', 300),
																								(2, 'C#', '2022-04-01', '2022-07-01', 400),
																								 (3, 'Java', '2022-05-01', '2022-08-01', 500);

SELECT * FROM Curso;

SELECT * FROM Tecnologia T JOIN Curso C ON T.idTecnologia = C.idCurso

drop table if exists Curso;

-- MODIFICAR

update Curso set cantidadAlumnos = cantidadAlumnos / 10;

-- ELIMINAR

delete from Curso where Month(fechaInicio) = '04'; 

-- ALTER TABLE

ALTER TABLE Curso ADD ide VARCHAR(20) NULL;

