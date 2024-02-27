using System;

namespace TallerSgbYuranyVelasquez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Crear libros
            Libro libro1 = new Libro("El Señor de los Anillos", "J.R.R. Tolkien", "1954");
            Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez", "1967");
            Libro libro3 = new Libro("1984", "George Orwell", "1949");

            // Crear usuarios
            Usuario usuario1 = new Usuario("Juan");
            Usuario usuario2 = new Usuario("María");

            // Agregar libros al catálogo
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            // Mostrar catálogo
            biblioteca.MostrarCatalogo();

            // Agregar usuarios al sistema
            biblioteca.AgregarUsuario(usuario1);
            biblioteca.AgregarUsuario(usuario2);

            // Prestar un libro
            biblioteca.PrestarLibro(libro1, usuario1);

            // Intentar prestar el mismo libro con otro usuario
            biblioteca.PrestarLibro(libro1, usuario2);

            // Devolver libro
            biblioteca.DevolverLibro(libro1);

            // Prestar el libro devuelto
            biblioteca.PrestarLibro(libro1, usuario2);
        }
    }
}
