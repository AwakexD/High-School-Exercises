namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BancAccount bankAccount = new BancAccount();
            bankAccount.Deposit(100);
            Console.WriteLine(bankAccount.Balance);
        }
    }
}
