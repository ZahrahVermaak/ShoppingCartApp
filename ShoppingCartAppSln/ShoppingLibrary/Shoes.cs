﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class Shoes : ShoppingCartItem
    {
        public Shoes(string itemName, double price) : base(itemName, price)
        {
        }
    }
}