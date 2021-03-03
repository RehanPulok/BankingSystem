using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        protected int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        //public int idobject;
        //public int id = 1000;
		//int count = 0;

        //public int AccountNumber { get; set; } = 1000;

       
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
       
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
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Account()
            {
        }
      
        public Account(string accountName, double balance, int accountNumber, Address adress)
        {
            //IdGenerator id = new IdGenerator();
            
            this.accountName = accountName;
            this.balance = balance;
            //id=id+1;
           // this.accountNumber=id+1;
            //id=id+1;
            //idobject+=1;
            //AccountNumber= AccountNumber +idobject ;
            this.accountNumber= accountNumber ;
            this.address=adress
            ;
         

        }
        public void withdraw(double amount)
        {
           
            if(balance>=amount)
                {
                this.balance= this.balance-amount;
                Console.WriteLine("You have withdrawn {0} TK", amount);
                Console.WriteLine("Your current balance is:  ",this.balance );
            }
            else
            {
                Console.WriteLine("You dont have sufficient ballance");
            }
            

        }
        public void deposit(double amount)
        {
                   
            this.balance= this.balance+ amount;
            Console.WriteLine("You deposited {0} Tk",amount);
            Console.WriteLine("Your current balance : ",this.balance);
        }
        public void transfer(Account receiver, double amount)
        {
            if(amount<=balance)
            {
            Console.WriteLine("Amount Transferred: "+amount);
            
            this.balance -= amount;
            Console.WriteLine("Current Balance: " + this.balance);
            receiver.balance += amount;
            Console.WriteLine();
            }
            else
            {
            Console.WriteLine("Balance Transfer can not be done! Please Try Again.");
            }


        }
    
	
        public void showInformation()
        {
            Console.WriteLine(" Account Name:{0} \n Account Number: {1} \n Ballance: {2} ",accountName,accountNumber, balance);
            this.address.getAddress();
        }
    }
}
