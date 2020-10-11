
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Data
{

    public class Maintenance
    {
    
        private static string serviceSessionID;


        public static void WriteServiceLog()
        {
        
        }

        public static void RefillProductStock()
        {
            ProductStock.ReceiveNewSupply(new int[] { 12, 12, 5, 10, 10, 10, 10, 4, 4 });
        }

        public static void RunMaintenanceProgram()
        {
        
        }
    }
}