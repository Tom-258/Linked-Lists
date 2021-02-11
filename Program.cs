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
            shoppingList.Add("hello");
            shoppingList.ReturnList();
        }
    }

}
