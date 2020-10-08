
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data {

    public class Security
    {

        // It is assumed that security is close by and can service the machine within a short timespan

        private string serviceSessionID;
        private string serviceIssue;


        public void OptimiseMoneyStock()
        {
            //The array "moneyAvailable": [0] 1000kr [1] 500kr [2] 100kr [3] 50kr [4] 20kr [5] 10kr [6] 5kr [7] 1kr
            MoneyStock.ReplaceMoneyAvailable(new int[] { 0, 1, 10, 10, 10, 10, 10, 50 }); // Amounts to 2400kr
        }

        public void WriteServiceLog()
        {

        }

        public void ReadServiceIssue()
        {

        }

        public void AddServiceIssue()
        {
            //Add text to end of string serviceIssue (append)
        }
    }
}
