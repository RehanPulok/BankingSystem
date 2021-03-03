using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static int userAcoountNumber,userHouseNo,userRoadNo;
        static string userAccountName, userCountry, userCity;
        static double userAccountbalance;
        private static int id =1000;

        public static void UserAccountDetail()
            {
            Console.Write("Please Enter your name: ");
            userAccountName= Console.ReadLine();
            Console.Write("Enter balace: ");
            userAccountbalance= double.Parse(Console.ReadLine());
            Console.Write("Enter your Country:  ");
            userCountry= Console.ReadLine();
            Console.Write("Enter your city:  ");
            userCity= Console.ReadLine();
            Console.Write("Enter your road no:  ");
            userHouseNo= int.Parse(Console.ReadLine());
            Console.Write("Enter your house no:  ");
            userRoadNo= int.Parse(Console.ReadLine());
            }
        
            public static int GenerateId()
            {

                id++;
                return id;
            }
               
        static void Main(string[] args)
        {

            bool menu = true;
            //int number = 1;
            Bank bank= new Bank();
            Console.Write("Bank Name: ");
            bank.BankName= Console.ReadLine();

            
            //int count;
            //public  List<Account> accounts = new List<Account>();
            while ( menu==true )
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Transaction");
                Console.WriteLine("4. Account Information");
                Console.WriteLine("5. Exit");
                try
                {
                    Console.Write("Enter Your Option: ");
                    int choosenOption = Convert.ToInt32(Console.ReadLine());
                    //Bank bank= new Bank();
                    if (choosenOption == 1)
                    {
                        UserAccountDetail();
                        id=GenerateId();
                        bank.AddAccount(new Account(userAccountName,userAccountbalance,id, new Address(userHouseNo,userRoadNo,userCity,userCountry)));

            
                    }
                    
                    if (choosenOption == 2)
                    {
                        Console.Write("Enter your account number you want to delete: ");
                        int userAccountNumber =int.Parse( Console.ReadLine());
                        bank.DeleteAccount(userAccountNumber);


                    }
                    if (choosenOption == 3)
                    {
                        Console.WriteLine("Which type of transaction you want to do? ");
                        Console.WriteLine("1. Transfer Money");
                        Console.WriteLine("2. Withdraw money");
                        Console.WriteLine("3. Deposit Money");
                        Console.Write("Enter Your Option: ");
                        int option= int.Parse(Console.ReadLine());
                        Console.Write("Enter your account number: ");
                        int  userAccountNumber = int.Parse(Console.ReadLine());
                        bank.Transaction(userAccountNumber,option);
                    }
                    if (choosenOption == 4)
                    {
                        Console.Write("Enter your account number: ");
                        int userAccountNumber = int.Parse(Console.ReadLine());
                        bank.AccountInformation(userAccountNumber);

                    }
                    if (choosenOption == 5)
                    {
                        menu =false;
                       

                    }
                    /*
                    else{
                        Console.WriteLine("Please enter a valid Number");
                    }
                    */
                    

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter a valid number");
                    menu = true;
                    Console.ReadLine();
                }
                
              
            }
        }
    }
}
