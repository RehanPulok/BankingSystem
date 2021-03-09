using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        private static int id = 0;
        public static int AutoGenerateId()
        {
            id++;
            return id;
        }
        static void Main(string[] args)
        {

            Console.Write("Enter Bank Name: ");
            string bankName = Console.ReadLine();

            Bank b = new Bank(bankName);

            int check = 0;
            while (true)
            {
                Console.WriteLine("open: Open a Bank Account");
                Console.WriteLine("account: Perform Transactions");
                Console.WriteLine("quit: Exit Application");

                Console.Write("Please Type to select an operation: ");
                string choice = Console.ReadLine().ToLower();

                Console.WriteLine();

                switch (choice)
                {
                    case "open":
                        int ok = 0;
                        while (true)
                        {
                            Console.WriteLine("savings: Open Savings Account");
                            Console.WriteLine("checking: Open Checking Account");
                            Console.WriteLine("quit: Exit");

                            Console.Write("Please type to select an operation: ");
                            string option = Console.ReadLine().ToLower();
                            Console.WriteLine();

                            switch (option)
                            {
                                case "savings":

                                    Console.Write("Account Name: ");
                                    string accountName = Console.ReadLine();
                                    Console.Write("Date of Birth: ");
                                    string dateofBirth = Console.ReadLine();

                                    Console.WriteLine("     **Enter Address Details**");
                                    Console.Write("         3. Road No: ");
                                    int roadNo = int.Parse(Console.ReadLine());
                                    Console.Write("         4. House No: ");
                                    int houseNo = int.Parse(Console.ReadLine());
                                    Console.Write("         5. City: ");
                                    string city = Console.ReadLine();
                                    Console.Write("         6. Country: ");
                                    string country = Console.ReadLine();

                                    Console.Write("Initial Balance: ");
                                    double balance = Convert.ToDouble(Console.ReadLine());

                                    int i = AutoGenerateId();
                                    b.AddAccount(new SavingsAccount(i, accountName, dateofBirth, balance, new Address(roadNo, houseNo, city, country)), option);
                                    break;

                                case "checking":
                                    Console.Write("Account Name: ");
                                    string n = Console.ReadLine();
                                    Console.Write("Date of Birth: ");
                                    string dob = Console.ReadLine();

                                    Console.WriteLine("     **Enter Address Details**");
                                    Console.Write("         3. Road No: ");
                                    int road = int.Parse(Console.ReadLine());
                                    Console.Write("         4. House No: ");
                                    int house = int.Parse(Console.ReadLine());
                                    Console.Write("         5. City: ");
                                    string c = Console.ReadLine();
                                    Console.Write("         6. Country: ");
                                    string co = Console.ReadLine();

                                    Console.Write("Initial Balance: ");
                                    double bal = Convert.ToDouble(Console.ReadLine());

                                    int id = AutoGenerateId();
                                    b.AddAccount(new CheckingAccount(id, n, dob, bal, new Address(road, house, c, co)), option);
                                    break;

                                case "quit":
                                    ok = 1;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Command!! Please, Type a Valid Command..");
                                    Console.WriteLine();
                                    break;
                            }

                            if (ok == 1)
                            {
                                break;
                            }
                        }
                        break;

                    case "account":
                        while (true)
                        {
                            Console.WriteLine("deposit: Make a Deposit");
                            Console.WriteLine("withdraw: Make a Withdrawal");
                            Console.WriteLine("transfer: Make a Transfer");
                            Console.WriteLine("show: Check The Number of Transactions and Balance");
                            Console.WriteLine("quit: Exit");

                            Console.Write("Please, Type to Select an Operation: ");
                            string choose = Console.ReadLine().ToLower();
                            Console.WriteLine();

                            
                            if (choose == "deposit")
                            {

                                Console.Write("Enter Account Number: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Enter Deposit Amount: ");
                                double amount = Convert.ToDouble(Console.ReadLine());

                                b.Transaction(choose, id, amount);
                            }

                            else if (choose == "withdraw")
                            {
                                Console.Write("Enter Account Number: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Enter Withdraw Amount: ");
                                double amount = Convert.ToDouble(Console.ReadLine());

                                b.Transaction(choose, id, amount);
                            }

                            else if (choose == "transfer")
                            {
                                Console.Write("Enter Transfer Amount: ");
                                double amount = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Receiver Account Number: ");
                                int id2 = Convert.ToInt32(Console.ReadLine());

                                b.Transaction(choose, id, id2, amount);
                            }

                            else if (choose == "show")
                            {
                                Console.Write("Please Enter Account Number: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                b.AccountInformation(id);
                                Console.WriteLine();
                            }

                            else if (choose == "quit")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Command!! Please, Type a Valid Command..");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "quit":
                        check = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid Command!! Please, Type a Valid Command..");
                        Console.WriteLine();
                        break;
                }
                if (check == 1)
                {
                    break;
                }

            }
        }
    }
}
