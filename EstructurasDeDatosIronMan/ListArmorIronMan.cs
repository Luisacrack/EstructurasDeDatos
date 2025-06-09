namespace EstructurasDeDatos 
{
    public class ListArmorIronman
    {
        private Nodo? Cabeza { get; set; }
        private Nodo? Cola { get; set; }
        public ListArmorIronman()
        {
            Cabeza = null;
            Cola = null;

        }
        public void AddNewNode()
        {

            Console.WriteLine("Ingrese el nombre dle item: ");
            string? nuevoNombreIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre dle item: ");
            string? nuevoNombreIngresado = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre dle item: ");
            string? nuevoNombreIngresado = Console.ReadLine();

            Nodo NuevoNodo = new Nodo(new Item());

          
            if (NuevoNodo.Item != null)
            {
                if (!string.IsNullOrWhiteSpace(nuevoNombreIngresado))
                {
                    NuevoNodo.Item.Nombre = nuevoNombreIngresado;
                }

            }
            else
            {
                Console.WriteLine("Advertencia: El Item en el NuevoNodo es nulo.");
            }


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
            Console.WriteLine("NODO INGRESADO");

        }
        public void MostrarItems()
        {
            if (Cabeza == null)
            {
                Console.WriteLine("La lista de armaduras de Iron Man está vacía.");
                return;
            }

            Nodo? actual = Cabeza;

            Console.WriteLine("Contenido de la Lista de Armaduras");

            while (actual != null)
            {
                if (actual.Item != null)
                {
                    actual.Item.MostrarDetalles();
                }
                else
                {
                    Console.WriteLine("  - [Slot de armadura vacío o corrupto]");
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("------------------------------------------");
        }

        public void AgregarComponente(string nombre, int cantidad, string descripcion)
        {
            Item nuevoComponente = new Item(nombre, cantidad, descripcion);
            AddNewNode(nuevoComponente); // Reutilizamos el método AddNewNode
            Console.WriteLine($"\nComponente '{nombre}' agregado exitosamente.");
        }
        
        public void EliminarComponente(string nombre)
        {
            if (Cabeza == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            
            if (Cabeza.Item != null)
            {
                Cabeza = Cabeza.Siguiente;
            }
        }

    }

}
 