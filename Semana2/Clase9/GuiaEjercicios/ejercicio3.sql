CREATE DATABASE ConcesionariaEj3

USE ConcesionariaEj3

CREATE TABLE Vehiculo (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[marca] VARCHAR(50),
	[modelo] VARCHAR(50),
	[importe] VARCHAR(50),
	[fechaBaja] DateTime
);

CREATE TABLE Cliente (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[apellido] VARCHAR(50),
	[DNI] VARCHAR(50),
	[direccion] VARCHAR(50)
);

CREATE TABLE Venta (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[vehiculoId] INT,
	[clienteId] INT,
	[importe] numeric(18,2),
	[descuento] numeric(18,2),
	[fecha] DateTime,
	FOREIGN KEY (vehiculoId) REFERENCES Vehiculo (id),
	FOREIGN KEY (clienteId) REFERENCES Cliente (id)
);

