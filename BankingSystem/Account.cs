using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        protected int accountNumber=1000;
        private string accountName;
        private double balance;
        public Address address;
        public int idobject;

        public int AccountNumber { get; set; } = 1000;

        /*
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = 1000; }
        }
        */
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance 
        {

            set { this.balance = 0; }
            get { return this.balance; }
        }
        public Account(string accountName, double balance, Address adress)
        {
            
            this.accountName = accountName;
            this.balance = balance;
            idobject+=1;
            AccountNumber= AccountNumber +idobject ;
            this.address=adress
            ;
         

        }
        public void withdraw(double amount)
        {
            if(balance>amount)
                {
                balance= balance-amount;
            }
            else
            {
                Console.WriteLine("You dont have sufficient ballance");
            }
            

        }
        public void deposit(double amount)
        {
            balance= balance+ amount;
        }
        public void transfer(int accountNumber, double amount)
        {


        }
        public void showInformation()
        {
            Console.WriteLine("Account Name:{0} Account Number: {1} Ballance: {2} ",accountName,accountNumber, balance);
        }
    }
}
