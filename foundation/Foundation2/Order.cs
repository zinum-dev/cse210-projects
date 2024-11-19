using System.Text;

class Order
{
    private Customer _customer;

    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotal()
    {
        double total = 0.0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        int shippingCost = _customer.LiveInUSA() ? 5 : 35;

        total += shippingCost;
        return total;
    }


    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        foreach (Product product in _products)
        {
            packingLabel.AppendLine(product.GetPackingLabel());
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return _customer.GetInformation();
    }
}