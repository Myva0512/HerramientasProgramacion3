using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Notas_Estudiantes
{
    public class Promedio
    {
        // Lista de asignaturas
        public List<Asignatura> Asignaturas { get; private set; }

        // Constructor
        public Promedio()
        {
            Asignaturas = new List<Asignatura>(); // Inicializa la lista de asignaturas
        }

        // Método para agregar una nueva asignatura
        public void AgregarAsignatura(string nombre, int créditos)
        {
            Asignaturas.Add(new Asignatura(nombre, créditos)); // Crea una nueva asignatura y la agrega a la lista
        }

        // Método para agregar una nota a una asignatura
        public void AgregarNota(int índiceAsignatura, string nombre, double valor, double porcentaje)
        {
            Asignaturas[índiceAsignatura].AgregarNota(nombre, valor, porcentaje); // Agrega una nueva nota a la asignatura seleccionada
        }

        // Método para mostrar la información de las asignaturas
        public void Mostrar_Información_Asignaturas()
        {
            // Itera sobre todas las asignaturas
            for (int i = 0; i < Asignaturas.Count; i++)
            {
                // Imprime información de la asignatura
                Console.WriteLine($"Índice: {i + 1}, Nombre: {Asignaturas[i].Nombre}, Créditos: {Asignaturas[i].Créditos}");
                Console.WriteLine("Notas:");
                // Itera sobre todas las notas de la asignatura
                foreach (var nota in Asignaturas[i].Notas)
                {
                    Console.WriteLine($"- {nota.Nombre}: {nota.Valor:F1}, {nota.Porcentaje}%");
                }
                Console.WriteLine(); // Imprime una línea en blanco para separar las asignaturas
            }
        }
        public void MostrarPromedioAsignatura(int índiceAsignatura)
        {
            var asignatura = Asignaturas[índiceAsignatura];
            double promedio = asignatura.CalcularPromedioAcumulado();
            Console.WriteLine($"Promedio acumulado de {asignatura.Nombre}: {promedio:F1}");
        }

        // Método para calcular el valor de la nota restante para alcanzar una nota deseada
        public double CalcularValorNotaPorcentajeRestante(int índiceAsignatura, double notaDeseada)
        {
            var asignatura = Asignaturas[índiceAsignatura];
            double sumaNotas = 0;
            double sumaPorcentajes = 0;

            foreach (var nota in asignatura.Notas)
            {
                sumaNotas += nota.Valor * (nota.Porcentaje / 100); // Suma el producto de la nota y su porcentaje
                sumaPorcentajes += nota.Porcentaje; // Suma los porcentajes
            }

            double porcentajeAcumulado = sumaPorcentajes / 100; // Convierte la suma de porcentajes a un decimal entre 0 y 1

            double porcentajeRestante = 1 - porcentajeAcumulado; // Asegurar que el porcentaje restante sea un decimal entre 0 y 1
            double notaRestante = (notaDeseada - sumaNotas) / porcentajeRestante;

            return notaRestante;
        }


        // Método para calcular la nota deseada para obtener al menos 3.0 en una asignatura
        public double CalcularNotaDeseada(int índiceAsignatura)
        {
            var asignatura = Asignaturas[índiceAsignatura];
            double porcentajeAcumulado = 0;
            double sumaNotas = 0;

            foreach (var nota in asignatura.Notas)
            {
                sumaNotas += nota.Valor * (nota.Porcentaje / 100);
                porcentajeAcumulado += nota.Porcentaje / 100; // Corrección: Dividir el porcentaje por 100
            }

            double porcentajeRestante = 1 - porcentajeAcumulado; // Corrección: Asegurar que el porcentaje restante sea un decimal entre 0 y 1
            double notaDeseada = (3.0 - sumaNotas) / porcentajeRestante;

            return notaDeseada;
        }

        public double CalcularPorcentajeFaltante(int índiceAsignatura)
        {
            var asignatura = Asignaturas[índiceAsignatura]; // Obtiene la asignatura seleccionada
            double porcentajeTotal = 0;

            // Calcula el porcentaje total de las notas
            foreach (var nota in asignatura.Notas)
            {
                porcentajeTotal += nota.Porcentaje;
            }

            return 100 - porcentajeTotal; // Devuelve el porcentaje faltante
        }
    }

}