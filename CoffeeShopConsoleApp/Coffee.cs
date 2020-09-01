using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>

        public abstract string Strength();


        public Coffee(int discount)
        {
            if(Discount > 5)
                throw new Exception("Max discount is 5 kr");
            Discount = discount;
        }

        public virtual int price()
        {
            return 20;
        }

        public int Discount { get;  }
    }
}
