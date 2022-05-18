CREATE DATABASE DbContacto;


USE DbContacto;


CREATE TABLE Contacto (
	idContacto INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100),
	apellido VARCHAR(100),
	telefono VARCHAR(100),
	correo VARCHAR(100)
);


INSERT INTO Contacto (nombre, apellido, telefono, correo) VALUES 
('Jose', 'Perez', '45645646', 'jose@gmail.com'),
('Maria', 'Paz', '45612346', 'maria@gmail.com'),
('Thalia', 'Quiñon', '45456746', 'thalia@gmail.com'),
('Belen', 'Mandara', '41567846', 'belen@gmail.com'),
('Alex', 'Espinoza', '45679813', 'alex@gmail.com');


SELECT * FROM Contacto;


CREATE PROCEDURE sp_Registrar (
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@telefono VARCHAR(100),
	@correo VARCHAR(100)
)
AS
BEGIN
	INSERT INTO Contacto (nombre, apellido, telefono, correo) VALUES (@nombre, @apellido, @telefono, @correo)
END


CREATE PROCEDURE sp_Editar (
	@idContacto INT,
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@telefono VARCHAR(100),
	@correo VARCHAR(100)
)
AS
BEGIN
	UPDATE Contacto SET nombre = @nombre, apellido = @apellido, telefono = @telefono, correo = @correo WHERE idContacto = @idContacto
END


CREATE PROCEDURE sp_Eliminar(
	@idContacto INT
)
AS
BEGIN
	DELETE FROM Contacto WHERE idContacto = @idContacto
END