namespace JivotinskoCarstvo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            Trainer trainer = new Trainer(cat);
            trainer.Make();

            trainer.Animal = dog;
            trainer.Make();

            cat.MakeNoise();
        }
    }
}