using System;

namespace ScoriaProject
{
    public class Lava
    {
        public int Temperature { get; set; }

        public Lava(int temperature)
        {
            Temperature = temperature;
        }

        public void Flow()
        {
            Console.WriteLine($"Lava flows at {Temperature}°C.");
        }
    }
}
