using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> natruals = new List<string>();
            List<string> sharps = new List<string>();
            List<string> notes = new List<string>();

            var sumNaturals = 0.0;
            var sumSharps = 0.0;
            
            for (int i = 0; i < input.Count; i++)
            {
                notes.Add(NumbersToNotes(input[i]));
                if (NumbersToNotes(input[i]).Length > 1)
                {
                    sharps.Add(NumbersToNotes(input[i]));
                    sumSharps += input[i];
                }
                else
                {
                    natruals.Add(NumbersToNotes(input[i]));
                    sumNaturals += input[i];
                }
            }
            Console.WriteLine("Notes: {0}",String.Join(" ",notes));
            Console.Write("Naturals: ");
            Console.WriteLine(String.Join(", ",natruals));
            Console.Write("Sharps: ");
            Console.WriteLine(string.Join(", ",sharps));
            Console.WriteLine("Naturals sum: {0}",sumNaturals);
            Console.WriteLine("Sharps sum: {0}",sumSharps);
            
        }
        public static string NumbersToNotes(double input)
        {
            var noteName = "";
            if (input == 261.63)
            {
                noteName = "C";
                return noteName;
            }
            else if (input == 277.18)
            {
                noteName = "C#";
                return noteName;
            }
            else if (input == 293.66)
            {
                noteName = "D";
                return noteName;
            }
            else if (input == 311.13)
            {
                noteName = "D#";
                return noteName;
            }
            else if (input == 329.63)
            {
                noteName = "E";
                return noteName;
            }
            else if (input == 349.23)
            {
                noteName = "F";
                return noteName;
            }
            else if (input == 369.99)
            {
                noteName = "F#";
                return noteName;
            }
            else if (input == 392.00)
            {
                noteName = "G";
                return noteName;
            }
            else if (input == 415.30)
            {
                noteName = "G#";
                return noteName;
            }
            else if (input == 440.00)
            {
                noteName = "A";
                return noteName;
            }
            else if (input == 466.16)
            {
                noteName = "A#";
                return noteName;
            }
            else if (input == 493.88)
            {
                noteName = "B";
                return noteName;
            }
            else
            {
                return noteName;
            }
        }
        
    }
}
