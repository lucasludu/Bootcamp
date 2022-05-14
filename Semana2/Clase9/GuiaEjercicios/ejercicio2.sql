CREATE DATABASE VideoClubEj2

USE VideoClubEj2

CREATE TABLE Pelicula (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[titulo] VARCHAR(50),
	[genero] VARCHAR(50),
	[fechaBaja] DateTime
);

CREATE TABLE Alquiler (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[peliculaId] INT,
	[fecha] DateTime,
	[precio] numeric(18,2),
	FOREIGN KEY (peliculaId) REFERENCES Pelicula (id)
);