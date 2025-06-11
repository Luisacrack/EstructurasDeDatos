 namespace StructuresLiloyStich
{
    public class PlayListHawaiana
    {
        private NodoCancion? Cabeza { get; set; }
        private NodoCancion? Cola { get; set; }

        public PlayListHawaiana()
        {
            Cabeza = null;
            Cola = null;

        }

        public void AddNewNode(Cancion newCancion)
        {
            NodoCancion NuevoNodo = new NodoCancion(newCancion);

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
            Console.WriteLine($"Cancion '{newCancion.Nombre}' ha sido ingresado en La Playlist.");
        }

        public void MostrarCanciones()
        {
            if (Cabeza == null)
            {
                Console.WriteLine("\nLa PlayList está vacía.");
                return;
            }

            NodoCancion? actual = Cabeza;
            Console.WriteLine("\n--- Contenido de la PlayList ---");
            while (actual != null)
            {
                if (actual.Cancion != null)
                {
                    actual.Cancion.MostrarDetalles();
                }
                else
                {
                    Console.WriteLine("  - [Playlist vacío o corrupto]");
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("------------------------------------------");
        }

        public void AgregarCancion(string nombre)
        {
            Cancion nuevoCancion = new Cancion(nombre);
            AddNewNode(nuevoCancion);
            Console.WriteLine($"\nCancion '{nombre}' agregado exitosamente.");
        }

        public bool EliminarCancion(string nombreCancionAEliminar)
        {
            if (Cabeza == null)
            {
                Console.WriteLine("\nLa lista está vacía. No hay Pokémon para eliminar.");
                return false;
            }

            if (Cabeza.Cancion != null && Cabeza.Cancion.Nombre.Equals(nombreCancionAEliminar, StringComparison.OrdinalIgnoreCase))
            {
                Cabeza = Cabeza.Siguiente;
                if (Cabeza == null)
                {
                    Cola = null;
                }
                Console.WriteLine($"\nPokémon '{nombreCancionAEliminar}' eliminado exitosamente.");
                return true;
            }

            NodoCancion? actual = Cabeza;
            NodoCancion? anterior = null;

            while (actual != null && (actual.Cancion == null || !actual.Cancion.Nombre.Equals(nombreCancionAEliminar, StringComparison.OrdinalIgnoreCase)))
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine($"\nCancion '{nombreCancionAEliminar}' no encontrado en la lista.");
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

            Console.WriteLine($"\nCancion '{nombreCancionAEliminar}' eliminado exitosamente.");
            return true;
        }
    }
}