//WAP to calculate the library fine. If a book is returned within 10 days, then no fine is to be paid. If book is returned within 10 to 15 days, Rs.2 fine will be charged per day. If the book is returned within 15 to 30 days, Rs.5 fine is charged. If it exceeds 30 days, Rs. 1000 fine is levied along with Rs.5 fine per day. Also, the subscription is cancelled.

using System;
public class LibraryFine
{
    public static void Main(string[] args)
    {
        int number_of_days, fine;
        Console.WriteLine ("Enter the number of days for which book is due: ");
        number_of_days=Convert.ToInt32(Console.ReadLine());
        if (number_of_days<=10) 
        {
            Console.WriteLine("You will not be charged any fine");
        }
        else if (number_of_days>10 && number_of_days <=15)
        {
            fine = number_of_days * 2;
            Console.WriteLine("You will be charged with fine of Rs: "+fine);
        }
        else if (number_of_days>15 && number_of_days<=30)
        {
            fine = number_of_days * 5;
            Console.WriteLine("You will be charged a fine of Rs: "+fine);
        }
        else
        {
        fine = (number_of_days * 5) + 1000;
            Console.WriteLine("You will be charged a fine of Rs: "+fine);   
        }
    }
}
