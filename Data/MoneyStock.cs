
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class MoneyStock
    {

        //Denominations in array: [0] 1000kr [1] 500kr [2] 100kr [3] 50kr [4] 20kr [5] 10kr [6] 5kr [7] 1kr
        private static int[] moneyAvailable = new int[8];



        public static void ReceiveAmount(int moneyInserted)
        {
            Vending.IncreaseDebtToCustomer(moneyInserted);

            switch (moneyInserted)
            {
                case 1:
                    moneyAvailable[7]++;
                    break;

                case 5:
                    moneyAvailable[6]++;
                    break;

                case 10:
                    moneyAvailable[5]++;
                    break;

                case 20:
                    moneyAvailable[4]++;
                    break;

                case 50:
                    moneyAvailable[3]++;
                    break;

                case 100:
                    moneyAvailable[2]++;
                    break;

                case 500:
                    moneyAvailable[1]++;
                    break;

                case 1000:
                    moneyAvailable[0]++;
                    break;

                default:

                    break;
            }
        }

        public static void DeterminSupplyIssue()
        {
            if (Array.Exists(moneyAvailable, denominations => denominations == 3 || moneyAvailable[0] == 1)) // 3 * 500kr borders on too many, else too few
            {
                ActivityControl.AlertSecurity();
            }
            else { }
        }


        public static int[] RevealMoneyAvailable()
        {
            return moneyAvailable;
        }

        public static void SendAmount(int[] debtToCustomer)
        {
            for (int i = 0; i < 8; i++)
            {
                moneyAvailable[i] -= debtToCustomer[i];
            }

            MoneyBack.CollectFullAmount(debtToCustomer);
        }

        public static void ReplaceMoneyAvailable(int[] depositBySecurity)
        {
            moneyAvailable = depositBySecurity;
        }
    }
}