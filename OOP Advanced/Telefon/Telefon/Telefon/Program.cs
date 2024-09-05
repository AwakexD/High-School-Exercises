using System.ComponentModel.Design;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<string> sites = Console.ReadLine().Split().ToList();
            StationatyPhone stPhoneList = new StationatyPhone();
            SmartPhone smPhone = new SmartPhone();
            foreach(var number in numbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stPhoneList.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smPhone.Call(number));
                    }
                    else Console.WriteLine("Invalid number!");
                }
                catch(ArgumentException ae)
                {
                    Console .WriteLine (ae.Message);
                }
            } 
        }
    }
}