using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.Ex5
{
    public class BankAccount 
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Error! The balance can't be lower than 0");
                }
                balance = value;
            }
        }
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
            Bank.NumAccounts += 1;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(balance < amount)
            {
                throw new Exception("Insuficient funds!");
            }
            balance -= amount;
        }
        public double GetInterest()
        {
           return Bank.CalculateInterest(this.balance);
        }
    }
}
