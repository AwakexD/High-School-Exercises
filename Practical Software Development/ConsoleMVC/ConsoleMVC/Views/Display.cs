namespace ConsoleMVC.Views
{
    public class Display
    {
        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }

        public double Percent { get; set; }

        public double Amount { get; set; }

        public double Total { get; set; }

        public double TipAmount { get; set; }

        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal: ");
            this.Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip: ");
            this.Percent = double.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {this.TipAmount}");
            Console.WriteLine($"The total will be {this.Total}");
        }
    }
}
