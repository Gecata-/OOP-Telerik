namespace BankAccounts
{
    using System;

    public class LoanAccount : Account, IInterestAmmountCalculation, IAccount
    {
        public LoanAccount(Customer customer, decimal balance, decimal someInterestRate, DateTime dateOfOpenningTheAccount)
            : base(customer, balance, someInterestRate, dateOfOpenningTheAccount)
        {

        }

        //  Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.

        public override void InterestAmmountCalculate()
        {
            if ((DateTime.Today - this.DateOfOpenning).TotalDays/30  < 3 && this.CustomerType == Customer.Individual )
            {
                this.InterestRate = 0;
            }

            if ((DateTime.Today - this.DateOfOpenning).TotalDays/30  < 2 && this.CustomerType == Customer.Company)
            {
                this.InterestRate = 0;
            }

            base.InterestAmmountCalculate();
        }
    }
}
