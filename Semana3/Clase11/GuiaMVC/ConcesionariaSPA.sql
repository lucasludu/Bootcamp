CREATE DATABASE ConcesionariaSPA;

USE ConcesionariaSPA;

CREATE TABLE Automovil (
	idAuto INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	marca VARCHAR(100) NOT NULL,
	modelo VARCHAR(100) NOT NULL,
	anio INT NOT NULL,
	kilometro INT NOT NULL,
	precio NUMERIC(18,2)
);

INSERT INTO Automovil (marca, modelo, anio, kilometro, precio) VALUES
('Renault', 'Logan', 2016, 85000, 1400000),
('Ford', 'Ka', 2018, 100000, 900000),
('Chevrolet', 'Onix', 2019, 54000, 850000),
('Fiat', 'Palio', 2013, 1200000, 650000),
('Peugeot', '206', 2015, 93500, 700000);

drop table if exists Automovil;

SELECT * FROM Automovil;



CREATE PROCEDURE RegistrarAutomovil (
	@marca VARCHAR(100),
	@modelo VARCHAR(100),
	@anio INT,
	@kilometro INT,
	@precio NUMERIC(18,2)
)
AS 
BEGIN
	INSERT INTO Automovil (marca, modelo, anio, kilometro, precio) VALUES (@marca, @modelo, @anio, @kilometro, @precio)
END


CREATE PROCEDURE EditarAutomovil (
	@idAuto INT,
	@marca VARCHAR(100),
	@modelo VARCHAR(100),
	@anio INT,
	@kilometro INT,
	@precio NUMERIC(18,2)
)
AS 
BEGIN
	UPDATE Automovil SET marca = @marca, modelo = @modelo, anio = @anio, kilometro = @kilometro, precio = @precio WHERE idAuto = @idAuto
END


CREATE PROCEDURE EliminarAutomovil (
	@idAuto INT
)
AS 
BEGIN
	DELETE FROM Automovil WHERE idAuto = @idAuto
END