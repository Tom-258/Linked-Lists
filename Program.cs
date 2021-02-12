using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new LinkedList<object>();
            shoppingList.Add("water");
            shoppingList.Remove("water");
            shoppingList.Add("apple");
            shoppingList.Add("banana");
            shoppingList.Add("orange");
            Console.WriteLine(shoppingList[2]);
            shoppingList.Add("vegetables");
            shoppingList.RemoveAt(0);
            shoppingList.RemoveAt(1);
            shoppingList.Add(null);
            shoppingList.Remove(null);
            for (var i = 0; i < shoppingList.GetLength(); i++)
            {
                Console.WriteLine("\n=> {0}", shoppingList[i]);
            }

            Console.WriteLine(shoppingList.IndexOf("apple"));
            Console.WriteLine(shoppingList.IndexOf("vegetables"));
            Console.WriteLine(shoppingList.Contains("banana"));
            Console.WriteLine(shoppingList.Contains("chocolate"));


        }
    }

}
