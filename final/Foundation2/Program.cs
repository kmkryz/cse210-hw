using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        


        // Creating Address, Customer, and Product instances
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("Widget", "W123", 10.99, 2);
        Product product2 = new Product("Gadget", "G456", 19.99, 1);

        Address address2 = new Address("456 Oak St", "Othercity", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Product product3 = new Product("Doodad", "D789", 7.99, 3);

        // Creating Order instances
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3 });

        // Displaying results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalPrice()}");
    }
}