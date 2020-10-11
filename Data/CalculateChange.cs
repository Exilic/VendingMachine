
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class CalculateChange
    {

        private static int[] changeByDenomination = new int[9]; // The last number in the array functions as a control value

        public static bool QueryMoneyStock(int denominationNumber)
        {
            int[] denominationsAvailable = MoneyStock.RevealMoneyAvailable();
            return denominationsAvailable[denominationNumber] > 0;

        }

        public static int[] CalculateChangeByDenomination(int amount)
        {
            int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };

            var amountForCalculation = amount;
            var i = 0;

            while (amountForCalculation > -1 && i < 8)
            {
                while (amountForCalculation >= denominations[i])
                {
                    if (QueryMoneyStock(i))
                    {
                        amountForCalculation -= denominations[i];
                        changeByDenomination[i]++;
                    } else { i++; }
                }
                i++;
            }

            if (amountForCalculation != 0)
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