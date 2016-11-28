using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample2
{
    public class Display
    {
        //get items
        //display list of item
        //get total

        ShoppingCart cart;

        public Display()
        {
            cart = new ShoppingCart();
            GetItems();
            ShowItems();
            ShowTotal();
        }//end constructor Display

        private void GetItems()
        {
            Console.WriteLine("Enter how many items you're going to get.");
            int number = int.Parse(Console.ReadLine());

            for (int x = 0; x < number; x++)
            {
                Item item = new Item();
                Console.WriteLine("Enter item name");
                item.ItemName = Console.ReadLine();
                Console.WriteLine("Enter item price.");
                item.ItemPrice = double.Parse(Console.ReadLine());
                cart.AddItem(item);
            }//end for loop
        }//eng GetItems

        private void ShowItems()
        {
            List<Item> stuff = cart.GetItems();
            Console.Clear();
            foreach(Item i in stuff)
            {
                Console.WriteLine("{0}  {1}", i.ItemName, i.ItemPrice);
            }//end foreach
        }//end ShowItems

        private void ShowTotal()
        {
            Console.WriteLine("The total is{0}", cart.GetTotal());

        }//end ShowTotal

        private void PauseIt()
        {
            Console.ReadKey();
        }


    }//end class
}//end namespaces
