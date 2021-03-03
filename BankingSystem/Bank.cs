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

        public Bank()
            {
                this.bankName= bankName;
                this.myBank=new Account[100];
            }

        public void addAccount(Account account)
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
        public void deleteAccount(int accountNumber)
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
        public void transaction(int accountNumber, int choosenOption)
        {
            
            if (choosenOption == 2)
                    {
                        
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        double withdrawMoney= double.Parse(Console.ReadLine());
               
                        for (int i =0;i<myBank.Length;i++)
                            {
                            if (myBank[i].AccountNumber==accountNumber)
                            {
                                myBank[i].withdraw(withdrawMoney);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Account Number.");
                            }

                        }
                        

                    }
            if (choosenOption == 3)
                    {
                        //Console.Write("Enter your account number: ");
                        //int userAccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the amount you want to deposit: ");
                        double depositMoney= double.Parse(Console.ReadLine());
                        for (int i =0;i<myBank.Length;i++)
                             {
                                  if (myBank[i].AccountNumber==accountNumber)
                                        {
                                            myBank[i].deposit(depositMoney);
                                            break;
                                        }
                                  else
                                        {
                                            Console.WriteLine("Invalid Account Number.");
                                        }

                             }
                        
                }
            
            if (choosenOption == 1)
                    {
                        Console.WriteLine("Enter the account number you want to transfer credit: ");
                        int transferedAccount= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the amount you want to transfer: ");
                        double amount= double.Parse(Console.ReadLine());
                        for (int i =0;i<myBank.Length;i++)
                             {
                                  if (myBank[i].AccountNumber==accountNumber)
                                        {
                                            myBank[i].transfer(myBank[i],amount);
                                            break;
                                        }
                                  else
                                        {
                                            Console.WriteLine("Invalid Account Number.");
                                        }

                             }


                }


        }
        public void accountInformation(int accountNumber)
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
                    myBank[i].showInformation();
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
    
