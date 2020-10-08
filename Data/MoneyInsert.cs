
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class MoneyInsert
    {
        // The variable "moneyHeld" represents the total amount of money inserted, 
        // but the actual money has been transfered to "MoneyStock"
        // So "EmptyMoneyHeld" is purely formal 

        protected static int moneyHeld;

        //This represents a physical function
        protected static void TransferAmount(int moneyInserted) 
        {
            MoneyStock.ReceiveAmount(moneyInserted); 
        }

        protected static void AddToMoneyHeld(int moneyInserted)
        {
            moneyHeld -= moneyInserted;
        }

        protected static void ReturnInvalidInsertion(int moneyInserted)
        {
           moneyInserted = 0; //This would call a physical function. Now it has just a symbolic function
        }

        protected static void SendMessage(string message)
        {
            ActivityControl.ReceiveMessage(message);
        }

        public static int RevealMoneyHeld()
        {
            return moneyHeld;
        }

        public static void EmptyMoneyHeld()
        {
            moneyHeld = 0;
        }
    }
}