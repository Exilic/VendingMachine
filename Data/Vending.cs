
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

     
        public static void RegisterSoldItem()
        {

        }

        public static void DetailTheExchange(char keyPush, char preceedingKeyPush)
        {
            int productPrice = ProductStock.FindProductPriceByNumber(keyPush);
            if (debtToCustomer > productPrice)
            {

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