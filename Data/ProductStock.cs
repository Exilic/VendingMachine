
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

        private static int[] productsAvailable = new int[9];
        private static List<Product> productStock = new List<Product>();


        public static List<Product> LoadProductStockInfo()
        {
            string[] linesOfProductInfo = File.ReadAllLines(@"/Users/tobiasengberg/Projects/VendingMachine/VendingMachine/Data/CurrentProductStock.txt");

            for (int i = 0; i < 9; i++)
            {
                string[] itemisedProductInfo = linesOfProductInfo[i].Split(',');
                switch (itemisedProductInfo[2])
                {
                    case "snack":
                        productStock.Add(new Food(itemisedProductInfo[0], int.Parse(itemisedProductInfo[1])));
                        break;
                    case "drink":
                        productStock.Add(new Drink(itemisedProductInfo[0], int.Parse(itemisedProductInfo[1])));
                        break;
                    case "toy":
                        productStock.Add(new Toy(itemisedProductInfo[0], int.Parse(itemisedProductInfo[1])));
                        break;
                }
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
            bool findOut = productsAvailable[slotNumber - 1] > 0;
            return findOut;
        }

        public static void ReceiveNewSupply(int[] refill)
        {
            productsAvailable = refill;
        }

        public static void SendProduct(int slotNumber)
        {
            productsAvailable[slotNumber - 1]--;
            ProductDelivery.ReceiveDeliveryOrder(slotNumber);
            productStock[slotNumber - 1].Use();
        }

        public static Product ShowProductInfo(int slotNumber)
        {
            return productStock[slotNumber - 1];
        }
    }
}