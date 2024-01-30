


CREATE TABLE  Empleados(
NombredelaPersona varchar(10) PRIMARY KEY, 
Direccion varchar(10) NOT NULL,
NumerodeTelefono varchar(10) NOT NULL,
Edad int NOT NULL,
Sucursal varchar(10) NOT NULL,
Correo varchar(10) NOT NULL,
Contrase�a 
)

CREATE TABLE Sucursales(
NumeroSucursal int PRIMARY KEY,
NombreSucursal varchar(10) NOT NULL,
NombredeEncargado varchar(10) NOT NULL,
Direccion varchar(10) NOT NULL,
NumerodeTelefono varchar(10) NOT NULL,
Ciudad varchar(10) NOT NULL,
Estado varchar(10) NOT NULL,
)

INSERT Sucursales (
1, 'Akira�s Boutique: Las Mercedes', 'Sonia Alejandra Fern�ndez Moreno', 'Calle Roble #507 Fracc. Las Mercedes', 4447831225, 'San Luis Potosi',  'San Luis Potosi', 
2, 'Akira�s Boutique: Obraje Fernando Calder�n Ayala', 'Calle Dr.Jes�s D�az de Le�n #438 col. Obraje', 4493780921, 'Aguascalientes', 'Aguascalientes',
3, 'Akira�s Boutique:Galer�as Mazatl�n Daniela Fernanda', 'D�az Ordaz Av. de la Marina #6204, Marina', local 356692932059, 'Mazatl�n', 'Sinaloa'
4, 'Akira�s Boutique:Zapopan Mario Alberto Jim�nez Salcido', 'Av. Manuel J. Clouthier 525 col. Benito Ju�rez', 3337841230, 'Zapopan', 'Jalisco'
5, 'Akira�s Boutique: Melchor Yesenia Guadalupe Campos Rojo', 'Av. Melchor Ocampo #2528 Zona Centro', 6143906721, 'Chihuahua, 'Chihuahua'
6, 'Akira�s Boutique: Constituci�n Tamara Alejandra Bernal Ramos', 'Calle Constituci�n #106 Zona Centro', 6181962954, 'Durango', 'Durango'
7, 'Akira�s Boutique: Centro Samuel Enrique Barrios', 'Enciso Av. Hidalgo #338 Zacatecas Centro', 4929301250, 'Zacatecas', 'Zacatecas'
)
