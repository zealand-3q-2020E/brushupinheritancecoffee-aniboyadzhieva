﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk

    {
        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }

        public override string ToString()
        {
            return "Cortado";
        }

        public Cortado(int discount) : base(discount)
        {

        }
    }
}
