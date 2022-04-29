using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        protected string _shoppingItem;
        private static int Getpriceofitems;
        private static string GetShopppingItems;
        private int _price;
        
        List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        private double _vat;

        public ShoppingCart()
        {

        }

       public void AddItems(ShoppingCartItem item)
       {
            _items.Add(item);   
       }

       public int GetVATPriceOfItems()
       {
            return _price * 115;
       }

       public double GetSubTotal()
       {
            double total = 0;
            foreach (ShoppingCartItem item in _items)
            {
                total += (item._price);
            }
            return total;
       }

       public double VATAdded()
       {
            double total = GetSubTotal();

            return Math.Round(total * _vat, 2);
            
       }



        
    }

    /*public int GetpriceOfItems()
      {
           return ShoppingCart.Getpriceofitems;
      }*/

    /* public string GetShoppingItems()
       {
            return GetShoppingItems();
       }*/


    //ShoppingCart cart = new ShoppingCart();
    // var item = new ShoppingCartItem("Shoes", 999);
    //cart.Add(item);
    /* public ShoppingCart()
     {
         Shoes shoes = new Shoes("Nike runner", 999);
         _items.Add(shoes);

         FishOil fishoil = new FishOil("Sunfoil cooking oil",  169);
         _items.Add(fishoil);

         LapTop laptop = new LapTop("SamsungLaptop", 3499);
         _items.Add(laptop);

         Necklace necklace = new Necklace("Evil eye necklace" ,50);
         _items.Add(necklace);

         ChocolateCake chocolatecake = new ChocolateCake("Chocolate Cake", 349);
         _items.Add(chocolatecake);
     }*/


    // other option is to use the get and set method



}
