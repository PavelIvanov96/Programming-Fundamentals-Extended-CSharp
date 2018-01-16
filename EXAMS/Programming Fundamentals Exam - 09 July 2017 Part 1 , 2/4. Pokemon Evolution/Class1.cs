using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pokemon_Evolution
{
    public class Class

    {
       
        static void Main(string[] args)
        {
            List<Pokemons> result = new List<Pokemons>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "wubbalubbadubdub")
                {
                    break;
                }

                var pokemonName = tokens[0];
                var evolutionName = tokens[1];
                var evolutionIndex = int.Parse(tokens[2]);

                var re = new Pokemons
                {
                    Name = pokemonName,
                    Evolution = evolutionName,
                    Index = evolutionIndex
                };
                result.Add(re);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Evolution);
                Console.WriteLine(item.Index);
            }
        }
    }
    public class Pokemons
    {
        public string Name { get; set; }
        public string Evolution { get; set; }
        public int Index { get; set; }
    }
}
