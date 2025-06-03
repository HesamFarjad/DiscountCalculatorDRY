# DiscountCalculatorDRY

A clean and modular C# console application that calculates discounts based on customer type and total purchase amount. This project emphasizes the DRY (Don't Repeat Yourself) principle and clean code architecture.

## 🧠 Key Concepts
- **DRY (Don't Repeat Yourself)**: Logic is centralized and not duplicated.
- **Clean Code**: Easy to read, maintain, and extend.
- **Enum Usage**: Strongly-typed customer roles.
- **Switch Expressions**: Modern and clean control flow.
- **Modular Design**: Discount logic separated into its own class.

## 📦 Structure
- `Program.cs` – Handles input/output and decision flow.
- `DiscountCalculator.cs` – Contains the discount calculation logic.
- `CustomerType` enum – Defines different customer roles.

## 🛠️ Sample Run


Please choose your account:

Regular

Premium

Employee

## user input ✏️ : 2


Indicate total amount of your payment:

## user input ✏️ : 1200

Discount rate: 15%
You saved: 180 units
Final amount to pay: 1020 units




## ✅ Benefits
- Follows **best practices** in C# development.
- Easily extendable (add more customer types or rules).
- Good base for demonstrating code quality in job interviews or portfolios.
