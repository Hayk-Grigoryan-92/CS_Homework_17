using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class BankAccount
    {
        public string AccountHolderName{get; set;}
        public double AccountNumber { get; set;}
        public int Balance {  get; set;}

        public BankAccount(string accountHolderName, double accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(int amount)
        {
            if (amount > 0) 
            {
                Balance += amount;
            }
            else
            {
                throw new Exception("You entered invalid amont for deposit");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("You entered invalid amont for withdraw");
            }
        }

        public void DisplayInfo()
        {
            Console.Write($"{AccountHolderName} | {AccountNumber} | {Balance} \n");
        }

    }
}
