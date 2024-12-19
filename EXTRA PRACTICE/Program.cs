using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Lab_5_1 :");
            Console.WriteLine("Enter 2 for Lab_5_2 :");
            Console.WriteLine("Enter 3 for Lab_5_3 :");
            Console.WriteLine("Enter 4 for Lab_5_4 :");
            Console.WriteLine("Enter 5 for Lab_5_5 :");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    StudentGrades l1 = new StudentGrades();
                    l1.abc();
                    break;
                case 2:
                    DecimalToBinary l2 = new DecimalToBinary();
                    l2.abc();
                    break;
                case 3:
                    BinaryToDecimal l3 = new BinaryToDecimal();
                    l3.abc();
                    break;
                case 4:
                    DaysToYearMonthDay l4 = new DaysToYearMonthDay();
                    l4.abc();
                    break;
                case 5:
                    DateFormats l5 = new DateFormats();
                    l5.abc();
                    break;
            }
        }
    }
}