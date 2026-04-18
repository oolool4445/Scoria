using System;

namespace ScoriaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scoria Project!");

            Scoria rock = new Scoria("Volcanic Scoria", "Dark Red");
            rock.Describe();
            rock.Cool();

            Volcano volcano = new Volcano("Mount Ember");
            volcano.Erupt();

            Environment env = new Environment("Volcanic Field");
            env.Show();

            Console.ReadLine();
        }
    }
}
