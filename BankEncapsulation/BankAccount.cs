using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        private int pin { get; set; }



        public BankAccount() 
        { 
        
        }

        public int Pin
        {
            get { return pin; }
            set 
            {
               pin = value; 
            }
        }

        public bool PinChecker() 
        {
            int attemptAmount = 3;
            bool isPin = false;

            Console.WriteLine("please enter your pin#");
            do
            {
                int.TryParse(Helpers.GetUserInput(""), out int inputPin);
                if (inputPin == pin)
                {
                    isPin = true;

                }
                else 
                {
                    Console.Clear();
                    Console.Write("Incorrect pin try again");
                    isPin = false;
                }


            } while (!isPin);
            

            return isPin;
        
        
        }
        
      
      
        public void Withdraw(double amount) 
        { 
            _balance -= amount;
        
        }

        public void Deposit(double amount) 
        {
            _balance += amount;
            
        }

        public void GetBalance() 
        {
            Console.WriteLine($"Your balance is: {_balance:C}");
        }

    }
}
