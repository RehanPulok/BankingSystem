﻿using System;
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
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Transfer Money");
                Console.WriteLine("5. Account Information");
                Console.WriteLine("6. Exit");
                try
                {
                    int choosenOption = Convert.ToInt32(Console.ReadLine());
                    if (choosenOption == 1)
                    {
                        
                        Bank bank= new Bank();
                        bank.addAccount();


                    }
                    if (choosenOption == 2)
                    {
                        Console.Write("Enter your account number: ");
                        string user = Console.ReadLine();



                    }
                    if (choosenOption == 3)
                    {
                        Console.Write("Enter your account number: ");
                        string user = Console.ReadLine();

                    }
                    if (choosenOption == 4)
                    {
                        Console.WriteLine("0");

}
                    if (choosenOption == 5)
                    {
                        Console.WriteLine("0");


}
                    if (choosenOption == 6)
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
