
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class MoneyBack
    {

        private static int amountToReturn;


        public static void CollectFullAmount(int[] debtToCustomer) //This represents the physical action
        {
            int[] coinReturn = { debtToCustomer[7], debtToCustomer[6], debtToCustomer[5] };
            int[] banknoteReturn = { debtToCustomer[4], debtToCustomer[3], debtToCustomer[2], debtToCustomer[1], debtToCustomer[0] };
            ReleaseFullAmount(coinReturn, banknoteReturn);
            
        }

        public static void ReleaseFullAmount(int[] coinReturn, int[] banknoteReturn) //This represents the physical action
        {
            Vending.BalanceDebtByMoneyBack();
            amountToReturn = 0; 
        }

        public static void FixAmountToReturn(int debtToCustomer)
        {
            amountToReturn = debtToCustomer;
        }
    }
}