
namespace EstructurasDeDatos 
{
    public class Nodo
    {
        public Item Item { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(Item item)
        {
            Item = item;
            Siguiente = null;

        }

    }
}
 