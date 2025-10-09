using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var product1 = new Product("Laptop", 1, 999.99m);
        var product2 = new Product("Mouse", 2, 25.50m);
        var product3 = new Product("Keyboard", 1, 49.99m);
        var product4 = new Product("Monitor", 2, 199.99m);
        var product5 = new Product("USB-C Cable", 3, 12.99m);

        var address1 = new Address("123 Elm Street", "New York", "NY", "USA");
        var address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");

        var customer1 = new Customer("Alice Johnson", address1);
        var customer2 = new Customer("Bob Smith", address2);

        var order1Products = new List<Product> { product1, product2, product3 };
        var order2Products = new List<Product> { product4, product5 };

        var order1 = new Order(order1Products, customer1);
        var order2 = new Order(order2Products, customer2);

        Console.Clear();
        DisplayOrder(order1);
        Console.WriteLine(new string('-', 40));
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}
