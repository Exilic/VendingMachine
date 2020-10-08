
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class CalculateChange
    {

        private static int[] changeByDenomination = new int[9]; // The last number in the array functions as a control value

        public static bool QueryMoneyStock(int denomination)
        {
            int[] denominationsAvailable = MoneyStock.RevealMoneyAvailable();
            return denominationsAvailable[denomination] > 0;

        }

        public static int[] CalculateChangeByDenomination(int amount)
        {
            int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 }; 

            var i = 7;
            while (amount > denominations[i]) { i--; } //Determine entry denomination for calculation

            while (amount > 0 && i < 8)
            {
                while (amount > denominations[i])
                {
                    if (QueryMoneyStock(i))
                    {
                        amount -= denominations[i];
                        changeByDenomination[i] = changeByDenomination[i]++;
                    } else { i++; }
                }
                i++;
            }

            if (amount != 0)
            {
                changeByDenomination[8] = 99; //This intends to alert a problem of not being able to give change
            }

            return changeByDenomination;
        }

        public static void ResetChangeByDenomination()
        {
            Array.Clear(changeByDenomination, 0, 9);
        }
    }
}