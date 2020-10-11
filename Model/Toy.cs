
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{

    public class Toy : Product
    {

        public override void Use()
        {
            ActivityControl.ConcatenateCurrentMessage("Enjoy your play!");
        }

        public Toy(string productName, int productPrice) : base(productName, productPrice)
        {

        }

        protected string categoryInfo;


    }
}