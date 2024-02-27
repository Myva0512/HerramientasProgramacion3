using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbYuranyVelasquez
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public Usuario(String nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Usuario: {Nombre}";
        }
    }
}
