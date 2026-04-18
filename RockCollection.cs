using System;
using System.Collections.Generic;

namespace ScoriaProject
{
    public class RockCollection
    {
        public List<string> Rocks { get; set; }

        public RockCollection()
        {
            Rocks = new List<string>();
        }

        public void AddRock(string rock)
        {
            Rocks.Add(rock);
            Console.WriteLine($"{rock} added to collection.");
        }

        public void ShowAll()
        {
            Console.WriteLine("Rock Collection:");
            foreach (var rock in Rocks)
            {
                Console.WriteLine($"- {rock}");
            }
        }
    }
}
