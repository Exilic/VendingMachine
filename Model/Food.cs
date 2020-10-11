
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{
    public class Food : Product
    {

        public override void Use()
        {
            ActivityControl.ConcatenateCurrentMessage("Enjoy your snack!");
        }

        public Food(string productName, int productPrice) : base (productName, productPrice)
        {
            
        }

        private string[] categoryInfo;
    }
}