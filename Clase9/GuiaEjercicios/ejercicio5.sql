CREATE DATABASE EleccionesPresidencialesEj6

USE EleccionesPresidencialesEj6

CREATE TABLE PartidoPolitico (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[nombrePresidente] VARCHAR(50)
);

CREATE TABLE Colegio (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombreColegio] VARCHAR(50)
);

CREATE TABLE Votante (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[apellido] VARCHAR(50),
	[DNI] VARCHAR(50)
);

CREATE TABLE PresidenteMesa (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[apellido] VARCHAR(50)
);

CREATE TABLE DelegadoMesa (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50),
	[apellido] VARCHAR(50)
);

CREATE TABLE Mesa (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[colegioId] INT,
	[presidenteId] INT, 
	[delegadoId] INT,
	FOREIGN KEY (colegioId) REFERENCES Colegio (id),
	FOREIGN KEY (presidenteId) REFERENCES PresidenteMesa (id),
	FOREIGN KEY (delegadoId) REFERENCES DelegadoMesa (id)
);

CREATE TABLE Urna (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[mesaId] INT,
	FOREIGN KEY (mesaId) REFERENCES Mesa (id)
);

CREATE TABLE Padron (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[votanteId] INT,
	[mesaId] INT,
	[colegioId] INT,
	FOREIGN KEY (votanteId) REFERENCES Votante (id),
	FOREIGN KEY (mesaId) REFERENCES Mesa (id),
	FOREIGN KEY (colegioId) REFERENCES Colegio (id)
);

CREATE TABLE Voto (
	[id] INT PRIMARY KEY IDENTITY(1,1),
	[votanteId] INT,
	[mesaId] INT,
	[colegioId] INT,
	[partidoPoliticoId] INT,
	FOREIGN KEY (votanteId) REFERENCES Votante (id),
	FOREIGN KEY (mesaId) REFERENCES Mesa (id),
	FOREIGN KEY (colegioId) REFERENCES Colegio (id),
	FOREIGN KEY (partidoPoliticoId) REFERENCES PartidoPolitico (id)
);
