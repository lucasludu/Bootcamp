CREATE DATABASE ClinicaEj4

USE ClinicaEj4

CREATE TABLE TipoEstudio (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[description] VARCHAR(50),
	[fechaBaja] DateTime
);

CREATE TABLE TipoEmpleado (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[description] VARCHAR(50),
	[fechaBaja] DateTime
);

CREATE TABLE Paciente (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(150),
	[apellido] VARCHAR(150),
	[DNI] VARCHAR(50),
	[direccion] VARCHAR(250)
);

CREATE TABLE Empleado (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[tipoEmpleadoId] INT,
	[nombre] VARCHAR(150),
	[apellido] VARCHAR(150),
	[DNI] VARCHAR(50),
	[legajo] VARCHAR(50),
	FOREIGN KEY (tipoEmpleadoId) REFERENCES TipoEmpleado (id)
);

CREATE TABLE Estudio (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[tipoEstudioId] INT,
	[empleadoId] INT,
	[fecha] DateTime,
	[informe] VARCHAR(250),
	FOREIGN KEY (tipoEstudioId) REFERENCES TipoEstudio (id),
	FOREIGN KEY (empleadoId) REFERENCES Empleado (id)
);