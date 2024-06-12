using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class UIOpen
    {
        public static void StartProgram() 
        {

            AtmMenu menu = new AtmMenu();

            bool pinCreationisValid = false;



            do
            {
                try
                {
                    int UserPin = int.Parse(Helpers.GetUserInput("Choose your pin number (Must be 4 numbers)"));
                    Console.WriteLine("Your pin has been set!");
                    menu.account.Pin = UserPin;
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadLine();
                    pinCreationisValid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid pin number. Please try again!");
                }

            } while (!pinCreationisValid);


            menu.StartUpAtmMenu();

        }


    }
}
