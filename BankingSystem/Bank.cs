using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Bank
    {
        //public string bankName;
        private Account [] myBank= new Account [100];
        //int count;
        private string bankName;

	public string BankName
	{
		get { return bankName;}
		set { bankName = value;}
	}
        public Account[] MyBank
            {
                get{return this.myBank;}
            }

        public Bank(string bankName)
            {
                this.bankName= bankName;
                this.myBank=new Account[100];
            }

        public void AddAccount(Account account, string accountType)
            {
            /*
            Console.WriteLine("Enter the Name of the account holder: ");
            string name= Console.ReadLine();
            Console.WriteLine("Enter your country: ");
            string country= Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            string city= Console.ReadLine();
           Console.WriteLine("Enter your road no: ");
            int road= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your house no: ");
            int house= int.Parse(Console.ReadLine());
            */
            int index =0;
            for(int i=0; i<myBank.Length; i++)
            {

                if(myBank[i] == null)
                    {
                        myBank[i] = account;
                        
                        index = i;
                    Console.WriteLine("Account Added.");
                    Console.WriteLine("Account Number: "+myBank[index].AccountNumber);
                    Console.WriteLine();
                        break;
                    }
            }
            /*
            else
            {
            Console.WriteLine("Account Insertion Unsuccessful! Please try again.");
            Console.WriteLine();
            }
            */
            
            
           
            
            //Address adressOfUser= new Address(house,road,city,country);

            //Account account= new Account(name, 0.0,adressOfUser);
            
            //account.showInformation();
            /*
            Account[] accounts = new Account[100];
             
            accounts[count]=new Account(name, 0.0,adressOfUser);
            count=count+1;
           
            Account[] accounts = new Account[100];
            for(int i = 0; i < mybank.length; ++i)
            {
                array[i] = new Account();
            }
            
            //IdGenerator id = new IdGenerator();
            Account account1= new Account(name, 0.0,adressOfUser);
            account1.showInformation();
            Account account2= new Account(name, 0.0,adressOfUser);
          
            accounts[count].showInformation();
              */
        
        }
        /*
        public void DeleteAccount(int accountNumber)
        {
            for(int i=0; i<myBank.Length; i++)
            {
                if (myBank[i] != null)
                {
                    if (myBank[i].AccountNumber == accountNumber)
                    {
                        myBank[i] = null;
                        
                        Console.WriteLine("Account Deleted");
                        break;
                    }
                }
                Console.WriteLine("Deletion Unsuccesfull");
            }

        }
        */
        public void Transaction(string transactionType, int accountNumber, params dynamic[] arr)
        {
            //int c = 0;
            /*Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Transfer");
            Console.WriteLine("4. Exit");
            Console.Write("Enter An Option: ");

            transactionType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();*/

            int index = -1;

            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] != null)
                {
                    if (myBank[i].AccountNumber == accountNumber)
                    {
                        index = i;
                        
                        break;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Invalid Account.");
            }
            else
            {
                if (transactionType == "deposit")
                {
                    myBank[index].Deposit(arr[0]);
                }

                else if (transactionType == "withdraw")
                {
                    myBank[index].Withdraw(arr[0]);

                }
                else if (transactionType == "transfer")
                {
                    int receiver = -1;
                    for (int j = 0; j < myBank.Length; j++)
                    {
                        if (myBank[j] != null)
                        {
                            if (myBank[j].AccountNumber == arr[0])
                            {
                                receiver = j;
                                /*myBank[i] = null;
                                Check = 1;*/
                                break;
                            }
                        }
                    }
                    myBank[index].Transfer(myBank[receiver], arr[1]);
                }
            }
        }
        public void AccountInformation(int accountNumber)
        {
            int check = 0;
            for(int i =0; i<myBank.Length; i++)
            {
                if(myBank[i] ==null)
                {
                    continue;
                }
                else if(myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].ShowInformation();
                    check = 1;
                    break;
                }
            }
            if(check==0)
            {
                Console.WriteLine("Invalid Account");
            }
        }
    }
}
    
