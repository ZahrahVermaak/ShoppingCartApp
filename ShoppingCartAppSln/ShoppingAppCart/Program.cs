using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingAppCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

            ShoppingCart shoppingcart = new ShoppingCart();

            var item = new ShoppingCartItem("Nike runner", 999);
            //shoppingcart.Add(item);

            item = new ShoppingCartItem("Sunfoil cooking oil", 169);
            //shoppingcart.Add(item);

            item = new ShoppingCartItem("SamsungLaptop", 3499);
            //shoppingcart.Add(item);

            item = new ShoppingCartItem("Evil Eye Necklace", 50);
            //shoppingcart.Add(item);

            item = new ShoppingCartItem("Chocolate Cake", 349);
            //shoppingcart.Add(item);

        }

            /* Shoes shoes = new Shoes("Nike runner", 999);
             _items.Add(shoes);

             FishOil fishoil = new FishOil("Sunfoil cooking oil", 169);
             _items.Add(fishoil);

             LapTop laptop = new LapTop("SamsungLaptop", 3499);
             _items.Add(laptop);

             Necklace necklace = new Necklace("Evil eye necklace", 50);
             _items.Add(necklace);

             ChocolateCake chocolatecake = new ChocolateCake("Chocolate Cake", 349);
             _items.Add(chocolatecake);*/


            //ShoppingCart shoppingcart = new ShoppingCart();

            //ShoppingCartItem shoes = new Shoes(999);
            //ShoppingCartItem FishOil = new FishOil();
            //Console.WriteLine(ShoppingCartItem);
            //Console.WriteLine("Sub Total: " + ShoppingCart.Getpriceofitems());
            //Console.WriteLine("VAT inlcuded: " + ShoppingCart.GetVATPriceOfItems());

        
    }
}
