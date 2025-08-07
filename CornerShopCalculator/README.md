# 🛒 Corner Shop Calculator – C# Version

This is a console application that simulates a corner shop's monthly earnings, expenses, and net income.  
It was developed as part of my reimplementation of JetBrains Academy projects using idiomatic C#.

---

## 🚀 Features

- User input for multiple products: name, price, quantity sold  
- User input for multiple expenses: category and amount  
- Calculation of total income and total expenses  
- Net income calculation and formatted output  
- Uses `struct` for `Expense` and `class` for `Product`  
- Localized currency formatting (currently set to `en‑US`)

---

## 📦 Tech Stack

- **Language:** C# 12  
- **Runtime:** .NET 8  
- **Type Modeling:** `class` + `struct`  
- **Formatting:** `System.Globalization` with `"en‑US"` culture

---

## 🧪 Example Run

```
Welcome to the Corner Shop Calculator!

Please, tell me: how many unique products your corner shop selled last month?
> 2

What is the 1st product name?
> Bubblegum
What is the 1st product value?
> 2
What is the quantity you sold of the 1st product
> 100

What is the 2nd product name?
> Toffee
What is the 2nd product value?
> 0.2
What is the quantity you sold of the 2nd product
> 590

Please, tell me: how many unique expenses your corner shop had last month?
> 2

What is the 1st expense category?
> Staff
What is the 1st expense amount?
> 2000

What is the 2nd expense category?
> Rent
What is the 2nd expense amount?
> 300

Your net income is: $119.00
```

---

## ⚙️ How to Run

Make sure you have the .NET SDK installed.  
Then, from the project folder:

```bash
dotnet build
dotnet run
```

---

## 📌 Notes

- This is the basic version of the project. A more complete version with better formatting, validation, and structure will be added soon.
- This project was originally implemented in Python as part of the [JetBrains Academy Python Track – Corner Shop Calculator](https://github.com/rkeppler42/JetBrainsAcademy-Python/tree/main/Easy/corner-shop-calculator).

---

## 🔗 Related

- [JetBrainsAcademy-To-CSharp (main repo)](https://github.com/rkeppler42/JetBrainsAcademy-To-CSharp)
- [JetBrainsAcademy-Python](https://github.com/rkeppler42/JetBrainsAcademy-Python/)