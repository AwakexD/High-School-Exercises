using System.Net;

namespace AbstractionExercise
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                if (input == "Stop")
                {
                    break;
                }

                string[] tokens = input.Split();

                if (tokens[0] == "Circle")
                {
                    Circle circle = new Circle(tokens[1], double.Parse(tokens[2]));
                    circle.GetName();
                    circle.Show();
                    Console.WriteLine($"Area: {circle.GetArea():f2}");
                }
                else
                {
                    Square square = new Square(tokens[1], double.Parse(tokens[2]));
                    square.GetName();
                    square.Show();
                    Console.WriteLine($"Area: {square.GetArea():f2}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
