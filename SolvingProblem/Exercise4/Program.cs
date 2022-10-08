
using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arrayTwo = new int[] { 10, 20, 30, 12, 100, 600, 80 };
            DisplayArray(GenerateArray(20));
            ElementsIntersectionArraysGeneral(GenerateArray(40), GenerateArray(60));
            Loto();
        }
        public static int[] GenerateArray(int lengthArray)
        {
            int[] array = new int[lengthArray];
            Random random = new Random();
            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = random.Next(0, 101);
            }
            return array;
        }
        public static void DisplayArray(int[] array)
        {
            Console.Write($"[");
            foreach (int element in array)
            {
                Console.Write($" {element} ");
            }
            Console.Write($"]\n");
        }
        public static bool NumberInArrayOne(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool NumberInArrayTwo(int value, int[] array)
        {
            if (Array.IndexOf(array, value) != -1)
            {
                return true;
            }
            return false;
        }
        public static int NumberElementsInArrayOne(int value, int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int NumberElementsInArrayTwo(int value, int[] array)
        {
            int counter = 0;
            int startIndex = 0;
            while (Array.IndexOf(array, value, startIndex) != -1)
            {
                counter++;
                startIndex = Array.IndexOf(array, value, startIndex) + 1;
            }
            return counter;
        }
        public static bool ArrayWithoutDuplicates(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (NumberElementsInArrayOne(array[i], array) > 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] EliminateDuplicates(int[] array)
        {
            List<int> anotherArray = new List<int>();
            anotherArray.Add(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (NumberElementsInArrayOne(array[i], anotherArray.ToArray()) == 0)
                {
                    anotherArray.Add(array[i]);
                }
            }
            return anotherArray.ToArray();
        }
        public static int CardIntersectionArrays(int[] arrayOne, int[] arrayTwo) // In this case, I suppose the arrays don't have duplicate elements
        {
            int counter = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (NumberElementsInArrayOne(arrayOne[i], arrayTwo) == 1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
        public static int CardIntersectionArraysGeneral(int[] arrayOne, int[] arrayTwo)
        {
            int counter = 0;
            int[] copyArrayOne = new int[EliminateDuplicates(arrayOne).Length];
            Array.Copy(EliminateDuplicates(arrayOne), copyArrayOne, EliminateDuplicates(arrayOne).Length);
            for (int i = 0; i < copyArrayOne.Length; i++)
            {
                if (NumberElementsInArrayOne(copyArrayOne[i], arrayTwo) >= 1)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static void ElementsIntersectionArrays(int[] arrayOne, int[] arrayTwo)
        {

            if (CardIntersectionArrays(arrayOne, arrayTwo) > 0)
            {
                Console.Write($"The array of intersection elements : [");
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (NumberElementsInArrayOne(arrayOne[i], arrayTwo) == 1)
                    {
                        Console.Write($" {arrayOne[i]} ");
                    }
                }
                Console.Write($"]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"There are no intersection elements");
            }
        }
        public static void ElementsIntersectionArraysGeneral(int[] arrayOne, int[] arrayTwo)
        {
            if (CardIntersectionArraysGeneral(arrayOne, arrayTwo) > 0)
            {
                int[] copyArrayOne = new int[EliminateDuplicates(arrayOne).Length];
                Array.Copy(EliminateDuplicates(arrayOne), copyArrayOne, EliminateDuplicates(arrayOne).Length);
                Console.Write($"The array of intersection elements : [");
                for (int i = 0; i < copyArrayOne.Length; i++)
                {
                    if (NumberElementsInArrayOne(copyArrayOne[i], arrayTwo) >= 1)
                    {
                        Console.Write($" {copyArrayOne[i]} ");
                    }
                }
                Console.Write($"]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"There are no intersection elements");
            }
        }
        public static bool ArrayInRange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 1 || array[i] > 49)
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] ArrayIntHasard()
        {
            Random random = new Random();
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = random.Next(1, 50);
            }
            return array;
        }
        public static void Loto()
        {
            Console.WriteLine($"Plaise 5 numbers between 1 and 49");
            List<int> numbersUser = new List<int>();
            int counter = 1;
            int number;
            do
            {
                if (!ArrayInRange(numbersUser.ToArray()) || !ArrayWithoutDuplicates(numbersUser.ToArray()))
                {
                    counter = 1;
                    numbersUser.Clear();
                }
                while (numbersUser.Count < 5)
                {
                    Console.Write($"Number {counter} : ");
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        counter++;
                        numbersUser.Add(number);
                    }
                    else
                    {
                        Console.WriteLine($"Please try to enter number {counter} again !");
                    }
                }
            } while (!ArrayInRange(numbersUser.ToArray()) || !ArrayWithoutDuplicates(numbersUser.ToArray()));

            int[] numbersProgram = new int[5];
            do
            {
                Array.Copy(ArrayIntHasard(), numbersProgram, 5);

            } while (!ArrayWithoutDuplicates(numbersProgram));
            Console.WriteLine($"Random draw : ");
            DisplayArray(numbersProgram);
            Console.WriteLine($"Player's game : ");
            DisplayArray(numbersUser.ToArray());
            Console.WriteLine($"The number of numbers found is : {CardIntersectionArraysGeneral(numbersUser.ToArray(),numbersProgram )}");
        }
    }
}