
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    //The inheritance doesn't do a lot here, but represents the physical part at least
    public class BanknoteReader : MoneyInsert
    {


        public static void RegisterValidBanknote(int banknoteInsert)
        {
            ActivityControl.RespondToCustomerActivity();

            if (banknoteInsert == 1000 || banknoteInsert == 500 || banknoteInsert == 100 || banknoteInsert == 50 || banknoteInsert == 20)
            {
                TransferAmount(banknoteInsert);
                AddToMoneyHeld(banknoteInsert);
            }
            else
            {
                SendMessage("Insertion not recognized as a valid banknote");
                ReturnInvalidInsertion(banknoteInsert);
            }
        }
    }
}