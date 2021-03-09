using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    abstract class Account
    {
        protected int accountNumber;
        private string accountName;
        private string dateofBirth;
        private double balance;
        protected int accountTransactions;
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
        public int AccountTransactions
        {
            set { this.accountTransactions = value; }
            get { return this.accountTransactions; }
        }
        public string DateOfBirth
        {
            set { this.dateofBirth = value; }
            get { return this.dateofBirth; }
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
      
        public Account(string accountName, double balance, int accountNumber,string dateofBirth,  Address adress)
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
            this.dateofBirth = dateofBirth;
            //this.accountTransactions = accountTransactions;
            this.address=adress
            ;
         

        }
        //public abstract void Withdraw(double amount);
        
        public abstract void Withdraw(double amount)
        {
           
            if(amount>0 && balance>=amount)
                {
                this.balance= this.balance-amount;
                Console.WriteLine("You have withdrawn {0} TK", amount);
               // Console.WriteLine("Your current balance is:  ",this.balance );
            }
            else
            {
                Console.WriteLine("You dont have sufficient ballance");
            }
            

        }
        
        public void Deposit(double amount)
        {

            if (amount > 0)
            {
                this.balance = this.balance + amount;
                Console.WriteLine("You deposited {0} Tk", amount);
                Console.WriteLine("Your current balance : ", this.balance);
                this.accountTransactions++;

            }
            else
            {
                Console.WriteLine("Deposit Unsuccessful");
            }    

        }
        public abstract void Transfer(Account receiver, double amount)
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
    
	
        public abstract void ShowInformation()
        {
            Console.WriteLine(" Account Name:{0} \n Account Number: {1} \n Ballance: {2} ",accountName,accountNumber, balance);
            this.address.GetAddress();
        }
    }
}
