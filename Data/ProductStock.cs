
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VendingMachine.Model;

namespace VendingMachine.Data
{

    public class ProductStock
    {

        private static int[] productsAvailable;
        private static Product[] productStock = new Product[9];


        public static Product[] LoadProductStockInfo(string product)
        {
            string[] linesOfProductInfo = File.ReadAllLines(@"/Users/tobiasengberg/Projects/VendingMachine/VendingMachine/Data/CurrentProductStock.txt");

            for (int i = 0; i < 9; i++)
            {
                string[] itemisedProductInfo = linesOfProductInfo[i].Split(',');
                productStock[i] = new Product(itemisedProductInfo[0], int.Parse(itemisedProductInfo[1]));
            }
            return productStock;
        }

        public static void AlertShortSupply()
        {
            if (Array.Exists(productsAvailable, products => products == 2)) // Now the border is set to 2, but might be too high and impractical for toys
            {
                ActivityControl.AlertMaintenance();
            }
            else { }
        }

        public static bool CheckSupply(int slotNumber)
        {
            return productsAvailable[slotNumber] > 0;
        }

        public static void ReceiveNewSupply()
        {
            productsAvailable[] = { 12, 12, 5, 10, 10, 10, 10, 4, 4 }
        }

        public static void SendProduct()
        {

        }

        public static Product ShowProductInfo(int slotNumber)
        {
            return productStock[slotNumber];
        }
    }
}