using System;

class DaysToYearMonthDay
{
    public void abc()
    {
        Console.Write("Enter number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;               
        int remainingDays = totalDays % 365;       
        int months = remainingDays / 30;           
        int days = remainingDays % 30;             

        Console.WriteLine($"{totalDays} days = {years} year(s), {months} month(s), {days} day(s)");
    }
}
