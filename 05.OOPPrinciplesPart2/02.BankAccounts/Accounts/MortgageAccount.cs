namespace BankAccounts
{
    using System;

    public class MortgageAccount : Account, IInterestAmmountCalculation, IAccount
    {
        public MortgageAccount(Customer customer, decimal balance, decimal someInterestRate, DateTime dateOfOpenningTheAccoun)
            : base(customer, balance, someInterestRate, dateOfOpenningTheAccoun)
        {

        }

        //  Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

        public override void InterestAmmountCalculate()
        {
            if ((DateTime.Today - this.DateOfOpenning).TotalDays/30 < 12 && this.CustomerType == Customer.Company)
            {
                this.InterestRate /= 2;
            }
            if ((DateTime.Today - this.DateOfOpenning).TotalDays/ 30 < 6 && this.CustomerType == Customer.Individual)
            {
                this.InterestRate = 0;
            }

            base.InterestAmmountCalculate();
        }
    }
}
