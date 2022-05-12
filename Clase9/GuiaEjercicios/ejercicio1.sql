CREATE DATABASE KioscoEj1

USE KioscoEj1

CREATE TABLE Producto (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[categoria] VARCHAR(50),
	[fechaBaja] DateTime
);

CREATE TABLE Caracteristica (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[productoId] INT,
	[precio] numeric(18,2),
	[ancho] numeric(18,2),
	[largo] numeric(18,2),
	[peso] numeric(18,2),
	FOREIGN KEY (productoId) REFERENCES Producto (id)
);