﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int duration = int.Parse(Console.ReadLine());

            for (int i = 0; i < duration; i++)
            {
                int numbToChar = int.Parse(Console.ReadLine());
                numbToChar = (char)numbToChar;
                Console.Write((char)numbToChar);
            }
        }
    }
}
