using System.Net.Http.Headers;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("branch checking in git 2")
        Console.WriteLine("1. Product Price Without Discount");
        Console.WriteLine("2. Product Price With Discount");
         
        Console.WriteLine("Enter choice");
        int choice = Convert.ToInt32(Console.ReadLine());

        Product product = new Product();
        if(choice == 1 || choice ==2 )
        {
            Console.WriteLine("Enter Price");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                decimal totalPrice = product.CalculatePrice(price,quantity);
                Console.WriteLine("Total price without Discount "+totalPrice);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter Discount");
                int discount =Convert.ToInt16(Console.ReadLine());

                decimal totalPrice = product.CalculatePrice(price,quantity,discount);
                Console.WriteLine("Total price with Discount "+totalPrice);
            }
        }
        else
        {
                Console.WriteLine("Invalid Choice");
        }

    }

}