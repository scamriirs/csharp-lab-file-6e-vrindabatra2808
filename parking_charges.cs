//In a college campus, structured parking system is required to efficiently manage parking fees collection. The parking system must classify vehicles into 3 types:
//1: VIP/ Faculty Car	No parking fees
//2: Student Car	Rs. 10 
//3: Visitor’s Car	Rs. 20
//4: Show Summary	Total revenue, Total number of each vehicle
//5: Exit	Program terminates
//The system should allow users to register a vehicle entry, automatically collect the total collection and generate a summary report displaying the information, the number of vehicle parked.

using System;
class ParkingSystem
{
    static int vipCount = 0, studentCount = 0, visitorCount = 0;
    static int totalRevenue = 0;
  
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. VIP Car (No fee)");
            Console.WriteLine("2. Student Car (10 rupees)");
            Console.WriteLine("3. Visitor Car (20 rupees)");
            Console.WriteLine("4. Show summary");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                vipCount++;
                Console.WriteLine("VIP car registered, no fees");
            }
