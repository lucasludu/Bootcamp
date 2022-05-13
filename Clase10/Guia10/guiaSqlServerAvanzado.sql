CREATE DATABASE ArticuloComputadoras

USE ArticuloComputadoras

CREATE TABLE Proveedor (
	Id INTEGER PRIMARY KEY NOT NULL,
	Nombre CHAR(50) NOT NULL
);CREATE TABLE Producto (
	Id INTEGER PRIMARY KEY NOT NULL,
	Nombre CHAR(50) NOT NULL ,
	Precio numeric(15,2) NOT NULL ,
	ProveedorId INTEGER NOT NULL
	CONSTRAINT fk_Proveedor_Producto REFERENCES Proveedor(Id)
);INSERT INTO Proveedor(Id,Nombre) VALUES(1,'Sony');
INSERT INTO Proveedor(Id,Nombre) VALUES(2,'Creative Labs');
INSERT INTO Proveedor(Id,Nombre) VALUES(3,'Hewlett-Packard');
INSERT INTO Proveedor(Id,Nombre) VALUES(4,'Iomega');
INSERT INTO Proveedor(Id,Nombre) VALUES(5,'Fujitsu');
INSERT INTO Proveedor(Id,Nombre) VALUES(6,'Winchester');
INSERT INTO Proveedor(Id,Nombre) VALUES(7,'Bose');

INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(1,'Hard drive',240,5);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(2,'Memory',120,6);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(3,'ZIP drive',150,4);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(4,'Floppy disk',5,6);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(5,'Monitor',240,1);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(6,'DVD drive',180,2);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(7,'CD drive',90,2);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(8,'Printer',270,3);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(9,'Toner cartridge',66,3);
INSERT INTO Producto(Id,Nombre,Precio,ProveedorId) VALUES(10,'DVD burner',180,2);

--	1. Seleccione los nombres de todos los productos de la tienda
SELECT Nombre FROM Producto;

--	2. Seleccione los nombres y los precios de todos los productos de la tienda.
SELECT Nombre, Precio FROM Producto;

--	3. Seleccione el nombre de los productos con un precio menor o igual a $200.
SELECT Nombre FROM Producto WHERE Precio <= 200;

--	4. Seleccione todos los productos con un precio entre $60 y $120.
SELECT * FROM Producto WHERE Precio < 120 AND Precio > 60;

--	5. Seleccione el nombre y el precio en centavos (es decir, el precio debe multiplicarse por 100).
SELECT Nombre, Precio, Precio * 100 AS Centavos FROM Producto;

--	6. Calcule el precio promedio de todos los productos.
SELECT ROUND(AVG(Precio),2) AS 'Promedio' FROM Producto;

--	7. Calcule el precio promedio de todos los productos con código de proveedor igual a 2.
SELECT ROUND(AVG(Precio),2) AS 'Promedio' FROM Producto WHERE ProveedorId = 2;

--	8. Calcule la cantidad de productos con un precio mayor o igual a $180.
SELECT COUNT(*) AS QProd FROM Producto WHERE Precio >= 180;

/*	9. Seleccione el nombre y precio de todos los productos con un precio mayor o igual a $180
	y ordene primero por precio (en orden descendente) y luego por nombre (en orden
	ascendente) */
SELECT Nombre, Precio FROM Producto WHERE Precio >= 180 ORDER BY Precio DESC, Nombre ASC;

--	10. Seleccione todos los datos de los productos, incluidos todos los datos del proveedor de cada producto. 
	-- Sin INNER JOIN 
SELECT * FROM Producto, Proveedor WHERE Producto.ProveedorId = Proveedor.Id;
	-- Con INNER JOIN
SELECT * FROM Producto INNER JOIN Proveedor ON Producto.ProveedorId = Proveedor.Id;

--	11. Seleccione el nombre del producto, el precio y el nombre del proveedor de todos los productos. 
	-- Sin INNER JOIN
SELECT Producto.Nombre, Precio, Proveedor.Nombre FROM Producto, Proveedor WHERE Producto.ProveedorId = Proveedor.Id; 
	-- Con INNER JOIN
SELECT Producto.Nombre, Precio, Proveedor.Nombre FROM Producto INNER JOIN Proveedor ON Producto.ProveedorId = Proveedor.Id;

--	12. Seleccione el precio promedio de los productos de cada proveedor, mostrando solo el código del proveedor 
SELECT ROUND(AVG(Precio),2) AS 'PrecioPromedio', ProveedorId FROM Producto GROUP BY ProveedorId;

--	13. Seleccione el precio promedio de los productos de cada proveedor, mostrando el nombre del proveedor.

--	14. Seleccione los nombres de los proveedores cuyos productos tienen un precio promedio mayor o igual a $150.

--	15. Seleccione el nombre y el precio del producto más barato.

--	16. Seleccione el nombre de cada proveedor junto con el nombre y precio de su producto más caro.

--	17. Seleccione el nombre de cada proveedor que tenga un precio promedio superior a $145 y contenga al menos 2 productos diferentes.

--	18. Agregue un nuevo producto: Altavoces, $70, proveedor 2.

--	19. Actualice el nombre del producto 8 a "Impresora láser".

--	20. Aplicar un 10% de descuento a todos los productos.

--	21. Aplique un descuento del 10% a todos los productos con un precio mayor o igual a $120