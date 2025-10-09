// Order
// Contains a list of products and a customer. Can calculate the total cost of the order. 
// Can return a string for the packing label. 
// Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5.
// If the customer does not live in the USA, then the shipping cost is $35.

// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer

using System.Reflection.Emit;
using Microsoft.VisualBasic;
using System.Linq;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._customer = customer;
        this._products = products;
    }

    public decimal GetTotalPrice()
    {
        return _products.Sum(product => product.Price);
    }

    public string GetPackingLabel()
    {
        return string.Join(Environment.NewLine, _products.Select(p => $"{p.Name} ({p.ProductId})"));
    }

    public string GetShippingLabel()
    {
        return $"{_customer.Name}{Environment.NewLine}{_customer.Address}";
    }

}

