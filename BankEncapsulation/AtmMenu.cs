using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankEncapsulation
{
    internal class AtmMenu
    {
        public BankAccount account = new BankAccount();
        bool menuIsActive = true;   
        public void StartUpAtmMenu() 
        {
            Console.Clear();
            Console.WriteLine("Welcome to Ashanti Bank");
            Console.WriteLine("press any key to contiue");
            Console.ReadLine();
            Console.Clear();

            do
            {

                Console.Clear();
                Console.WriteLine("Select what you would like to do");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - View Balance");
                Console.WriteLine("4 - Quit Program");


                int.TryParse(Helpers.GetUserInput(""), out int userSelection );




                switch (userSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("DEPOSIT");
                        Console.WriteLine("");
                        account.PinChecker();
                        Console.WriteLine("");
                        double.TryParse(Helpers.GetUserInput("Enter the amount you would like to deposit: "),out double depositAmount);
                        account.Deposit(depositAmount);
                        Console.WriteLine("");
                        Console.WriteLine("Your Deposit was succesful!");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("WITHDRAW");
                        Console.WriteLine("");
                        account.PinChecker();
                        Console.WriteLine("");
                        double.TryParse(Helpers.GetUserInput("Enter the amount you would like to withdraw: "), out double withdrawAmount);
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine("");
                        Console.WriteLine("Your withdraw was succesful!");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("BALANCE");
                        Console.WriteLine("");
                        account.PinChecker();
                        Console.WriteLine("");
                        account.GetBalance();
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Good Bye!");
                        menuIsActive = false;
                        Environment.Exit(0);


                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input try again!");
                        break;
                }

            }while(menuIsActive);



        }

    }
}
