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
           
            Account account1= new Account(name, 0.0,adressOfUser);

        
        }
    }
}
