using System;

class BinaryToDecimal
{
    public void abc()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        try
        {
            int decimalNumber = Convert.ToInt32(binaryNumber, 2);

            Console.WriteLine($"The decimal equivalent of binary {binaryNumber} is {decimalNumber}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid binary number! Please enter a valid binary number.");
        }
    }
}
