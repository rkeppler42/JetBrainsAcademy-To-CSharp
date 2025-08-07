public readonly struct Expense
{
    public string Category { get; init; }
    public decimal Amount { get; init; }

    public Expense(string category, decimal amount)
    {
        Category = category;
        Amount = amount;
    }
}