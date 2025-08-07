using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

string GetOrdinalSuffix(int number)
 {
    if (number % 100 is >= 11 and <= 13) return "th";
    return (number % 10) switch
    {
        1 => "st",
        2 => "nd",
        3 => "rd",
        _ => "th"
    };
}


decimal CalculateTotalProductAmount(List<Product> products)
{
    decimal total = 0;
    foreach (var product in products)
    {
        total += product.TotalValue;
    }

    return total;
}


decimal CalculateTotalExpenseAmount(List<Expense> expenses)
{
    decimal total = 0;
    foreach (var expense in expenses)
    {
        total += expense.Amount;
    }

    return total;
}


decimal CalculateNetIncome(decimal totalProductAmount, decimal totalExpenseAmount) {
    return totalProductAmount - totalExpenseAmount;
}




List<Product> products = new List<Product>();
List<Expense> expenses = new List<Expense>();

Console.WriteLine("Welcome to the Corner Shop Calculator!\n");

Console.Write("Please, tell me: how many unique products your corner shop selled last month?\n> ");
int numberOfProducts = int.Parse(Console.ReadLine());


for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine();
    string numberAddendum = GetOrdinalSuffix(i);
    Console.Write($"What is the {i}{numberAddendum} product name?\n> ");
    string productName = Console.ReadLine();
    Console.Write($"What is the {i}{numberAddendum} product value?\n> ");
    decimal productValue = decimal.Parse(Console.ReadLine());
    Console.Write($"What is the quantity you sold of the {i}{numberAddendum} product\n> ");
    int productQuantity = int.Parse(Console.ReadLine());
    Product product = new Product(productName, productValue, productQuantity);
    products.Add(product);
}

Console.Write("\nPlease, tell me: how many unique expenses your corner shop had last month?\n> ");
int numberOfExpenses = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfExpenses; i++)
{
    Console.WriteLine();
    string numberAddendum = GetOrdinalSuffix(i);
    Console.Write($"What is the {i}{numberAddendum} expense category?\n> ");
    string expenseCategory = Console.ReadLine();
    Console.Write($"What is the {i}{numberAddendum} expense amount?\n> ");
    decimal expenseAmount = decimal.Parse(Console.ReadLine());
    Expense expense = new Expense(expenseCategory, expenseAmount);
    expenses.Add(expense);
}

decimal totalProductAmount = CalculateTotalProductAmount(products);
decimal totalExpenseAmount = CalculateTotalExpenseAmount(expenses);
decimal netIncome = CalculateNetIncome(totalProductAmount, totalExpenseAmount);

Console.Write($"\nYour net income is: {netIncome.ToString("C")}");

