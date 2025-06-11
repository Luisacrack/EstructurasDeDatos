namespace EstructuresPokemonList
{
    public class ListPokemon
    {
        private NodoPokemon? Cabeza { get; set; }
        private NodoPokemon? Cola { get; set; }

        public ListPokemon()
        {
            Cabeza = null;
            Cola = null;
        }

        public void AddNewNode(Pokemon newPokemon)
        {
            NodoPokemon NuevoNodo = new NodoPokemon(newPokemon);

            if (Cabeza == null)
            {
                Cabeza = NuevoNodo;
                Cola = NuevoNodo;
            }
            else
            {
                if (Cola != null)
                {
                    Cola.Siguiente = NuevoNodo;
                }
                Cola = NuevoNodo;
            }
            Console.WriteLine($"Pokémon '{newPokemon.Nombre}' ha sido ingresado en la lista.");
        }

        public void MostrarPokemons()
        {
            if (Cabeza == null)
            {
                Console.WriteLine("\nLa lista de Pokémon está vacía.");
                return;
            }

            NodoPokemon? actual = Cabeza;
            Console.WriteLine("\n--- Contenido de la Lista de Pokémon ---");
            while (actual != null)
            {
                if (actual.Pokemon != null)
                {
                    actual.Pokemon.MostrarDetalles();
                }
                else
                {
                    Console.WriteLine("  - [Slot de Pokémon vacío o corrupto]");
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("------------------------------------------");
        }

        public void AgregarPokemon(string nombre, string tipo, int numero)
        {
            Pokemon nuevoPokemon = new Pokemon(nombre, tipo, numero);
            AddNewNode(nuevoPokemon);
            Console.WriteLine($"\nPokémon '{nombre}' agregado exitosamente.");
        }

        public bool EliminarPokemon(string nombrePokemonAEliminar)
        {
            if (Cabeza == null)
            {
                Console.WriteLine("\nLa lista está vacía. No hay Pokémon para eliminar.");
                return false;
            }

            // ¡CORRECCIÓN APLICADA AQUÍ!
            if (Cabeza.Pokemon != null && Cabeza.Pokemon.Nombre.Equals(nombrePokemonAEliminar, StringComparison.OrdinalIgnoreCase))
            {
                Cabeza = Cabeza.Siguiente;
                if (Cabeza == null)
                {
                    Cola = null;
                }
                Console.WriteLine($"\nPokémon '{nombrePokemonAEliminar}' eliminado exitosamente.");
                return true;
            }

            NodoPokemon? actual = Cabeza;
            NodoPokemon? anterior = null;

            while (actual != null && (actual.Pokemon == null || !actual.Pokemon.Nombre.Equals(nombrePokemonAEliminar, StringComparison.OrdinalIgnoreCase)))
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine($"\nPokémon '{nombrePokemonAEliminar}' no encontrado en la lista.");
                return false;
            }

            if (anterior != null)
            {
                anterior.Siguiente = actual.Siguiente;
            }

            if (actual == Cola)
            {
                Cola = anterior;
            }

            Console.WriteLine($"\nPokémon '{nombrePokemonAEliminar}' eliminado exitosamente.");
            return true;
        }
    }
}