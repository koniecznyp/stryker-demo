namespace StrykerDemo
{
    public class Account
    {
        private decimal _amount;

        public Account()
        {
            _amount = 0;
        }

        public decimal GetBalance()
            => _amount;

        public void Deposit(decimal amount)
        {
            if (amount < 0) 
                throw new ArgumentException("too low amount");

            _amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_amount < amount)
                throw new ArgumentException("Not enough money");

            _amount -= amount;
        }
    }
}
