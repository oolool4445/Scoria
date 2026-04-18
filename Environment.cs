using System;

namespace ScoriaProject
{
    public class Environment
    {
        public string Type { get; set; }

        public Environment(string type)
        {
            Type = type;
        }

        public void Show()
        {
            Console.WriteLine($"Environment: {Type}");
        }
    }
}
