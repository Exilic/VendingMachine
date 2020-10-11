
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{


    public class Drink : Product
    {

        public override void Use()
        {
            ActivityControl.ConcatenateCurrentMessage("Enjoy your drink!");
        }

        public Drink(string productName, int productPrice) : base(productName, productPrice)
        {

        }

        private string[] categoryInfo;


    }
}