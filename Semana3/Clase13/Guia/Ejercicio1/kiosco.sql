CREATE DATABASE KioscoDBF;

USE KioscoDBF;

CREATE TABLE Producto (
	[Id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Nombre] VARCHAR(100),
	[Categoria] VARCHAR(100),
	[FechaBaja] DateTime
);

CREATE TABLE Caracteristica (
	[Id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[ProductoId] INT,
	[Precio] NUMERIC(18,2),
	[Ancho] NUMERIC(18,2),
	[Largo] NUMERIC(18,2),
	[Peso] NUMERIC(18,2)
);