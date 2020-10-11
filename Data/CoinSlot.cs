
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    //The inheritance doesn't do a lot here, but represents the physical part at least
    public class CoinSlot : MoneyInsert
    {


        public static void RegisterValidCoin(int coinInsert)
        {
            ActivityControl.RespondToCustomerActivity();

            if (coinInsert == 10 || coinInsert == 5 || coinInsert == 1)
            {
                TransferAmount(coinInsert);
                AddToMoneyHeld(coinInsert);
            }
            else
            {
                SendMessage("Insertion not recognized as a valid coin");
                ReturnInvalidInsertion(coinInsert);
            }
        }
    }
}