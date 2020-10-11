using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{
    public abstract class Product
    {
        protected string productName;
        protected int productPrice;

        public abstract void Use();

        protected Product(string productName, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public string ProductName
        {
            get { return productName;  }
        }

        public int ProductPrice
        {
            get { return productPrice; }
        }     
    }
}
