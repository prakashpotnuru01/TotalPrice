using System.Numerics;

public class Product
{
    decimal totalPrice = 0;
    public decimal CalculatePrice(decimal price, int quantity )
    {
        totalPrice = price*quantity;
        return totalPrice;
    }
    public decimal CalculatePrice(decimal price, int quantity,int discount )
    {
        totalPrice = (price*quantity)-(price*quantity*discount)/100;//Total Price With Discount = (price * quantity)- (price * quantity * discount percentage/100).
        return totalPrice;
    }

}