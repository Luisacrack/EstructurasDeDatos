namespace EstructuresPokemonList
{
    public class NodoPokemon
    {
        public Pokemon Pokemon { get; set; }
        public NodoPokemon? Siguiente { get; set; }

        public NodoPokemon(Pokemon pokemon)
        {
            Pokemon = pokemon;
            Siguiente = null;

        }

    }
}