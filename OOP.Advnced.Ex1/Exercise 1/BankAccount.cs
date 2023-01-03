using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP.Advnced.Ex1
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private double balance;
        private List<Transaction> transactions;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            this.balance = balance;
            this.transactions = new List<Transaction>();
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }   
            set { accountHolder = value; }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }
            balance += amount;
            
            Transaction transaction1 = new Transaction();
            transaction1.Amount = amount;
            transaction1.Timestamp = DateTime.Now;
            transaction1.Type = "Deposit";
            this.Transactions.Add(transaction1);                     
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Error");
            }
            balance -= amount;

            Transaction transaction2 = new Transaction();
            transaction2.Amount = amount;
            transaction2.Timestamp = DateTime.Now;
            transaction2.Type = "Withdraw";
            this.Transactions.Add(transaction2);

        }
        public double GetBalance()
        {
            return balance;
        }
      
        public List<Transaction> GetTransactionHistory()
        {
            return this.transactions.OrderBy(x => x.Timestamp).ToList();
        }
    }
}
