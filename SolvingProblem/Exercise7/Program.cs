using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertFromBinaryToDecimalOne(10101); // 21
            ConvertFromBinaryToDecimalOne(11111); // 31
            ConvertFromBinaryToDecimalTwo(10101); // 21
            ConvertFromBinaryToDecimalTwo(11111); // 31
            ConvertFromBinaryToDecimalThree(10101); // 21
            ConvertFromBinaryToDecimalThree(11111); // 31
            ConvertFromDecimalToBinaryOne(21); // 10101
            ConvertFromDecimalToBinaryOne(31); // 11111
            ConvertFromDecimalToBinaryTwo(21); // 10101
            ConvertFromDecimalToBinaryTwo(31); // 11111
            ConvertFromDecimalToBinaryThree(21); // 10101
            ConvertFromDecimalToBinaryThree(31); // 11111
            ConvertFromHexadecimalToDecimalOne("1D9"); // 473
            ConvertFromHexadecimalToDecimalOne("80E1"); // 32993
            ConvertFromHexadecimalToDecimalTwo("1D9"); // 473
            ConvertFromHexadecimalToDecimalTwo("80E1"); // 32993
            ConvertFromHexadecimalToDecimalThree("1D9"); // 473
            ConvertFromHexadecimalToDecimalThree("80E1"); // 32993
            ConvertFromDecimalToHexadecimalOne(473); // 1D9
            ConvertFromDecimalToHexadecimalOne(32993); // 80E1
            ConvertFromDecimalToHexadecimalTwo(473); // 1D9
            ConvertFromDecimalToHexadecimalTwo(32993); // 80E1
            ConvertFromDecimalToHexadecimalThree(473); // 1D9
            ConvertFromDecimalToHexadecimalThree(32993); // 80E1
        }

        public static void ConvertFromBinaryToDecimalOne(int number)
        {
            int temporaryNumber = number;
            int decimalValue = 0;
            int powerZero = 1; // 2^0
            while (number > 0)
            {
                decimalValue += (number % 10) * powerZero;
                number /= 10;
                powerZero *= 2;
            }
            Console.WriteLine($"Decimal value of {temporaryNumber} = {decimalValue}");
        }
        public static void ConvertFromBinaryToDecimalTwo(int number)
        {
            List<int> listNumbers = new List<int>();
            int temporaryNumber = number;
            int decimalValue = 0;
            while (number > 0)
            {
                listNumbers.Add(number % 10);
                number /= 10;
            }
            for (int i = 0; i < listNumbers.Count; i++)
            {
                decimalValue += listNumbers[i] * (int)Math.Pow(2, listNumbers.Count - i - 1);
            }
            Console.WriteLine($"Decimal value of {temporaryNumber} = {decimalValue}");
        }
        public static void ConvertFromBinaryToDecimalThree(int number)
        {
            int decimalValue = Convert.ToInt32(number.ToString(), 2);
            Console.WriteLine($"Decimal value of {number} = {decimalValue}");
        }
        public static void ConvertFromDecimalToBinaryOne(int number)
        {
            List<int> listNumbers = new List<int>();
            Console.Write($"Binary value of {number} = ");
            while (number > 0)
            {
                listNumbers.Add(number % 2);
                number /= 2;
            }
            for (int i = listNumbers.Count - 1; i >= 0; i--)
            {
                Console.Write(listNumbers[i]);
            }
            Console.WriteLine();
        }
        public static void ConvertFromDecimalToBinaryTwo(int number)
        {
            string stringNumber = string.Empty;
            int temporayNumber = number;
            while (number > 0)
            {
                //stringNumber = (number % 2).ToString() + stringNumber;
                stringNumber = String.Concat((number % 2).ToString(), stringNumber);
                number /= 2;
            }
            Console.WriteLine($"Binary value of {temporayNumber} = {stringNumber}");
        }
        public static void ConvertFromDecimalToBinaryThree(int number)
        {
            string binaryValue = Convert.ToString(number, 2);
            Console.WriteLine($"Binary value of {number} = {binaryValue}");
        }
        public static void ConvertFromHexadecimalToDecimalOne(string hexadecimalNumber)
        {
            int decimalValue = 0;
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                decimalValue += Convert.ToInt32(hexadecimalNumber[i].ToString(), 16) * (int)Math.Pow(16, hexadecimalNumber.Length - i - 1);
            }
            Console.WriteLine($"Decimal value of {hexadecimalNumber} = {decimalValue}");
        }
        public static void ConvertFromHexadecimalToDecimalTwo(string hexadecimalNumber)
        {
            int decimalValue = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine($"Decimal value of {hexadecimalNumber} = {decimalValue}");
        }
        public static void ConvertFromHexadecimalToDecimalThree(string hexadecimalNumber) 
        {
            int decimalValue;
            if (int.TryParse(hexadecimalNumber, System.Globalization.NumberStyles.HexNumber, null, out decimalValue))
            {
                Console.WriteLine($"Decimal value of {hexadecimalNumber} = {decimalValue}");
            }
            else
            {
                Console.WriteLine($"Conversion of {hexadecimalNumber} failed !");
            }
        }
        public static void ConvertFromDecimalToHexadecimalOne(int number)
        {
            List<string> listNumbers = new List<string>();
            int temporaryNumber = number;

            Console.Write($"Hexadecimal value of {number} = ");
            while ( number > 0)
            {
                listNumbers.Add((number % 16).ToString("X"));
                number /= 16;
            }
            for (int i = listNumbers.Count -1 ; i >=0; i--)
            {
                Console.Write($"{listNumbers[i]}");
            }
            Console.WriteLine();
        }
        public static void ConvertFromDecimalToHexadecimalTwo(int number)
        {
            string stringNumber = string.Empty;
            int temporaryNumber = number;
            while (number > 0)
            {
                stringNumber = String.Concat((number % 16).ToString("X"), stringNumber);
                number /= 16;
            }
            Console.WriteLine($"Hexadecimal value of {temporaryNumber} = {stringNumber}");
        }
        public static void ConvertFromDecimalToHexadecimalThree(int number)
        {
            //string stringNumber = number.ToString("X");
            string stringNumber = Convert.ToString(number , 16).ToUpper();
            Console.WriteLine($"Hexadecimal value of {number} = {stringNumber}");
        }

    }
}