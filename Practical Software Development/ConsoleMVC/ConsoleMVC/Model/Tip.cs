namespace ConsoleMVC.Model
{
    public class Tip
    {
        public Tip() : this(0, 0) { }

        public Tip(double amount, double percent)
        {
            if (percent > 1)
            {
                this.Percent = percent / 100;   
            }

            this.Amount = amount;
            this.Percent = percent;
        }

        public double Amount { get; set; }

        public double Percent { get; set; }

        public double CalculateTip()
        {
            return this.Amount * this.Percent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() * +this.Amount;
        }
    }
}
