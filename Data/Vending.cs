
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

        public static void DetailTheExchange(int keyPush, int preceedingKeyPush)
        {
            if (debtToCustomer > ProductStock.ShowProductInfo(keyPush).ProductPrice)
            {
                if (keyPush == preceedingKeyPush && Display.RevealCurrentMessage().Contains("to confirm"))
                {
                    ProductStock.SendProduct(keyPush);
                    debtToCustomer -= ProductStock.ShowProductInfo(keyPush).ProductPrice;
                }
                else
                {
                    ActivityControl.ConcatenateCurrentMessage($"Push {keyPush} to confirm buy"); 
                }
            }
            else
            {
                ActivityControl.ConcatenateCurrentMessage($"You miss by {debtToCustomer - ProductStock.ShowProductInfo(keyPush - 1).ProductPrice}kr");
            }
        }

        public static void IncreaseDebtToCustomer(int moneyInserted)
        {
            debtToCustomer += moneyInserted;
        }

        public static void BalanceDebtByMoneyBack()
        {
            debtToCustomer = 0;
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