using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessTemplate netOrder = new NetOrder();

            //Hollywood principle :  Dont call us - we will call you!
            //higher class calls methods in lower class
            netOrder.processOrder(true);

            Console.WriteLine();
            OrderProcessTemplate storeOrder = new StoreOrder();
            storeOrder.processOrder(true);

            Console.ReadLine();
        }
    }
}
