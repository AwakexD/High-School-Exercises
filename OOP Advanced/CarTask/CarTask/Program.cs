namespace CarTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.CalculateAnnualTax();

            Car car2 = new Car("Toyota", "Camry");
            car2.CalculateAnnualTax();

            Car car3 = new Car("BMW", "X5", 3000, 2015);
            car3.CalculateAnnualTax();

            Console.ReadLine();
        }
    }
}