namespace BankAccount;

public class BancAccount
{
    public decimal Balance { get; set; }

    public BancAccount(decimal amount = 0)
    {
        this.Balance = amount;
    }

    public void Deposit(decimal cash)
    {
        if (cash <= 0)
        {
            throw new ArgumentException("Negative cash");
        }

        this.Balance += cash;
    }

    public void Credit(decimal cash)
    {
        if (cash <= 0)
        {
            throw new ArgumentException("Negative cash");
        }

        this.Balance += cash;
    }

    public void Increase(double percent)
    {
        if (percent <= 0)
        {
            throw new ArgumentException("Negative percent");
        }

        this.Balance = (this.Balance * (decimal)percent) / 100;
    }

    public void Bonus()
    {
        if (this.Balance >= 1000 && this.Balance <= 2000)
        {
            this.Balance += 100;
        }
        else if (this.Balance > 2000 && this.Balance <= 3000)
        {
            this.Balance += 200;
        }
        else if (this.Balance > 3000)
        {
            this.Balance += 300;
        }
    }
}