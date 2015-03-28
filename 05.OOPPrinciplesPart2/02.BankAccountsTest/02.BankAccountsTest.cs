//Problem 2. Bank accounts

//A bank holds different types of accounts for its customers: deposit accounts,
//loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). 
//In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and
//implement the calculation of the interest functionality through overridden methods.

namespace BankAccountsTest
{
    using BankAccounts;

    using System;
    using System.Collections.Generic;

    public class BankAccountsTest
    {
        static void Main()
        {
            var accounts = new List<IAccount>
            {
                {new DepositAccount(Customer.Company, 100000,5,DateTime.Parse("01.01.2015"))},
                {new DepositAccount(Customer.Individual, 98,3,DateTime.Parse("01.01.2011"))},
                {new LoanAccount(Customer.Company, 10000000,46,DateTime.Parse("05.04.2008"))},
                {new LoanAccount(Customer.Individual, 205,7,DateTime.Parse("01.03.2015"))},
                {new LoanAccount(Customer.Individual, 205,7,DateTime.Parse("01.01.2014"))},
                {new MortgageAccount(Customer.Company, 9999999999,100,DateTime.Parse("01.02.2015"))},
                {new MortgageAccount(Customer.Company, 9999999999,100,DateTime.Parse("01.01.2011"))},
                {new MortgageAccount(Customer.Individual, 500,12,DateTime.Parse("01.01.2015"))}
            };

            foreach (var client in accounts)
            {
                client.InterestAmmountCalculate();
                Console.WriteLine(client);
            }

            var koi = new LoanAccount(Customer.Company, 10000000, 46, DateTime.Parse("05.04.2008"));

            koi.InterestAmmountCalculate();
            Console.WriteLine(koi);

        }
    }
}
