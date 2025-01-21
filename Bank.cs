using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Bank
    {
        public BankAccount[] ArmBank { get; set; }
        private int count = 0;

        public Bank(int size)
        {
            ArmBank = new BankAccount[size];
        }

        public void AddAccount(BankAccount account) 
        {
            ArmBank[count++] = account;
        }

        public void DisplayAccounts()
        {
            for (int i = 0; i < count; i++)
            {
                if (ArmBank[i] != null)
                {
                    Console.Write($"{ArmBank[i].AccountHolderName} |{ArmBank[i].AccountNumber} - {ArmBank[i].Balance} \n");
                }
            }
        }

        public void FindAccountByNumber(double number) 
        {
            for (int i = 0; i < count; i++) 
            {
                if (ArmBank[i].AccountNumber == number)
                {
                    Console.Write($"{ArmBank[i].AccountHolderName} | {ArmBank[i].AccountNumber} | {ArmBank[i].Balance} \n");
                    break;
                }
            }
        }

        public void DepositToAccount(int amount, double accountNumber)
        {
            for (int i = 0; i < count; i++) 
            {
                if (amount > 0 && accountNumber != 0 && accountNumber == ArmBank[i].AccountNumber)
                {
                    ArmBank[i].Deposit(amount);
                    return;
                }
            }

            throw new Exception("You entered invalid account number or amont");
        }

        public void WithdrawFromAccount(int amount, double accountNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (amount > 0 && accountNumber != 0 && accountNumber == ArmBank[i].AccountNumber)
                {
                    ArmBank[i].Withdraw(amount);
                    return;
                }
            }
            throw new Exception("You entered invalid account number or amont");
        }

    }
}
