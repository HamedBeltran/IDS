-- Cantidad de clientes en 2021 
SELECT COUNT(*) AS CantidadClientes2021 
FROM factura
WHERE YEAR(fecha) = 2021;

-- Cantidad de clientes en 2022
SELECT COUNT(*) AS CantidadClientes2022 
FROM factura
WHERE YEAR(fecha) = 2022;

-- Clientes que tuvieron compras en diciembre de 2021
SELECT DISTINCT c.*
FROM cliente c
JOIN factura f ON c.id_cliente = f.id_cliente
WHERE MONTH(f.fecha) = 12 AND YEAR(f.fecha) = 2021;

-- Compras realizadas por algunos clientes en específico
SELECT f.*, d.*
FROM factura f
JOIN detalle d ON f.id_detalle = d.id_detalle
WHERE f.id_cliente IN (2, 17,  24, 4, 11); 

-- Producto con más ventas:
SELECT TOP 1 p.*, SUM(d.cantidad) AS TotalVentas
FROM producto p
JOIN detalle d ON p.id_producto = d.id_producto
GROUP BY p.id_producto, p.nombre, p.precio, p.stock, p.id_categoria
ORDER BY CAST(p.nombre AS varchar(MAX)) ASC;


-- Producto con más cantidad en stock:
SELECT TOP 1 *
FROM producto
ORDER BY stock DESC;

-- Compras ordenadas por fecha:
SELECT f.*, d.*
FROM factura f
JOIN detalle d ON f.id_detalle = d.id_detalle
ORDER BY f.fecha;

-- Nombres de clientes ordenados alfabéticamente:
SELECT *
FROM cliente
ORDER BY nombre, apellido;

-- Cantidad de productos por categoría:
SELECT c.nombre AS Categoria, COUNT(*) AS CantidadProductos
FROM producto p
JOIN categoria c ON p.id_categoria = c.id_categoria
GROUP BY c.nombre;


-- Encargados en cada sucursal de Akira's Boutique: CHECAR
SELECT s.NombreSucursal, s.NombredeEncargado
FROM Sucursales s;



-- Empleados que trabajan en la sucursal "Constitución":
SELECT e.*
FROM Empleados e
JOIN Sucursales s ON e.idSucursal = s.idSucursal
WHERE s.NombreSucursal = 'Akira’s Boutique: Constitución';

-- Clientes mayores de 30 años:

SELECT *
FROM cliente
WHERE DATEDIFF(YEAR, fec_nac, GETDATE()) > 30;



ALTER TABLE producto
ALTER COLUMN stock varchar(100);

SELECT *
FROM Sucursales
