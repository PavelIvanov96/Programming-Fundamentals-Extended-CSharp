using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNames = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            var songs = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).
                    Select(x => x.Trim()).ToArray();


            var participantAwards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).
                    Select(x => x.Trim()).ToArray();

                if (input[0] == "dawn")
                {
                    break;
                }

                var participants = input[0];
                var song = input[1];
                var award = input[2];

                if (inputNames.Contains(participants) && songs.Contains(song))
                {
                    if (!participantAwards.ContainsKey(participants))
                    {
                        participantAwards[participants] = new HashSet<string>();
                    }
                    participantAwards[participants].Add(award);
                }
            }
            if (!participantAwards.Any())
            {
                Console.WriteLine("No awards");
            }

            var sorted = participantAwards.OrderByDescending(x => x.Value.Count());

            foreach (var kvp in sorted)
            {
                Console.WriteLine("{0}: {1} awards",kvp.Key,kvp.Value.Count);
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine("--{0}",item);
                }
            }
        }
    }
}
