using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbYuranyVelasquez
{
    public interface IBiblioteca
    {
        void AgregarLibro(Libro libro);
        void MostrarCatalogo();
        void AgregarUsuario(Usuario usuario);
        void PrestarLibro(Libro libro, Usuario usuario);
        void DevolverLibro(Libro libro);

    }
}

