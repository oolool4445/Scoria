using System;

namespace ScoriaProject
{
    public class Volcano
    {
        public string Name { get; set; }

        public Volcano(string name)
        {
            Name = name;
        }

        public void Erupt()
        {
            Console.WriteLine($"{Name} is erupting and releasing lava!");
        }
    }
}
