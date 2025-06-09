namespace EstructurasDeDatos 
{
    public class Item
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public Item(string nombre, int cantidad, string descripcion)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Descripcion = descripcion;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"  - {Nombre} (x{Cantidad}): {Descripcion}");
        }

    }
}
