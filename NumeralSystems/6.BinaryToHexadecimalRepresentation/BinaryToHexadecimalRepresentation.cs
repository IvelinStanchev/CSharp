/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/
using System;
using System.Text;

class BinaryToHexadecimalRepresentation
{
    static void Main()
    {
        Console.Write("Enter the binary number: ");
        string flexibleBinaryNumber = Console.ReadLine();
        string binaryNumber = flexibleBinaryNumber;

        while (binaryNumber.Length % 4 != 0)//If we have binary number which digits are not divisible by 4 I add zeros at the start of the number
        {
            binaryNumber = "0" + binaryNumber;
        }

        StringBuilder hexadecimalNumber = new StringBuilder();

        for (int i = 0; i < binaryNumber.Length; i += 4)
        {
            StringBuilder currentFourNumbers = new StringBuilder();//Getting each four numbers
            for (int j = i; j < i + 4; j++)
            {
                currentFourNumbers.Append(binaryNumber[j]);
            }

            string fourDigits = currentFourNumbers.ToString();
            switch (fourDigits)
            {
                case "0000":
                    hexadecimalNumber.Append(0);
                    break;
                case "0001":
                    hexadecimalNumber.Append(1);
                    break;
                case "0010":
                    hexadecimalNumber.Append(2);
                    break;
                case "0011":
                    hexadecimalNumber.Append(3);
                    break;
                case "0100":
                    hexadecimalNumber.Append(4);
                    break;
                case "0101":
                    hexadecimalNumber.Append(5);
                    break;
                case "0110":
                    hexadecimalNumber.Append(6);
                    break;
                case "0111":
                    hexadecimalNumber.Append(7);
                    break;
                case "1000":
                    hexadecimalNumber.Append(8);
                    break;
                case "1001":
                    hexadecimalNumber.Append(9);
                    break;
                case "1010":
                    hexadecimalNumber.Append("A");
                    break;
                case "1011":
                    hexadecimalNumber.Append("B");
                    break;
                case "1100":
                    hexadecimalNumber.Append("C");
                    break;
                case "1101":
                    hexadecimalNumber.Append("D");
                    break;
                case "1110":
                    hexadecimalNumber.Append("E");
                    break;
                case "1111":
                    hexadecimalNumber.Append("F");
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }
        }

        Console.Clear();
        string finalHexadecimalNumber = hexadecimalNumber.ToString();
        Console.WriteLine("{0} -> {1}", flexibleBinaryNumber, finalHexadecimalNumber);
    }
}
