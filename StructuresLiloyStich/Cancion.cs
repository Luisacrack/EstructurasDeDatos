namespace StructuresLiloyStich
{
    public class Cancion
    {
        public string Nombre { get; set; }


        public Cancion(string nombre)
        {
            Nombre = nombre;

        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"  - {Nombre} ");
        }

    }
}
