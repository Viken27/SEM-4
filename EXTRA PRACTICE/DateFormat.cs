using System;

class DateFormats
{
    public void abc()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Date in 'YYYY-MM-DD' format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Date in 'DD-MM-YY' format: " + currentDate.ToString("dd-MM-yy"));
        Console.WriteLine("Date in 'DD/MM/YYYY' format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date in 'MM/DD/YY' format: " + currentDate.ToString("MM/dd/yy"));
    }
}