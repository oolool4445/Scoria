using System;

namespace ScoriaProject
{
    public class Scoria
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Scoria(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Describe()
        {
            Console.WriteLine($"{Name} is a porous volcanic rock with a {Color} color.");
        }

        public void Cool()
        {
            Console.WriteLine($"{Name} forms as lava cools quickly with trapped gas bubbles.");
        }
    }
}
