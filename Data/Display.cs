
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Data
{



    public class Display //This class represents to a large degree a physical function, with symbolic actions in the program
    {


        private static string currentMessage;


        public static void ChangeCurrentMessage(string newMessage)
        {
            currentMessage = newMessage;
        }

        public static void PowerDownDisplay() 
        {
            currentMessage = "";
        }

        public static void DisplayCurrentMessage()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("You have {0} kr", Vending.RevealDebtToCustomer());
            Console.WriteLine(currentMessage);
        }

        public static string RevealCurrentMessage()
        {
            return currentMessage;
        }
    }
}