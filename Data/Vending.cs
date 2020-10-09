
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Vending
    {

        private static int debtToCustomer;

     
        public static void RegisterSoldItem(char keyPush)
        {

        }

        public static void DetailTheExchange(char keyPush, char preceedingKeyPush)
        {
            

            if (debtToCustomer > ProductStock.ShowProductInfo(keyPush).ProductPrice)
            {
                if (keyPush == preceedingKeyPush && previous message was "Push to confirm ")
                {
                    RegisterSoldItem(keyPush);
                }
                else
                {
                    Console.WriteLine($"Push {keyPush} to confirm buy"); 
                }
            }
            else
            {
                Console.WriteLine($"You miss by {debtToCustomer - ProductStock.ShowProductInfo(keyPush).ProductPrice}kr");
            }
            
            
        }

        public static void SettleDebtToCustomer()
        {
            MoneyStock.SendAmount(CalculateChange.CalculateChangeByDenomination(debtToCustomer));
            CalculateChange.ResetChangeByDenomination();
            MoneyInsert.EmptyMoneyHeld();
        }

        public static int RevealDebtToCustomer()
        {
            return debtToCustomer;
        }
    }
}