namespace BankAccounts
{
    using System;

    public class Account : IAccount, IInterestAmmountCalculation
    {
        private readonly Customer customer;
        private decimal balance;
        private DateTime dateOfOpenning;
        private decimal interestRate;
        private decimal interestAmount;

        public Account(Customer someCustomer, decimal someBalance,decimal someInterestRate, DateTime openningDate)
        {
            this.customer = someCustomer;
            this.balance = someBalance;
            this.interestRate = someInterestRate;
            this.dateOfOpenning = openningDate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance must be positive number.");
                }

                this.balance = value;
            }
        }

        public Customer CustomerType
        {
            get
            {
                return this.customer;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (this.interestRate<0 )
                {
                    throw new ArgumentOutOfRangeException("Interest rate must be positive number.");
                }

                this.interestRate = value;
            }
        }

        public decimal InterestAmmount
        {
            get
            {
                return this.interestAmount;
            }
        }

        public DateTime DateOfOpenning
        {
            get
            {
                return this.dateOfOpenning;
            }
        }

        public void Deposit(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("Sum for deposit must be positive number.");
            }

            this.balance += sum;
        }

        public virtual void InterestAmmountCalculate()
        {          
                decimal ammount = ((decimal)(DateTime.Today - dateOfOpenning).TotalDays/30) * this.interestRate;

                this.interestAmount = ammount;        
        }

        public override string ToString()
        {
            return string.Format("\nAccount type: {0} \nCustomer type: {1} \nBalance: {2} \nDate of opening the account: {3:dd.MM.yyyy} \nInterest rate: {4} \nInterest ammount: {5:F4}\n"
                ,GetType().Name, this.CustomerType.ToString(), this.Balance, this.DateOfOpenning,
                this.InterestRate, this.InterestAmmount);
        }
    }
}
