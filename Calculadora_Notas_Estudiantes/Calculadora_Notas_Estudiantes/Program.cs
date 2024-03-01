using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Notas_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia de la clase Promedio
            Promedio promedio = new Promedio();

            // Bucle que se ejecuta indefinidamente
            while (true)
            {
                // Mostrar el menú de opciones al usuario
                Console.WriteLine("Menú:");
                Console.WriteLine("");
                Console.WriteLine("1. Agregar nueva asignatura");
                Console.WriteLine("");
                Console.WriteLine("2. Agregar nota a asignatura");
                Console.WriteLine("");
                Console.WriteLine("3. Mostrar información de asignaturas");
                Console.WriteLine("");
                Console.WriteLine("4. Mostrar promedio acumulado de una asignatura");
                Console.WriteLine("");
                Console.WriteLine("5. Calcular valor de nota restante para alcanzar una nota deseada");
                Console.WriteLine("");
                Console.WriteLine("6. Calcular valor de nota necesario para alcanzar un porcentaje restante");
                Console.WriteLine("");
                Console.WriteLine("0. Salir");
                Console.WriteLine("");
                Console.Write("Seleccione una opción: ");
                Console.WriteLine("");

                // Leer la opción seleccionada por el usuario
                int opcion = Convert.ToInt32(Console.ReadLine());

                // Switch para manejar las diferentes opciones
                switch (opcion)
                {
                    case 1: // Agregar nueva asignatura
                            // Solicitar información al usuario y agregar la asignatura
                        Console.Write("Ingrese el nombre de la asignatura: ");
                        Console.WriteLine("");
                        string nombreAsignatura = Console.ReadLine();
                        Console.Write("Ingrese el número de créditos: ");
                        Console.WriteLine("");
                        int creditos = Convert.ToInt32(Console.ReadLine());
                        promedio.AgregarAsignatura(nombreAsignatura, creditos);
                        Console.WriteLine("Asignatura agregada con éxito.");
                        Console.WriteLine("");
                        break;

                    case 2: // Agregar nota a asignatura
                            // Verificar si hay asignaturas ingresadas
                        if (promedio.Asignaturas.Count == 0)
                        {
                            Console.WriteLine("No hay asignaturas ingresadas. Primero agregue una asignatura.");
                        }
                        else
                        {
                            // Solicitar al usuario que seleccione una asignatura
                            Console.WriteLine("Escoja el índice de la asignatura:");
                            for (int i = 0; i < promedio.Asignaturas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {promedio.Asignaturas[i].Nombre}");
                            }
                            Console.Write("Seleccione una asignatura: ");
                            int indiceAsignatura = Convert.ToInt32(Console.ReadLine()) - 1;

                            // Verificar si el promedio acumulado de la asignatura seleccionada es menor que 100
                            if (promedio.Asignaturas[indiceAsignatura].CalcularPromedioAcumulado() >= 100)
                            {
                                Console.WriteLine("El promedio de esta asignatura ya es 100%, no se pueden ingresar más notas.");
                            }
                            else
                            {
                                // Solicitar información al usuario y agregar la nota a la asignatura seleccionada
                                Console.Write("Ingrese el nombre de la nota: ");
                                string nombreNota = Console.ReadLine();
                                Console.Write("Ingrese el valor de la nota con una (,): ");
                                double valorNota = Convert.ToDouble(Console.ReadLine());
                                double porcentajeNota;
                                do
                                {
                                    Console.Write("Ingrese el porcentaje de la nota (1 a 100): ");
                                    porcentajeNota = Convert.ToDouble(Console.ReadLine());
                                } while (porcentajeNota < 1 || porcentajeNota > 100); // Validación del porcentaje

                                // Agregar la nota a la asignatura seleccionada
                                promedio.AgregarNota(indiceAsignatura, nombreNota, valorNota, porcentajeNota);
                            }
                        }
                        break;

                    case 3: // Mostrar información de asignaturas
                            // Verificar si hay asignaturas ingresadas
                        if (promedio.Asignaturas.Count == 0)
                        {
                            Console.WriteLine("No hay asignaturas ingresadas. Primero agregue una asignatura.");
                        }
                        else
                        {
                            // Mostrar la información de las asignaturas
                            Console.WriteLine("Información de asignaturas:");
                            promedio.Mostrar_Información_Asignaturas();
                        }
                        break;

                    case 4: // Mostrar promedio acumulado de una asignatura
                            // Verificar si hay asignaturas ingresadas
                        if (promedio.Asignaturas.Count == 0)
                        {
                            Console.WriteLine("No hay asignaturas ingresadas. Primero agregue una asignatura.");
                        }
                        else
                        {
                            // Mostrar el promedio acumulado de una asignatura seleccionada
                            Console.WriteLine("Escoja el índice de la asignatura:");
                            for (int i = 0; i < promedio.Asignaturas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {promedio.Asignaturas[i].Nombre}");
                            }
                            Console.Write("Seleccione una asignatura: ");
                            Console.WriteLine("");
                            int indicePromedio = Convert.ToInt32(Console.ReadLine()) - 1;
                            promedio.MostrarPromedioAsignatura(indicePromedio);
                        }
                        break;

                    case 5: // Calcular valor de nota restante para alcanzar una nota deseada
                            // Solicitar información al usuario y calcular el valor de la nota restante
                        if (promedio.Asignaturas.Count == 0)
                        {
                            Console.WriteLine("No hay asignaturas ingresadas. Primero agregue una asignatura.");
                        }
                        else
                        {
                            Console.WriteLine("Escoja el índice de la asignatura:");
                            for (int i = 0; i < promedio.Asignaturas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {promedio.Asignaturas[i].Nombre}");
                            }
                            Console.Write("Ingrese el índice de la asignatura: ");
                            int indiceAsignatura5 = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (indiceAsignatura5 < 0 || indiceAsignatura5 >= promedio.Asignaturas.Count)
                            {
                                Console.WriteLine("Índice de asignatura inválido.");
                                break;
                            }

                            Console.Write("Ingrese la nota deseada: ");
                            double notaDeseada5;
                            if (!double.TryParse(Console.ReadLine(), out notaDeseada5))
                            {
                                Console.WriteLine("Valor de nota deseada inválido.");
                                break;
                            }

                            double notaRestante5 = promedio.CalcularValorNotaPorcentajeRestante(indiceAsignatura5, notaDeseada5);
                            Console.WriteLine($"El valor de la nota restante necesario para alcanzar la nota deseada es: {notaRestante5}");
                        }
                        break;

                    case 6: // Calcular valor de nota necesario para alcanzar un porcentaje restante
                            // Verificar si hay asignaturas ingresadas
                        if (promedio.Asignaturas.Count == 0)
                        {
                            Console.WriteLine("No hay asignaturas ingresadas. Primero agregue una asignatura.");
                        }
                        else
                        {
                            // Solicitar información al usuario y calcular el valor de la nota necesaria
                            Console.WriteLine("Escoja el índice de la asignatura:");
                            for (int i = 0; i < promedio.Asignaturas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {promedio.Asignaturas[i].Nombre}");
                            }
                            Console.Write("Ingrese el índice de la asignatura: ");
                            Console.WriteLine("");
                            int indiceValorNota = Convert.ToInt32(Console.ReadLine()) - 1;
                            double porcentajeFaltante = promedio.CalcularPorcentajeFaltante(indiceValorNota);
                            if (porcentajeFaltante == 0)
                            {
                                Console.WriteLine("Ya se han ingresado todas las notas para esta asignatura.");
                            }
                            else
                            {
                                double notaDeseada6 = promedio.CalcularNotaDeseada(indiceValorNota);
                                Console.WriteLine($"La nota necesaria para obtener al menos 3.0 en la asignatura es: {notaDeseada6:F1}");
                            }
                        }
                        break;

                    case 0: // Salir del programa
                        Environment.Exit(0);
                        break;

                    default: // Opción no válida
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }

                Console.WriteLine(""); // Imprimir una línea en blanco para separar visualmente las salidas en la consola
            }

        }
    }
    
}

