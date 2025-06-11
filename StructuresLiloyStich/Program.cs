using System;

namespace StructuresLiloyStich
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Bienvenido a la PLAYLIST de LILO Y STICH ---");

            PlayListHawaiana Cancion = new PlayListHawaiana();

            Cancion Cancion1 = new Cancion("Hawaiian Roller Coaster Ride" );
            Cancion Cancion2 = new Cancion("Burning Love");
            Cancion Cancion3 = new Cancion("He Mele No Lilo");

            Cancion.AddNewNode(Cancion1);
            Cancion.AddNewNode(Cancion2);
            Cancion.AddNewNode(Cancion3);
            Cancion.MostrarCanciones();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Menú Principal PLAYLIST LILO & STICH ---");
                Console.WriteLine(" Presiona 1 si quieres AGREGAR una nueva Cancion");
                Console.WriteLine(" Presiona 2 si quieres SALTAR una Cancion ");
                Console.WriteLine(" Presiona 3 si quieres MOSTRAR las canciones de la Playlist");
                Console.WriteLine(" Presiona 5 si quieres SALIR de la Playlist");
                Console.Write("Por favor, introduce tu opción: ");

                string? opcionUsuario = Console.ReadLine();
                int num;

                bool esNumeroValido = int.TryParse(opcionUsuario, out num);

                if (esNumeroValido)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("\n--- AGREGAR NUEVO POKÉMON ---");
                            Console.Write("Nombre del Pokémon: ");
                            string? nombreNuevaCancion = Console.ReadLine() ?? "Desconocido";
                            Cancion.AgregarCancion(nombreNuevaCancion);
                            break;

                        case 2:
                            Console.WriteLine("\n--- SALTAR CANCION ---");
                            Console.Write("Nombre de la cancion a SALTAR: ");
                            string? nombreEliminarCancion = Console.ReadLine() ?? "";
                            if (!string.IsNullOrWhiteSpace(nombreEliminarCancion))
                            {
                                Cancion.EliminarCancion(nombreEliminarCancion);
                            }
                            else
                            {
                                Console.WriteLine("No se especificó ningún nombre de Cancion para eliminar.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("\n--- MOSTRAR CANCIONES ---");
                            Cancion.MostrarCanciones();
                            break;
                        case 4:
                            Console.WriteLine("\nSaliendo de la simulación de PlayList De Lilo&Stich. ¡Hasta la próxima!");
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Por favor, introduce un número entre 1 y 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, introduce un número.");
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}