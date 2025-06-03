namespace DiscountCalculatorApp;

public enum CustomerType
{
    Regular,
    Premium,
    Employee,
}

public class DiscountCalculator
{
    private const int DISCOUNT_THRESHOLD = 1000;
    public double CalculateDiscount(CustomerType customerType, double totalAmount)
    {
        double discount = 0;

        switch (customerType)
        {
            case CustomerType.Regular:
                discount = totalAmount > DISCOUNT_THRESHOLD ? 0.10 : 0.05;
                break;
            case CustomerType.Premium:
                discount = totalAmount > DISCOUNT_THRESHOLD ? 0.15 : 0.10;
                break;
            case CustomerType.Employee:
                discount = totalAmount > DISCOUNT_THRESHOLD ? 0.20 : 0.15;
                break;
        }

        return discount;
    }
}
