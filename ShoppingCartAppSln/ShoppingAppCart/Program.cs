using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingAppCart
{
    internal class Program
    {

        static void Main(string[] args)
        {
          //  List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

            ShoppingCart shoppingcart = new ShoppingCart();

            var item = new ShoppingCartItem("Nike runner", 999);
            shoppingcart.AddItems(item);
           // Console.WriteLine(item._itemName + " " + " - " + "R" + item._price);

            item = new ShoppingCartItem("Cooking oil", 169);
            shoppingcart.AddItems(item);
           // Console.WriteLine(item._itemName + " " + " - " + "R" + item._price);

            item = new ShoppingCartItem("SamsungLaptop", 3499);
            shoppingcart.AddItems(item);
            //Console.WriteLine(item._itemName + " " + " - " + "R" + item._price);

            item = new ShoppingCartItem("Necklace", 50);
            shoppingcart.AddItems(item);
            //Console.WriteLine(item._itemName + " " + " - " + "R" + item._price);

            item = new ShoppingCartItem("Chocolate Cake", 349);
            shoppingcart.AddItems(item);
            // Console.WriteLine(item._itemName + " " + " - " + "R" + item._price);

            List<ShoppingCartItem> ShoppingCartItems = shoppingcart.MyCartItems();

            foreach(ShoppingCartItem shoppingCartItem in ShoppingCartItems)
            {
                Console.WriteLine(_ = shoppingCartItem._itemName +"\t\t\t\t"+ "R"+ shoppingCartItem._price);
            }
            Console.WriteLine("SubTotal - "+ "\t\t\t\t"+"R" + shoppingcart.GetSubTotal());
            Console.WriteLine("VATAdded - " + "\t\t\t\t" + "R" + shoppingcart.VATAdded());
           

        }  


            // Console.WriteLine(item._price);

            //Console.WriteLine("Items: " + ShoppingCartItem());
        

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
