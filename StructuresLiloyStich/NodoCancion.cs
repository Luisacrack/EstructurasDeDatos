namespace StructuresLiloyStich
{
    public class NodoCancion
    {
        public Cancion Cancion { get; set; }
        public NodoCancion? Siguiente { get; set; }

        public NodoCancion(Cancion cancion)
        {
            Cancion = cancion;
            Siguiente = null;

        }

    }
}