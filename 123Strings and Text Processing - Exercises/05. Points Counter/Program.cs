﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Points_Counter
{
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;
                return this.Name == other.Name;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Player>>();

            string input = Console.ReadLine();

            while (input != "Result")
            {
                string[] tokens = input.Split('|');
                string teamName;
                string playerName;
                int points = int.Parse(tokens[2]);

                if (IsTeamName(tokens[0]))
                {
                    teamName = tokens[0];
                    playerName = tokens[1];
                }
                else
                {
                    teamName = tokens[1];
                    playerName = tokens[0];
                }

                teamName = Unpollute(teamName);
                playerName = Unpollute(playerName);



                if (!data.ContainsKey(teamName))
                {
                    data[teamName] = new List<Player>();
                }
                Player currentPlayer = new Player(playerName, points);
                if (data[teamName].Contains(currentPlayer))
                {
                    int index = data[teamName].IndexOf(currentPlayer);
                    data[teamName][index].Points = points;
                } 
                else
                {
                   data[teamName].Add(currentPlayer);   
                }


                input = Console.ReadLine();
            }
            var orderedData = data.OrderByDescending(x => x.Value.Sum(p => p.Points));

            foreach (var teamData  in orderedData)
            {
                string teamName = teamData.Key;
                List<Player> players = teamData.Value;
                int totalPoints = players.Sum(p => p.Points);
                Player bestPlayer = players.OrderByDescending(x => x.Points).First();

                Console.WriteLine("{0} => {1}",teamName,totalPoints);
                Console.WriteLine("Most points scored by {0}",bestPlayer.Name);
            }
        }
        static string Unpollute(string name)
        {
            StringBuilder result = new StringBuilder();

            foreach (char symbol in name)
            {
                if (!IsPollutedChar(symbol))
                {
                    result.Append(symbol);
                }
            }

            return result.ToString();
        }
        static bool IsPollutedChar(char symbol)
        {
            return symbol == '@' || symbol == '%' || symbol == '$' || symbol == '*';
        }

        static bool IsTeamName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLower(name[i]))
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
