using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        Address address1 = new Address("15 First St", "Blue Town", "CA", "USA");
        Address address2 = new Address("12 Second St", "Simpleville", "BC", "Canada");

        
        Customer customer1 = new Customer("Jon Bobieus", address1);
        Customer customer2 = new Customer("Nate Tree", address2);

        
        Product product1 = new Product("Laptop", "001", 1000.00, 1);
        Product product2 = new Product("IPhone", "002", 500.00, 2);
        Product product3 = new Product("Headphones", "003", 150.00, 1);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        
        List<Order> orders = new List<Order> { order1, order2 };

        
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
            Console.WriteLine(); 
        }
    }
}
