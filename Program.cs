using DiscountCalculatorApp;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please choose your account:\n1. Regular\n2. Premium\n3. Employee");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Indicate total amount of your payment:");
            double amountOfBill = double.Parse(Console.ReadLine());

            var customerTypeMap = new Dictionary<int, string>
            {
                {1, "Regular"},
                {2, "Premium"},
                {3, "Employee"}
            };

            if (!customerTypeMap.TryGetValue(userInput, out string valNum))
            {
                Console.WriteLine("You entered a wrong number");
                return;
            }

            if (Enum.TryParse<CustomerType>(valNum, out CustomerType customerType))
            {
                DiscountCalculator discountCalculator = new DiscountCalculator();
                double discountRate = discountCalculator.CalculateDiscount(customerType, amountOfBill);

                double discountAmount = amountOfBill * discountRate;
                double finalAmount = amountOfBill - discountAmount;

                Console.WriteLine($"Discount rate: {discountRate * 100}%");
                Console.WriteLine($"You saved: {discountAmount} units");
                Console.WriteLine($"Final amount to pay: {finalAmount} units");
            }
            else
            {
                Console.WriteLine("Invalid customer type.");
            }
        }
    }
}