CREATE DATABASE Kiosco;

USE Kiosco;

CREATE TABLE Producto (
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100),
	categoria VARCHAR(100),
	fechaBaja DateTime
);


CREATE TABLE Caracteristica (
	id INT PRIMARY KEY IDENTITY(1,1),
	productoId INT,
	precio NUMERIC(18,2),
	ancho NUMERIC(18,2),
	largo NUMERIC(18,2),
	peso NUMERIC(18,2),
	FOREIGN KEY (productoId) REFERENCES Producto (id)
);