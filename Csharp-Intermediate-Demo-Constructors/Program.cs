using System;

namespace CsharpIntermediateDemoConstructors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(24, "Faysal");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);

        }

        
    }
}
