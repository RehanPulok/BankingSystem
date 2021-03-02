using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Bank
    {
        public string bankName;

        public void addAccount()
            {
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

            Address adressOfUser= new Address(house,road,city,country);

            //IdGenerator id = new IdGenerator();
            Account account1= new Account(name, 0.0,adressOfUser,account1.IdGenerator());
            account1.showInformation();

        
        }
        public void deleteAccount(string userAccountNumber)
        {
            

        }
        public void transaction()
        {
            Console.WriteLine("Which type of transaction you want to do? ");
            Console.WriteLine("1. Transfer Money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Deposit Money");
            int choosenOption= int.Parse(Console.ReadLine());
            if (choosenOption == 2)
                    {
                        Console.Write("Enter your account number: ");
                        string userAccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        double withdrawMoney= int.Parse(Console.ReadLine());

                    }
            if (choosenOption == 3)
                    {
                        Console.Write("Enter your account number: ");
                        string userAccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter the amount you want to deposit: ");
                        double depositMoney= int.Parse(Console.ReadLine());
                }
            
            if (choosenOption == 1)
                    {
                        Console.WriteLine("Enter the account number you want to transfer credit: ");
                        int transferedAccount= int.Parse(Console.ReadLine());


                }


        }
        public void accountInformation(string userAccountNumber)
        {

        }
    }
}
