using Xunit;

namespace StrykerDemo.Tests
{
    public class AccountTests
    {
        private Account _account = new();

        [Fact]
        public void GivenAccount_WhenOperationsPerformed_ThenBalanceShouldBeAsExpected()
        {
            _account.Deposit(100);
            _account.Withdraw(40);

            Assert.Equal(60, _account.GetBalance());
        }
    }
}
