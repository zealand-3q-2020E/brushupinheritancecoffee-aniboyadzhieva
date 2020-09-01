using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
               new BlackCoffee(3),
               new Cortado(10),
               new Latte(10)

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the name of the coffee is " + coffee.ToString() + " ,the price of the coffee is: "+ coffee.price() + " ,the strenght of the coffee is " + coffee.Strength() + " ,your discount is " + coffee.Discount);
            }


        }
    }
}
