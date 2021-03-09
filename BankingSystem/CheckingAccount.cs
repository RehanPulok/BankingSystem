using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class CheckingAccount : Account
    {

        public CheckingAccount(int accountNumber, string accountName, string dateofBirth, double balance, Address address) : base(accountName, balance, accountNumber, dateofBirth, address)
        {
            /*this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.DateOfBirth = dateofBirth;
            this.Balance = balance;
            this.Address = address;*/
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= base.Balance)
            {
                Console.WriteLine("Amount Withdrawn: " + amount + "BDT");
                base.Balance = base.Balance - amount;
                Console.WriteLine("Current Balance: " + base.Balance + "BDT");
                base.accountTransactions++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Amount Withdrawal Unsuccessful!! Please Try Again.");
                Console.WriteLine();
            }
        }

        public override void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= base.Balance)
            {
                Console.WriteLine("Amount Transferred: " + amount + " BDT");
                //balance -= amount;
                base.Balance -= amount;
                Console.WriteLine("Current Balance: " + base.Balance + " BDT");
                receiver.Balance += amount;
                base.accountTransactions++;
                receiver.AccountTransactions++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Balance Transfer Unsuccessful!! Please Try Again.");
                Console.WriteLine();
            }
        }

        public override void ShowInformation()
        {
          
            Console.WriteLine("**Information of Checking Account**");
            Console.WriteLine("Account No: " + base.AccountNumber);
            Console.WriteLine("Account Name: " + base.AccountName);
            Console.WriteLine("Date of Birth: " + base.DateOfBirth);
            Console.WriteLine("Account Balance: " + base.Balance);

            this.Address.GetAddress();
            Console.WriteLine("Account Transactions: " + base.accountTransactions);
        }

    }
}
