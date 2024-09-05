using MilitaryElite.Models;

namespace MilitaryElite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                switch (command)
                {
                    case "Private":
                        AddPrivate(soldiers, commandArgs);
                        break;

                    case "Commando":
                        AddCommando(soldiers, commandArgs);
                        break;

                    case "LieutenantGeneral":
                        AddLieutenantGeneral(soldiers, commandArgs);
                        break;

                    // Add cases for other classes if needed

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }

            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
        static void AddPrivate(List<Soldier> soldiers, string[] args)
        {
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];
            double salary = double.Parse(args[4]);

            Private newPrivate = new Private(id, firstName, lastName, salary);
            soldiers.Add(newPrivate);
        }
        static void AddCommando(List<Soldier> soldiers, string[] args)
        {
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];
            double salary = double.Parse(args[4]);
            string corps = args[5];

            Commando newCommando = new Commando(id, firstName, lastName, salary, corps);
            soldiers.Add(newCommando);
        }

        static void AddLieutenantGeneral(List<Soldier> soldiers, string[] args)
        {
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];
            double salary = double.Parse(args[4]);
            List<int> privateIds = args.Skip(5).Select(int.Parse).ToList();

            LieutenantGeneral newLieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
            soldiers.Add(newLieutenantGeneral);
        }
    }
}
