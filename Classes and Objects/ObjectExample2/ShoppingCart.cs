using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample2
{
    public class ShoppingCart
    {
        private List<Item> contents;

        public ShoppingCart()
        {
            contents = new List<Item>();
        }//end ShoppingCart

        public void AddItem(Item i)
        {
            contents.Add(i);//adds items to the list
        }//end AddItem

        public double GetTotal()
        {
            double total = 0;

            foreach(Item i in contents)
            {
                total += i.ItemPrice;

            }//end foreach

            return total;
        }//end GetTotal

        public List<Item> GetItems()
        {
            return contents;
        }//end GetItems

    }//end class
}//end namespace
