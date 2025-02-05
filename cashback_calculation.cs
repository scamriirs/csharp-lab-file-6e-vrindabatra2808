//An e-commerce website provides cashback on the purchase amount. 
//Below Rs. 1000	No cashback
//Rs. 1001 – Rs. 5000	5% cashback
//Rs. 5001 – Rs. 10000	10% cashback
//Above Rs. 10000	15% cashback
//Take purchase amount as an input from user and calculate the cashback amount given on a particular purchase. 

using System;
public class Cashback {
    public static void Main(string[] args) {
        int purchase_amount, cashback;
        Console.WriteLine("Enter the purchase amount");
        purchase_amount = Convert.ToInt32(Console.ReadLine()); 
        if (purchase_amount < 1000)
        {
            Console. WriteLine("You will not receive any cashback");
        }
        else if (purchase_amount >= 1001 && purchase_amount <= 5000)
        {
            cashback = (purchase_amount * 5) / 100;
            Console.WriteLine("You will receive a cashback of " + cashback);
        }
        else if (purchase_amount >= 5001 && purchase_amount <= 10000)
        {
            cashback = (purchase_amount * 10) / 100;
            Console.WriteLine("You will receive a cashback of " + cashback);
        }
        else
        {
            cashback = (purchase_amount * 15) / 100;
            Console.WriteLine("You will receive a cashback of " + cashback);
        }
    }
}
