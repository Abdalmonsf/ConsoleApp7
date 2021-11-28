using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projegt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list1 = new LinkedList<string>();

            list1.AddFirst("no");
            list1.AddLast("yes");
            LinkedListNode<String> nozzle = new LinkedListNode<string>("Done");
            list1.AddFirst(nozzle);
            list1.AddBefore(nozzle, "Tool");
            list1.AddAfter(nozzle, "Cool");

            Console.WriteLine("The LinkedList Before Deleton: ");

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            list1.RemoveFirst();
            list1.Remove("OK");
            list1.RemoveLast();

            Console.WriteLine("The LinkedList After Deletion: ");

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
