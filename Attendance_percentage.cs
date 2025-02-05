//WAP to calculate the required attendance percentage of a student, if the total number of lectures held per week is 3 and total number of weeks in the semester is 16. Determine the total number of lectures to be attended by the student to satisfy the required attendance criteria.

using System;
class AttendancePercentage
{
    public static void Main(string[] args)
    {
        int lectures_per_week, number_of_weeks, total_lectures;
        double skippable_lectures, must_attend_lectures;
        Console.WriteLine("Enter number of lectures per week:");
        lectures_per_week = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of weeks in the semester:");
        number_of_weeks = Convert.ToInt32(Console.ReadLine());
        total_lectures = lectures_per_week * number_of_weeks;
        Console.WriteLine("Total lectures in your semester: " + total_lectures);
        must_attend_lectures = total_lectures * 0.75;
        Console.WriteLine("You must attend " + must_attend_lectures + " lectures.");
        skippable_lectures = total_lectures - must_attend_lectures;
        Console. WriteLine("You can skip " + skippable_lectures + " lectures.");
    }
}
