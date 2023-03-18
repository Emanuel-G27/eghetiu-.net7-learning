



using OOP.Advanced.Ex5;
using System;

BankAccount account1 = new BankAccount("123456", "John Doe", 1000);
BankAccount account2 = new BankAccount("654321", "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); // Outputs 1500
Console.WriteLine(account2.Balance); // Outputs 1000

Console.WriteLine(account1.GetInterest()); // Outputs 15
Console.WriteLine(account2.GetInterest()); // Outputs 20

Console.WriteLine(Bank.NumAccounts); // Outputs 2