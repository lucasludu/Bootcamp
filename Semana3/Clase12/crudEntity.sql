	CREATE DATABASE CursoEntityMVC;

	USE CursoEntityMVC;

	CREATE TABLE Usuario (
		id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
		idState INT,
		email VARCHAR(100),
		password VARCHAR(100),
		FOREIGN KEY (idState) REFERENCES CState (id)
	);


	CREATE TABLE CState (
		id INT PRIMARY KEY IDENTITY(1,1),
		name VARCHAR(100)
	);

	INSERT INTO CState (name) VALUES 
	('Activo'),
	('Inactivo'),
	('Eliminado');

	INSERT INTO Usuario (idState, email, password) VALUES (1, 'contacto@gmail.com', '1234');

	SELECT * FROM CState;
	SELECT * FROM Usuario;


	drop table if exists Usuario;