using System;

namespace EstructuresPokemonList 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Bienvenido a la lista de Pokémon ---");

            ListPokemon pokemons = new ListPokemon();

            Pokemon Pikachu = new Pokemon("Pikachu", "Eléctrico", 1);
            Pokemon Charmander = new Pokemon("Charmander", "Fuego", 4);
            Pokemon Bulbasaur = new Pokemon("Bulbasaur", "Planta/Veneno", 7);

            pokemons.AddNewNode(Pikachu);
            pokemons.AddNewNode(Charmander);
            pokemons.AddNewNode(Bulbasaur);
            pokemons.MostrarPokemons();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Menú Principal POKÉDEX ---");
                Console.WriteLine(" Presiona 1 si quieres AGREGAR un nuevo Pokémon");
                Console.WriteLine(" Presiona 2 si quieres ELIMINAR un Pokémon ");
                Console.WriteLine(" Presiona 3 si quieres MOSTRAR los pokemons de la lista");
                Console.WriteLine(" Presiona 4 si quieres SALIR DE LA POKEDEX");
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
                            string? nombreNuevoPokemon = Console.ReadLine() ?? "Desconocido";

                            Console.Write("Tipo del Pokémon: ");
                            string? tipoNuevoPokemon = Console.ReadLine() ?? "Desconocido";

                            Console.Write("Número (Nivel) del Pokémon: ");
                            int numeroNuevoPokemon;
                            while (!int.TryParse(Console.ReadLine(), out numeroNuevoPokemon))
                            {
                                Console.WriteLine("Entrada inválida. Por favor, introduce un número para el nivel:");
                                Console.Write("Número (Nivel): ");
                            }

                            pokemons.AgregarPokemon(nombreNuevoPokemon, tipoNuevoPokemon, numeroNuevoPokemon);
                            break;
                        case 2:
                            Console.WriteLine("\n--- ELIMINAR POKÉMON ---");
                            Console.Write("Nombre del Pokémon a eliminar: ");
                            string? nombreEliminarPokemon = Console.ReadLine() ?? "";
                            if (!string.IsNullOrWhiteSpace(nombreEliminarPokemon))
                            {
                                pokemons.EliminarPokemon(nombreEliminarPokemon);
                            }
                            else
                            {
                                Console.WriteLine("No se especificó ningún nombre de Pokémon para eliminar.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("\n--- MOSTRAR POKÉMONS ---");
                            pokemons.MostrarPokemons();
                            break;
                        case 4:
                            Console.WriteLine("\nSaliendo de la simulación de Pokémon. ¡Hasta la próxima!");
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