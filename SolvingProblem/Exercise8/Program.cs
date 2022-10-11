using System.Net.Http.Headers;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 1, 1, 2, 3, 4, 7, 9 };
            int[] arrayTwo = new int[] { 1, 2, 3, 1, 2, 1, 2, 1, 9 };
            Console.WriteLine(LongLengthOfSuccessiveIntegers(arrayOne));
            Console.WriteLine(LongLengthOfSuccessiveIntegers(arrayTwo));
        }
        public static int LongLengthOfSuccessiveIntegers(int[] array)
        {
            int counter = 0;
            int maxValue = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i+1] == (array[i] + 1) )
                {
                    counter++;
                    maxValue = (maxValue <= counter ) ? counter : maxValue;
                }
                else
                {
                    counter = 0;
                }
            }
            return maxValue + 1;
        }
    }
}