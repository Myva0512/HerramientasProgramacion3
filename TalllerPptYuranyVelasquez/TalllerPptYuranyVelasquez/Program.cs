using System;
using System.Security.Cryptography.X509Certificates;

namespace TallerPptYuranyVelasquez
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "tijera", "papel", "piedra" };
            Random ram = new Random();
            

            Console.WriteLine("Bienvenido a Piedra, Papel o Tijera");
            Console.WriteLine();

            do
            {
                int turnosPerdidos = 0;
                for (int intento = 1; intento <= 5; intento++)
                {
                    Console.WriteLine("\nIntento " + intento + ":");
                    Console.WriteLine();
                    Console.WriteLine("Elige una de las siguientes opciones:");
                    Console.WriteLine();
                    Console.WriteLine("Ingresa solo valores enteros");
                    Console.WriteLine();
                    for (int i = 0; i < opciones.Length; i++)
                    {
                        Console.WriteLine(i + ". " + opciones[i]);
                        Console.WriteLine();
                    }

                    int optionJugador;
                    if (!int.TryParse(Console.ReadLine(), out optionJugador) || optionJugador < 0 || optionJugador >= opciones.Length)
                    {
                        Console.WriteLine("Opción inválida. Pierdes un turno.");
                        Console.WriteLine();
                        turnosPerdidos++;
                        if (turnosPerdidos >= 5)
                        {
                            Console.WriteLine("Has superado el límite de intentos fallidos.");
                            break;
                        }
                        continue;
                    }


                    int optioncpu = ram.Next(0, 3);
                   
                    Console.WriteLine("\nEl jugador eligió " + opciones[optionJugador]);
                    Console.WriteLine();
                    Console.WriteLine("La CPU eligió " + opciones[optioncpu]);
                    Console.WriteLine();

                    if ((optionJugador == 0 && optioncpu == 1) ||
                        (optionJugador == 1 && optioncpu == 2) ||
                        (optionJugador == 2 && optioncpu == 0))
                    {
                        Console.WriteLine("¡El jugador gana!");
                        Console.WriteLine();
                    }
                    else if (optionJugador == optioncpu)
                    {
                        Console.WriteLine("¡Empate!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("¡La CPU gana!");
                        Console.WriteLine();
                    }
                }

                if (turnosPerdidos >= 5)
                {
                    Console.WriteLine("¿Quieres jugar de nuevo? (S/N)");
                    Console.WriteLine();
                    string respuesta = Console.ReadLine().ToUpper();
                    if (respuesta != "S")
                        break;
                }
                else
                {
                    Console.WriteLine("\n¿Quieres jugar de nuevo? (S/N)");
                    Console.WriteLine();
                }

            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
