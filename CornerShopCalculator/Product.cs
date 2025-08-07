class Product
{
    public string Name { get; }
    public decimal Value { get; }
    public int Quantity { get; }

    public decimal TotalValue => Value * Quantity;

    public Product(string name, decimal value, int quantity)
    {
        Name = name;
        Value = value;
        Quantity = quantity;
    }
}