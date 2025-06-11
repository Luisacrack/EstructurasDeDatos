namespace EstructuresPokemonList 
{
    public class Pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }

        public Pokemon(string nombre,   string tipo, int numero)
        {
            Nombre = nombre;
            Tipo = tipo;
            Numero = numero;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"  - {Nombre} (x{Numero}): {Tipo}");
        }

    }
}
