
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class Keypad
    {

        //There is a simple 0–9 keypad. Button 0 for ending the session. 1-9 for buying a product. 

        public static int latestKeyPush;
        public static int newKeyPush;

        public static void RegisterKeyPush(int keyPush)
        {
            latestKeyPush = newKeyPush;
            newKeyPush = keyPush;

            ActivityControl.RespondToCustomerActivity();
            latestKeyPush = keyPush;
            if (keyPush == 0)
            {
                ActivityControl.EndSession();
            }
            else
            {
                ActivityControl.BuyProduct(newKeyPush, latestKeyPush);
            }
        }


    }
}