using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        // Sum total cost of all products
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on location
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        // Packing label: list product names and IDs
        var lines = new List<string>();
        lines.Add("Packing Label:");
        foreach (Product p in _products)
        {
            lines.Add($"{p.GetName()} (ID: {p.GetProductId()})");
        }
        return string.Join("\n", lines);
    }

    public string GetShippingLabel()
    {
        // Shipping label: customer name and address
        var lines = new List<string>();
        lines.Add("Shipping Label:");
        lines.Add(_customer.GetName());
        lines.Add(_customer.Getaddress());
        return string.Join("\n", lines);
    }
}