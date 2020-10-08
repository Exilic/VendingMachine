
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{

    public class CustomerSession
    {

        private string customerSessionID;

        private string customerSessionDuration;

        private string customerSessionExchangDetails;




        public CustomerSession(string timeStamp)
        {
            customerSessionID = timeStamp;
        }

        public void GetCustomerSessionID()
        {

        }

        public void GetCustomerSessionDuration()
        {

        }

        public void SetCustomerSessionDuration()
        {

        }

        public void GetCustomerSessionExchangDetails()
        {

        }

        public void SetCustomerSessionExchangDetails()
        {

        }
    }
}