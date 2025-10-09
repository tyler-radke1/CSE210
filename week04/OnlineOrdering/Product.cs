// Product
// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. 
// (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
using System.Reflection;
using System;

class Product
{

    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    // Constructor
    public Product(string name, int quantity, decimal pricePerUnit)
    {
        Name = name;
        Quantity = quantity;
        Price = pricePerUnit * quantity;
        ProductId = Guid.NewGuid().ToString();
    }
}
