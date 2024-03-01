using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Notas_Estudiantes
{
    public class Nota
    {
        // Propiedades de la clase Nota
        public string Nombre { get; set; } // Nombre de la nota
        public double Valor { get; set; } // Valor de la nota
        public double Porcentaje { get; set; } // Porcentaje de la nota

        // Constructor de la clase Nota
        public Nota(string nombre, double valor, double porcentaje)
        {
            Nombre = nombre;
            Valor = valor;
            Porcentaje = porcentaje;
        }
    }

}