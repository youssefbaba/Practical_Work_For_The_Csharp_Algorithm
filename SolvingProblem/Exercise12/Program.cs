namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Units(8));    // 8
            Console.WriteLine(Units(25));   // 5
            Console.WriteLine(Units(221));  // 1
            Console.WriteLine(Units(2219)); // 9
            Console.WriteLine("##############");
            Console.WriteLine(Tens(8));    // 0
            Console.WriteLine(Tens(25));   // 2
            Console.WriteLine(Tens(221));  // 2
            Console.WriteLine(Tens(2219)); // 1
            Console.WriteLine("##############");
            Console.WriteLine(Extract(1267, 0)); // 7
            Console.WriteLine(Extract(1267, 2)); // 2
            Console.WriteLine(Extract(1267, 3)); // 1
            Console.WriteLine(Extract(1267, 6)); // -1
            Console.WriteLine("##############");
            Console.WriteLine(NumberDigits(8));    // 1
            Console.WriteLine(NumberDigits(25));   // 2
            Console.WriteLine(NumberDigits(221));  // 3
            Console.WriteLine(NumberDigits(2219)); // 4
            Console.WriteLine("##############");
            Console.WriteLine(SumDigits(1));    // 1
            Console.WriteLine(SumDigits(12));   // 3
            Console.WriteLine(SumDigits(126));  // 9
            Console.WriteLine(SumDigits(1267)); // 16


        }
        public static int Units(int number )
        {
            return number % 10;
        }
        public static int Tens(int number)
        {
            return Units(number / 10);
        }
        public static int Extract(int number , int position)
        {
            string stringNumber = number.ToString();
            if (position <= stringNumber.Length)
            {
            int result = number / (int)Math.Pow(10 , position);
            return Units(result);
            }
            return -1;
        }
        public static int NumberDigits(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                number /= 10;
                counter++;
            }
            return counter;
        }
        public static int SumDigits(int number)
        {
            int sum = 0;
            int counter = NumberDigits(number);
            for (int i = 0; i < counter; i++)
            {
                sum += Units(number);
                number /= 10;
            }
            return sum;
        }
    }
}