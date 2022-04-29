using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        public double _price;
        protected string _itemName;
        //public int _addPrices;
        //private object _shoppingCartitems;

        public ShoppingCartItem(string itemName, double price)
        {
            _itemName = itemName;
            _price = price; 
            _price = 0;

            //getPrice++;
        }

        

       /* public void AddShoppingItem(ShoppingCartItem item)
        {
            _shoppingCartitems.Add(item);
        }*/
         //_price = _price;
        
    }
    
    
    

   

}
