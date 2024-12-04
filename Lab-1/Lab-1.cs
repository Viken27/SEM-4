using System;
using System.Drawing;

class pro1
{
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Enter program number :");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                string name = "John Doe";
                string address = "123 Elm Street";
                string contact = "9876543210";
                string city = "New York";

                Console.WriteLine($"Name: {name}\nAddress: {address}\nContact: {contact}\nCity: {city}");
            }
            else if (n == 2)
            {
                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"The entered numbers are {number1} and {number2}.");
            }
            else if (n == 3)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your country: ");
                string country = Console.ReadLine();

                Console.WriteLine($"Hello {name} from country {country}!");
            }
            else if (n == 4)
            {
                Console.Write("Enter the length of the rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of Rectangle: {length * width}");
            }
            else if (n == 5)
            {
                Console.Write("Enter the side of the square: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of Square: {side * side}");

                Console.Write("Enter the length of the rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of Rectangle: {length * width}");

                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of Circle: {Math.PI * radius * radius}");
            }
            else if (n == 6)
            {
                Console.Write("Enter 1 for Celsius to Fahrenheit or 2 for Fahrenheit to Celsius: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Temperature in Fahrenheit: {(celsius * 9 / 5) + 32}");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Temperature in Celsius: {(fahrenheit - 32) * 5 / 9}");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (n == 7)
            {
                Console.Write("Enter the first number: ");
                int p = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int r = int.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Interest " + (p * r * n1) / 100);

            }
            else if (n == 8)
            {
                Console.WriteLine("Enter operation you want to perform");
                Console.WriteLine("1.Addition  2.Subtraction  3.Multiplication  4.Division");
                int K = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        int ans1 = num1 + num2;
                        Console.WriteLine(ans1);
                        break;
                    case 2:
                        int ans2 = num2 - num1;
                        Console.WriteLine(ans2);
                        break;
                    case 3:
                        int ans3 = num1 * num2;
                        Console.WriteLine(ans3);
                        break;
                    case 4:
                        int ans4 = num2 / num1;
                        Console.WriteLine(ans4);
                        break;

                }
            }
            else if (n == 9)
            {
                {

                    int a = 5;
                    int b = 10;

                    Console.WriteLine("Before Swap:");
                    Console.WriteLine("a = " + a);
                    Console.WriteLine("b = " + b);

                    a = a + b;
                    b = a - b;
                    a = a - b;

                    Console.WriteLine("\nAfter Swap:");
                    Console.WriteLine("a = " + a);
                    Console.WriteLine("b = " + b);
                }
            }
            else if (n == 10)
            {
                {
                    Console.Write("Enter the first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the third number: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    int max = (num1 > num2)
                              ? (num1 > num3 ? num1 : num3)
                              : (num2 > num3 ? num2 : num3);


                    Console.WriteLine($"The maximum number is: {max}");
                }
            }
            else
            {
                Console.WriteLine("Not valid");
                break;
            }
        }

    }
}