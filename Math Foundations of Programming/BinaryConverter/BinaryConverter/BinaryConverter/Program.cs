namespace BinaryConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            int decimalNumber = BinaryToDecimal(binaryNumber);
            Console.WriteLine($"Двоична - {binaryNumber} : Десетична - {decimalNumber}");
        }
        static int BinaryToDecimal(string binary) //Input 10;
        {
            int decimalNumber = 0;
            int binaryBase = 2;
            int exponent = 0;

            //Reverse
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    // deicmalNumber = 2**1 = 1;
                    decimalNumber += (int)Math.Pow(binaryBase, exponent);
                }
                // binary[i] == 0 => exponent++ | exponet = 1;
                exponent++;
            }

            return decimalNumber;
        }
    }
}