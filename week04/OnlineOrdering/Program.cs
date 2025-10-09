using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Emma Brown", address2);

        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 75, 1));
        order2.AddProduct(new Product("Monitor", "P004", 300, 2));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}