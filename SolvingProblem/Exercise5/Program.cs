namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Please enter an integer number not null.");
            int number;
            bool check;
            do
            {
                Console.Write($"Number : ");
                check = int.TryParse(Console.ReadLine(), out number);
                if (check && (number != 0))
                {
                    int[,] values = new int[number, number];
                    for (int i = 0; i < number; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            if ((i == j) || (j == 0))
                            {
                                values[i, j] = 1;
                            }
                            else
                            {
                                values[i, j] = values[i - 1, j - 1] + values[i - 1, j];
                            }
                            Console.Write($"{values[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine($"Please try enter a new number again !");
                }

            } while (!check || (number == 0));
        }
    }
}