using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<Pokemons>>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "wubbalubbadubdub")
                {
                    break;
                }
                if (tokens.Length == 1)
                {
                    var name = tokens[0];

                    if (dic.ContainsKey(name))
                    {
                        Console.WriteLine("# {0}",name);
                        foreach (var item in dic[name])
                        {
                            Console.WriteLine("{0} <-> {1}",item.EvolutionName,item.Index);
                        }
                    }
                }
                else
                {
                    var pokemonName = tokens[0];
                    var evolutionName = tokens[1];
                    var evolutionIndex = int.Parse(tokens[2]);

                    var newEvolution = new Pokemons();
                    newEvolution.EvolutionName = evolutionName;
                    newEvolution.Index = evolutionIndex;

                    if (!dic.ContainsKey(pokemonName))
                    {
                        dic[pokemonName] = new List<Pokemons>();
                    }
                    dic[pokemonName].Add(newEvolution);
                }
               
            }
            foreach (var item in dic)
            {
                Console.WriteLine("# {0}",item.Key);
                foreach (var kvp in item.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine("{0} <-> {1}",kvp.EvolutionName,kvp.Index);
                }
            }
        }
    }
    public class Pokemons
    {
        
        public string EvolutionName { get; set; }
        public int Index { get; set; }
    }
}
