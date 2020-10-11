
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{

    public class CustomerSession
    {

        private DateTime customerSessionID;

        private string customerSessionExchangDetails;


        public CustomerSession(DateTime timeStamp)
        {
            customerSessionID = timeStamp;
        }

        public DateTime CustomerSessionID
        {
            get { return customerSessionID; }
        }

        public void WriteCustomerSessionExchangDetails(string sessionActivity)
        {
            customerSessionExchangDetails = customerSessionExchangDetails + "," + sessionActivity;
        }

        public void EndCustomerSession(DateTime timeStamp)
        {

        }
    }
}