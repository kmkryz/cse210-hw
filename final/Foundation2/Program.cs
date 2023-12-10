using System;


class Program
{
    static void Main(string[] args)
    {
    

        // Creating Address, Customer, and Product instances
        Address address1 = new Address("123 Main St", "Lakepine", "CA", "USA");
        Customer customer1 = new Customer("Johny May", address1);
        Product product1 = new Product("Widget", "W123", 10.99, 2);
        Product product2 = new Product("Blender", "B456", 32.99, 1);
        

        Address address2 = new Address("456 Oak St", "Hooterville", "NY", "Canada");
        Customer customer2 = new Customer("Lucy Gray", address2);
        Product product3 = new Product("Doll brush", "D789", 7.99, 3);
        Product product4 = new Product("Phone case", "P785", 23.00, 3);

        Address address3 = new Address("151 Holland Rd", "Liverpool", "NW", "England");
        Customer customer3 = new Customer("Mary Luson", address3);
        Product product5 = new Product("Red knit socks", "KS863", 5.99, 4);
        Product product6 = new Product("Record player", "M006", 58.00, 1);
        Product product7 = new Product("Rustic ceramic pot", "P0907", 14.99, 3);

        // Creating Order instances
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });
        Order order3 = new Order(customer3, new List<Product> { product5, product6, product7});

        // Displaying results
        Console.WriteLine();
        Console.WriteLine("Order 1:");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalPrice()}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\nOrder 3:");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order3.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order3.CalculateTotalPrice()}");
    }
}