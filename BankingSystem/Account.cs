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
        //public int idobject;
        public int id = 1000;
		int count = 0;

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
      
        public Account(string accountName, double balance, Address adress,int accountNumber)
        {
            //IdGenerator id = new IdGenerator();
            
            this.accountName = accountName;
            this.balance = balance;
            this.accountNumber=accountNumber;
            //idobject+=1;
            //AccountNumber= AccountNumber +idobject ;
            this.address=adress
            ;
         

        }
        public void withdraw(double amount)
        {
           
            if(balance>=amount)
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
            Console.WriteLine("Enter you account number: ");
            int userAccount= int.Parse(Console.ReadLine());


        }
      
		public int IdGenerator()
		{
			id = id + count;
			count+=1;
			return id;
		}
	
        public void showInformation()
        {
            Console.WriteLine(" Account Name:{0} \n Account Number: {1} \n Ballance: {2} ",accountName,accountNumber, balance);
        }
    }
}
