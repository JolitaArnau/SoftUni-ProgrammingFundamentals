namespace Pr04PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Pr04PokemonEvolution
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var pokemons = new Dictionary<string, List<Pokemon>>();

            
            while (!line.Equals("wubbalubbadubdub"))
            {

                var pokemonTokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                
                var pokemonName = string.Empty;

                if (pokemonTokens.Length > 1)
                {
                    Pokemon pokemon = new Pokemon();

                    pokemonName = pokemonTokens[0];
                    pokemon.Type = pokemonTokens[1];
                    pokemon.Index = int.Parse(pokemonTokens[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Pokemon>();
                    }

                    pokemons[pokemonName].Add(pokemon);

                }

                else
                {
                    pokemonName = pokemonTokens[0];

                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolution in pokemons[pokemonName])
                        {

                            Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");

                        }
                    }
                }

                line = Console.ReadLine();

            }

            foreach (var kvp in pokemons)
            {
                Console.WriteLine($"# {kvp.Key}");

                foreach (var evolution in kvp.Value.OrderByDescending(e => e.Index))
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }

    public class Pokemon
    {
        public  string Type { get; set; }
        public  int Index { get; set; }
    }
}


