using System;

class DecimalToBinary
{
    public void abc()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"The binary equivalent of {decimalNumber} is {binaryNumber}");
    }
}
