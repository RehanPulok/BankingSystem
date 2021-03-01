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
                        Console.WriteLine("0");


                    }
                    if (choosenOption == 2)
                    {
                         Console.WriteLine("0");

                    }
                    if (choosenOption == 3)
                    {
                         Console.WriteLine("0");

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
                    

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please Choose a valid option");
                    menu = true;
                    Console.ReadLine();
                }
                
              
            }
        }
    }
}
