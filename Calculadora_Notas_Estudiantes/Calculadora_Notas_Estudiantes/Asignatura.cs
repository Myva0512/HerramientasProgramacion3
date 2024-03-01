using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Notas_Estudiantes
{
    public class Asignatura
    {
        // Propiedades de la clase Asignatura
        public string Nombre { get; set; } // Nombre de la asignatura
        public int Créditos { get; set; } // Número de créditos de la asignatura
        public List<Nota> Notas { get; set; } // Lista de notas asociadas a la asignatura

        // Constructor de la clase Asignatura
        public Asignatura(string nombre, int créditos)
        {
            Nombre = nombre;
            Créditos = créditos;
            Notas = new List<Nota>(); // Inicializa la lista de notas
        }

        // Método para agregar una nueva nota a la asignatura
        public void AgregarNota(string nombre, double valor, double porcentaje)
        {
            // Calcular el porcentaje acumulado de las notas existentes
            double porcentajeAcumulado = Notas.Sum(nota => nota.Porcentaje);

            // Verificar si el porcentaje acumulado más el porcentaje de la nueva nota supera el 100%
            if (porcentajeAcumulado + porcentaje > 100)
            {
                Console.WriteLine("No se puede agregar la nota. El porcentaje acumulado supera el 100%.");
            }
            else
            {
                Notas.Add(new Nota(nombre, valor, porcentaje)); // Agregar la nueva nota
                Console.WriteLine("Nota agregada con éxito.");
            }
        }

        // Método para calcular el promedio acumulado de todas las notas de la asignatura
        public double CalcularPromedioAcumulado()
        {
            double sumaNotas = 0; // Inicializa la suma de las notas
            double sumaPorcentajes = 0; // Inicializa la suma de los porcentajes

            // Itera sobre todas las notas de la asignatura
            foreach (var nota in Notas)
            {
                sumaNotas += nota.Valor * (nota.Porcentaje / 100); // Suma el producto de la nota y su porcentaje
                sumaPorcentajes += nota.Porcentaje; // Suma los porcentajes
            }

            // Calcula el promedio acumulado dividiendo la suma de notas entre la suma de porcentajes
            double promedio = sumaNotas / (sumaPorcentajes / 100);

            return promedio;
        }

    }

}
