create database Biblioteca

use Biblioteca

create table Autores(
Id_Autor int ,
Nombre_Autor varchar(50),
Nacionalidad varchar (50),
Fecha_De_Nacimiento_autor varchar (50),
primary key (Id_Autor)

);

create table Usuarios(
Id_User int,
Nombre_User varchar(50),
Email varchar (50),
Fecha_De_Nacimiento_user varchar (50),
primary key (id_user)
);

create table Editoriales(
Id_editorial int,
Nombre_edit varchar (50),
Direccion varchar (80),
Fecha_de_Fundacion date,
primary key (Id_Editorial)
);

create table Categorias(
Id_categorias int,
Nombre_categorias varchar (50),
Descripcion varchar (50),
primary key (id_categorias)
);

create table Libros(
Id_libros int,
Titulo varchar (50),
Id_Autor int,
Id_Editorial int ,
Id_Categoria int,
Fecha_publicacion varchar (50),
primary key (id_libros),
foreign key (Id_Autor) references Autores(Id_Autor),
foreign key (Id_Editorial) references  Editoriales(Id_editorial),
foreign key (Id_Categoria ) references Categorias(Id_categorias)
);


create table Gestion_Biblio(
Id  int,
Nombre varchar (50),
Direccion varchar (50),
Numero_telefono varchar (50),
primary key (id)
);

-- Autores
INSERT INTO Autores (Id_Autor, Nombre_Autor, Nacionalidad, Fecha_De_Nacimiento_autor) VALUES
(1, 'Gabriel Garcia Marquez', 'Colombiana', '1927-03-06'),
(2, 'Haruki Murakami', 'Japonesa', '1949-01-12'),
(3, 'J.K. Rowling', 'Británica', '1965-07-31'),
(4, 'Stephen King', 'Estadounidense', '1947-09-21'),
(5, 'Agatha Christie', 'Británica', '1890-09-15'),
(6, 'Leo Tolstoy', 'Rusa', '1828-09-09'),
(7, 'Jane Austen', 'Británica', '1775-12-16'),
(8, 'Gabriel Garcia Marquez', 'Colombiana', '1927-03-06'),
(9, 'Mario Vargas Llosa', 'Peruana', '1936-03-28'),
(10, 'George Orwell', 'Británica', '1903-06-25'),
(11, 'Ernest Hemingway', 'Estadounidense', '1899-07-21'),
(12, 'Fyodor Dostoevsky', 'Rusa', '1821-11-11'),
(13, 'Mark Twain', 'Estadounidense', '1835-11-30'),
(14, 'Victor Hugo', 'Francesa', '1802-02-26'),
(15, 'Toni Morrison', 'Estadounidense', '1931-02-18'),
(16, 'Gabriel Garcia Marquez', 'Colombiana', '1927-03-06'),
(17, 'Virginia Woolf', 'Británica', '1882-01-25'),
(18, 'Albert Camus', 'Francés', '1913-11-07'),
(19, 'Emily Dickinson', 'Estadounidense', '1830-12-10'),
(20, 'Jorge Luis Borges', 'Argentino', '1899-08-24');

-- Usuarios
INSERT INTO Usuarios (Id_User, Nombre_User, Email, Fecha_De_Nacimiento_user) VALUES
(1, 'Maria', 'maria@example.com', '1990-05-15'),
(2, 'Juan', 'juan@example.com', '1985-08-20'),
(3, 'Luisa', 'luisa@example.com', '1992-03-10'),
(4, 'Carlos', 'carlos@example.com', '1988-11-25'),
(5, 'Ana', 'ana@example.com', '1995-06-30'),
(6, 'Pedro', 'pedro@example.com', '1994-02-08'),
(7, 'Laura', 'laura@example.com', '1987-09-12'),
(8, 'Diego', 'diego@example.com', '1991-07-18'),
(9, 'Sofia', 'sofia@example.com', '1993-04-05'),
(10, 'Pablo', 'pablo@example.com', '1986-12-22'),
(11, 'Elena', 'elena@example.com', '1989-10-28'),
(12, 'Jorge', 'jorge@example.com', '1996-01-07'),
(13, 'Marcela', 'marcela@example.com', '1990-07-14'),
(14, 'Roberto', 'roberto@example.com', '1984-09-03'),
(15, 'Fernanda', 'fernanda@example.com', '1992-11-19'),
(16, 'Gustavo', 'gustavo@example.com', '1983-04-17'),
(17, 'Valeria', 'valeria@example.com', '1993-08-23'),
(18, 'Andres', 'andres@example.com', '1985-12-01'),
(19, 'Lucia', 'lucia@example.com', '1994-06-08'),
(20, 'Daniel', 'daniel@example.com', '1987-02-11');

-- Editoriales
INSERT INTO Editoriales (Id_editorial, Nombre_edit, Direccion, Fecha_de_Fundacion) VALUES
(1, 'Penguin Random House', '123 Main St, New York', '1925-07-01'),
(2, 'HarperCollins', '456 Elm St, London', '1989-03-15'),
(3, 'Simon & Schuster', '789 Oak St, Los Angeles', '1924-05-10'),
(4, 'Hachette Livre', '101 Maple St, Paris', '1826-10-17'),
(5, 'Macmillan Publishers', '246 Cedar St, Sydney', '1843-09-11'),
(6, 'Scholastic Corporation', '369 Pine St, Boston', '1920-08-05'),
(7, 'Pearson Education', '852 Walnut St, Toronto', '1844-06-22'),
(8, 'Oxford University Press', '753 Birch St, Oxford', '1586-01-01'),
(9, 'Cambridge University Press', '951 Maple St, Cambridge', '1534-02-02'),
(10, 'Bloomsbury Publishing', '584 Oak St, London', '1986-12-10'),
(11, 'Wiley', '369 Elm St, Hoboken', '1807-02-07'),
(12, 'Houghton Mifflin Harcourt', '753 Walnut St, Boston', '1832-04-18'),
(13, 'Elsevier', '852 Cedar St, Amsterdam', '1880-03-05'),
(14, 'Springer Nature', '369 Maple St, Berlin', '1842-12-11'),
(15, 'Pearson PLC', '951 Pine St, London', '1844-09-08'),
(16, 'Palgrave Macmillan', '753 Cedar St, London', '1869-01-29'),
(17, 'MIT Press', '852 Elm St, Cambridge', '1932-07-01'),
(18, 'Taylor & Francis', '369 Birch St, Oxford', '1852-10-05'),
(19, 'John Wiley & Sons', '951 Walnut St, Hoboken', '1807-02-07'),
(20, 'Routledge', '852 Oak St, London', '1836-01-01');

-- Categorias
INSERT INTO Categorias (Id_categorias, Nombre_categorias, Descripcion) VALUES
(1, 'Ficción Contemporánea', 'Novelas contemporáneas'),
(2, 'Literatura Clásica', 'Obras clásicas de la literatura'),
(3, 'Misterio y Suspense', 'Novelas de misterio y suspense'),
(4, 'Ciencia Ficción', 'Novelas de ciencia ficción'),
(5, 'Romance', 'Novelas románticas'),
(6, 'Fantasía', 'Novelas de fantasía'),
(7, 'No Ficción', 'Libros de no ficción'),
(8, 'Biografías', 'Biografías y memorias'),
(9, 'Autoayuda', 'Libros de autoayuda'),
(10, 'Historia', 'Libros de historia'),
(11, 'Poesía', 'Colecciones de poesía'),
(12, 'Negocios', 'Libros sobre negocios y finanzas'),
(13, 'Arte y Fotografía', 'Libros de arte y fotografía'),
(14, 'Cocina', 'Libros de cocina y gastronomía'),
(15, 'Viajes', 'Libros de viajes y aventuras'),
(16, 'Infantil', 'Libros infantiles y juveniles'),
(17, 'Religión y Espiritualidad', 'Libros religiosos y espirituales'),
(18, 'Política', 'Libros de política y sociedad'),
(19, 'Tecnología', 'Libros sobre tecnología e informática'),
(20, 'Salud y Bienestar', 'Libros de salud y bienestar');

-- Libros
INSERT INTO Libros (Id_libros, Titulo, Id_Autor, Id_Editorial, Id_Categoria, Fecha_publicacion) VALUES
(1, 'Cien años de soledad', 1, 1, 1, '1967-05-30'),
(2, 'Norwegian Wood', 2, 2, 1, '1987-08-04'),
(3, 'Harry Potter y la piedra filosofal', 3, 3, 6, '1997-06-26'),
(4, 'It', 4, 4, 3, '1986-09-15'),
(5, 'Asesinato en el Orient Express', 5, 5, 3, '1934-01-01'),
(6, 'Guerra y paz', 6, 6, 2, '1869-01-01'),
(7, 'Orgullo y prejuicio', 7, 2, 2, '1813-01-28'),
(8, 'Cronica de una muerte anunciada', 1, 1, 3, '1981-01-01'),
(9, 'La ciudad y los perros', 9, 7, 1, '1963-01-01'),
(10, '1984', 10, 8, 4, '1949-06-08'),
(11, 'El viejo y el mar', 11, 9, 7, '1952-09-01'),
(12, 'Crimen y castigo', 12, 10, 2, '1866-01-01'),
(13, 'Las aventuras de Tom Sawyer', 13, 11, 7, '1876-12-10'),
(14, 'Los miserables', 14, 4, 2, '1862-01-01'),
(15, 'Beloved', 15, 3, 1, '1987-09-02'),
(16, 'El amor en los tiempos del cólera', 1, 1, 5, '1985-01-01'),
(17, 'La señora Dalloway', 16, 2, 1, '1925-01-14'),
(18, 'El extranjero', 17, 4, 1, '1942-01-01'),
(19, 'La metamorfosis', 19, 14, 3, '1915-01-01'),
(20, 'En busca del tiempo perdido', 20, 16, 2, '1913-01-01');


-- Gestion_Biblio
INSERT INTO Gestion_Biblio (Id, Nombre, Direccion, Numero_telefono) VALUES
(1, 'Biblioteca Central', 'Av. Libertador 123', '555-1234'),
(2, 'Biblioteca Nacional', 'Calle 9 de Julio 456', '555-5678'),
(3, 'Biblioteca Pública', 'Av. Rivadavia 789', '555-9012'),
(4, 'Biblioteca Municipal', 'Calle San Martín 1011', '555-3456'),
(5, 'Biblioteca Universitaria', 'Av. Córdoba 1213', '555-7890'),
(6, 'Biblioteca Escolar', 'Av. Entre Ríos 1415', '555-2345'),
(7, 'Biblioteca Infantil', 'Calle Moreno 1617', '555-6789'),
(8, 'Biblioteca Virtual', 'Av. Corrientes 1819', '555-0123'),
(9, 'Biblioteca Digital', 'Calle Reconquista 2021', '555-4567'),
(10, 'Biblioteca Itinerante', 'Av. San Juan 2223', '555-8901'),
(11, 'Biblioteca Comunitaria', 'Calle Defensa 2425', '555-2345'),
(12, 'Biblioteca Popular', 'Av. Callao 2627', '555-6789'),
(13, 'Biblioteca Científica', 'Calle Suipacha 2829', '555-0123'),
(14, 'Biblioteca Cultural', 'Av. Santa Fe 3031', '555-4567'),
(15, 'Biblioteca Histórica', 'Calle Uruguay 3233', '555-8901'),
(16, 'Biblioteca Virtual', 'Av. Pueyrredón 3435', '555-2345'),
(17, 'Biblioteca Literaria', 'Calle Paraná 3637', '555-6789'),
(18, 'Biblioteca Educativa', 'Av. San Martín 3839', '555-0123'),
(19, 'Biblioteca Multicultural', 'Calle Lavalle 4041', '555-4567'),
(20, 'Biblioteca Tecnológica', 'Av. Corrientes 4243', '555-8901');


-- consultas

--1
select *
from Autores inner join Libros on
Autores.Id_Autor = Libros.Id_Autor
where Autores.Nombre_Autor = 'Gabriel Garcia Marquez' 

--2
select * from
Libros inner join Categorias on
Libros.Id_Categoria = Categorias.Id_categorias
where Categorias.Id_categorias = '3'

--3
select * from
Libros inner join Autores on
Libros.Id_Autor  = Autores.Id_Autor
where Autores.Nombre_Autor = 'Gabriel Garcia Marquez' and Libros.Fecha_publicacion ='1970'

--4
select * from
Libros inner join Categorias on
Libros.Id_Categoria = Categorias.Id_categorias
where Categorias.Nombre_categorias = 'terror' and Libros.Fecha_publicacion = '1976'

--5
select * from 
Libros 
where Titulo like '%Harry%'

--6
CREATE PROCEDURE CalcularLibrosPorEditorial
    @NombreEditorial VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EditorialId INT;

    -- Obtener el Id de la editorial basado en el nombre proporcionado
    SELECT @EditorialId = Id_editorial FROM Editoriales WHERE Nombre_edit = @NombreEditorial;

    -- Contar la cantidad de libros publicados por la editorial específica
    SELECT COUNT(*) AS CantidadLibros
    FROM Libros
    WHERE Id_Editorial = @EditorialId;
END;
GO

EXEC CalcularLibrosPorEditorial 'Penguin Random House';

--7
CREATE PROCEDURE LibrosMasRecientesPorCategoria
    @NombreCategoria VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Obtener el Id de la categoría basado en el nombre proporcionado
    DECLARE @CategoriaId INT;
    SELECT @CategoriaId = Id_categorias FROM Categorias WHERE Nombre_categorias = @NombreCategoria;

    -- Seleccionar los libros más recientes por categoría ordenados por fecha de publicación
    SELECT *
    FROM Libros
    WHERE Id_Categoria = @CategoriaId
    AND Fecha_publicacion = (
        SELECT MAX(Fecha_publicacion)
        FROM Libros
        WHERE Id_Categoria = @CategoriaId
    );
END;
GO

EXEC LibrosMasRecientesPorCategoria 'Fantasía';
