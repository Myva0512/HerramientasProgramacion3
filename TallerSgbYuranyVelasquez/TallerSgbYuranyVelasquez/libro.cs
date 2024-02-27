using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbYuranyVelasquez
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string AñoPublicacion { get; set; }
        public bool Disponible { get; set; }

        public Libro(string titulo, string autor, string añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Disponible = true;
        }



        //anula el método ToString() de la clase base. La anulación permite proporcionar una implementación específica de cómo deseo
        //que se represente el objeto cuando se convierte a una cadena.
        public override string ToString()
        {
            return $"Titulo: {Titulo}, Autor:{Autor}, Año de publicacion: {AñoPublicacion}, Disponibles: {Disponible}";
        }

    }
}

