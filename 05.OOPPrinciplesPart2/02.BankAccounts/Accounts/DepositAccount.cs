//  Deposit accounts are allowed to deposit and with draw money.

namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IInterestAmmountCalculation, IDraw, IAccount
    {
        public DepositAccount(Customer customer, decimal balance,decimal someInterestRate, DateTime dateOfOpenningTheAccount)
            : base(customer, balance, someInterestRate, dateOfOpenningTheAccount)
        {

        }

        public void Draw(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("Sum for deposit must be positive number.");
            }
            if (this.Balance - sum < 0)
            {
                throw new ArgumentOutOfRangeException("You don`t have enough money.");
            }

            this.Balance -= sum;
        }

        //  Deposit accounts have no interest if their balance is positive and less than 1000.

        public override void InterestAmmountCalculate()
        {
            if (this.Balance < 1000)
            {
                this.InterestRate = 0;
            }

            base.InterestAmmountCalculate();
        }
    }
}
