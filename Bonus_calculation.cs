//A company gives bonus to its employees, based on their years of service.
//Less than 5 years	No bonus
//5-10 years	10% of the salary
//11-15 years	15% of the salary
//Above 15 years	20% of the salary
//Take employee salary and years of service as input from the user.

using System;
public class Bonus {
    public static void Main(string[] args) {
       int emp_salary, years_of_service, bonus;
       Console.WriteLine("Enter your salary: ");
       emp_salary = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your years of service: ");
       years_of_service = Convert.ToInt32(Console.ReadLine());
       if (years_of_service < 5)
       {
           Console.WriteLine("You will not receive any bonus.");
       }
       else if (years_of_service >= 5 && years_of_service <= 10)
       {
           bonus = emp_salary / 10;  
           Console.WriteLine("You will receive a bonus of Rs. " + bonus);
       }
       else if (years_of_service > 10 && years_of_service <= 15)  {
           bonus = (emp_salary * 15) / 100; 
           Console.WriteLine("You will receive a bonus of Rs. " + bonus);
       }
       else
       {
           bonus = (emp_salary * 20) / 100; 
           Console.WriteLine("You will receive a bonus of Rs. " + bonus);
       }
    }
}
