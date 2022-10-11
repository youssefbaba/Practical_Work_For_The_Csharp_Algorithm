namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DisplayStars(5);
            DisplayStars(10);
        }
        public static void DisplayStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i == (number - 1))
                {
                    for (int k = 0; k < i; k++)
                    {
                        for (int z = k; z < i; z++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}