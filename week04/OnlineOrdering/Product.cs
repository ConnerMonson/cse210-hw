class Product
{
    private string _name;
    private int _idNumber;
    private double _price;
    private int _quantity;

    public Product(string name, int idNumber, double price, int quantity)
    {
        _name = name;
        _idNumber = idNumber;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        double total = _price * _quantity;
        return total;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetIdNumber()
    {
        return _idNumber;
    }
}