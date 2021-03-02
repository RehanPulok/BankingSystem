using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        Address address;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = 1000; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance 
        {

            set { this.balance = value; }
            get { return this.balance; }
        }
        public Account(string accountName, double balance)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.accountNumber=this.accountNumber+1;
         

        }
        
    }
}
