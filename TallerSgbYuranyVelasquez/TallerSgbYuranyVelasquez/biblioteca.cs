using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbYuranyVelasquez
{
    public class Biblioteca : IBiblioteca
    {
        private List<Libro> catalogo;
        private List<Usuario> usuarios;

        public Biblioteca()
        {
            catalogo = new List<Libro>();
            usuarios = new List<Usuario>();
        }
        public void AgregarLibro(Libro libro)
        {
            catalogo.Add(libro);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (!usuarios.Contains(usuario))
            {
                usuarios.Add(usuario);
                Console.WriteLine($"Se agregó al usuario {usuario.Nombre} al sistema.");
            }
            else
            {
                Console.WriteLine("El usuario ya existe en el sistema.");
            }
        }

        public void DevolverLibro(Libro libro)
        {
            if (catalogo.Contains(libro))
            {
                if (!libro.Disponible)
                {
                    libro.Disponible = true;
                    Console.WriteLine($"Se devolvió el libro '{libro.Titulo}' a la biblioteca.");
                }
                else
                {
                    Console.WriteLine("El libro ya está disponible en la biblioteca.");
                }
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
            }
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("Catálogo de la Biblioteca:");
            foreach (var libro in catalogo)
            {
                Console.WriteLine(libro);
            }
        }

        public void PrestarLibro(Libro libro, Usuario usuario)
        {
            if (catalogo.Contains(libro))
            {
                if (libro.Disponible)
                {
                    libro.Disponible = false;
                    Console.WriteLine($"Se prestó el libro '{libro.Titulo}' a {usuario.Nombre}.");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible para ser prestado.");
                }
            }
            else
            {
                Console.WriteLine("El libro no está en el catálogo.");
            }

            // Remover al usuario de la lista si ya tiene el libro prestado
            usuarios.Remove(usuario);

        }
    }
}


