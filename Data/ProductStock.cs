
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Data
{

    public class ProductStock
    {

        protected static int[] productsAvailable;
        protected static Product[] productStock = new Product[9];


        public static Product[] LoadProductStock(string product)
        {
            for (int i = 0; i < 9; i++)
            {

            }
            return
        }

        public static void AlertShortSupply()
        {
            if (Array.Exists(productsAvailable, products => products == 2)) // Now the border is set to 2, but might be too high and impractical for toys
            {
                ActivityControl.AlertMaintenance();
            }
            else { }
        }

        public static void ReceiveNewSupply()
        {

        }

        public static void SendProduct()
        {

        }

        public static void FindProductPriceByNumber(char slotNumber)
        {

        }
    }
}