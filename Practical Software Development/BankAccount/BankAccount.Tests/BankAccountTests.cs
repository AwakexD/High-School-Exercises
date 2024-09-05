namespace BankAccount.Tests
{
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InitializeAccount()
        {
            BancAccount account = new BancAccount(50m);
            Assert.AreEqual(50m, account.Balance);
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            BancAccount account = new BancAccount();
            
            account.Deposit(2000m);

            Assert.AreEqual(2000m, account.Balance);
        }

        [Test]
        public void NegativeAmoutShouldThrowArgumentException()
        {
            BancAccount account = new BancAccount();
            decimal depositAmount = -100;

            Assert.Throws<ArgumentException>(() =>
            {
                account.Deposit(depositAmount);
            });
        }

        [Test]
        public void CreditShouldAddMoney()
        {
            BancAccount account = new BancAccount();
            account.Deposit(100);
            account.Credit(3000m);

            Assert.AreEqual(3100m, account.Balance);
        }

        [Test]
        public void CreditShouldThrowError()
        {
            BancAccount account = new BancAccount();
            Assert.Throws<ArgumentException>(() =>
            {
                account.Credit(-100);
            });
        }

        [Test]
        public void IncreaseShouldAddBalance()
        {
            BancAccount account = new BancAccount();
            account.Deposit(100);
            account.Increase(5);

            Assert.AreEqual(105, account.Balance);
        }

        [Test]
        public void BonusSouldAddBalance()
        {
            BancAccount account = new BancAccount();
            account.Deposit(1200);
            account.Bonus();

            Assert.AreEqual(1300, account.Balance);
        }
    }
}