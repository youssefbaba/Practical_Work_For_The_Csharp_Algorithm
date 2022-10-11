using System.Net.Http.Headers;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsKaprekar(10)); // False
            Console.WriteLine(IsKaprekar(45)); // True
            Console.WriteLine(IsKaprekar(13)); // False
            Console.WriteLine(IsKaprekar(297)); // True
        }

        public static int sumParts(int number, int height , out int leftPart , out int rightPart)
        {
            leftPart = 0;
            rightPart = 0;
            int counter = 0;
            int sum = 0;
            while (counter < height)
            {
                sum += (number % 10) * (int)Math.Pow(10, counter);
                number /= 10;
                counter++;
            }
            leftPart = number;
            rightPart = sum;
            return sum + number;
        }
        public static bool IsKaprekar(int number)
        {
            int squareNumber = number * number;
            string stringNumber = squareNumber.ToString();
            int leftPart;
            int rightPart;
            for (int i = 1; i < stringNumber.Length; i++)
            {
                if ((sumParts(squareNumber, i, out leftPart, out rightPart) == number) && ((leftPart != 0)) && (rightPart != 0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}