namespace Polymorphism_Task;

public class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Cat("Gosho", "Meat");
        Animal dog = new Dog("Pehsho", "Whiskas");

        Console.WriteLine(cat.ExplainMyself());
        Console.WriteLine(dog.ExplainMyself());
    }
}