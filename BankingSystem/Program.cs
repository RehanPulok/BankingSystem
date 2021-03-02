using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
               
        static void Main(string[] args)
        {
            bool menu = true;
            int number = 1;
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
                    int choosenOption = Convert.ToInt32(Console.ReadLine());
                    Bank bank= new Bank();
                    if (choosenOption == 1)
                    {
                        //IdGenerator id = new IdGenerator();
                        
                        
                        bank.addAccount();


                    }
                    
                    if (choosenOption == 2)
                    {
                        Console.Write("Enter your account number you want to delete: ");
                        string userAccountNumber = Console.ReadLine();
                        Console.WriteLine("0");


}
                    if (choosenOption == 3)
                    {
                        bank.transaction();
                       

                    }
                    if (choosenOption == 4)
                    {
                        Console.Write("Enter your account number: ");
                        string userAccountNumber = Console.ReadLine();
                        bank.accountInformation(userAccountNumber);

                    }
                    if (choosenOption == 5)
                    {
                        menu =false;
                       

                    }
                    else{
                        Console.WriteLine("Please enter a valid Number");
                    }
                    

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
