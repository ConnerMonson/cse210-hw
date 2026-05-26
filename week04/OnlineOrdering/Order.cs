class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double TotalCost()
    {
        double totalCost = 0;
        foreach ( Product cost in _products)
        {
            totalCost += cost.GetTotalCost();
        }
        if (_customer.IsInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string PackingLable()
    {
        string label = "";
       foreach (Product products in _products)
       {
        string name = products.GetName();
        int idNumber = products.GetIdNumber();
        label += $"{name}, {idNumber}\n";
       }
       return label;
    }
    public string ShippingLable()
    {
        return _customer.DisplayShippingLabel();
    }
}