using System.Text;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MergeOne("Hello", "Bonjour")); // HBeolnljoour
            Console.WriteLine(MergeOne("Bonjour", "Hello")); // BHoenljloour
            Console.WriteLine(MergeTwo("Hello", "Bonjour")); // HBeolnljoour
            Console.WriteLine(MergeTwo("Bonjour", "Hello")); // BHoenljloour
        }
        public static string MergeOne(string stringOne, string stringTwo)
        {
            int index = 0;
            string MergeString = String.Empty;
            while ((index < stringOne.Length) || (index < stringTwo.Length))
            {
                if (index < stringOne.Length)
                {
                    MergeString = String.Concat(MergeString, stringOne[index].ToString());
                }
                if (index < stringTwo.Length)
                {
                    MergeString = String.Concat(MergeString, stringTwo[index].ToString());
                }
                index++;
            }
            return MergeString;
        }
        public static string MergeTwo(string stringOne, string stringTwo)
        {
            string mergeString = String.Empty;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);
            string Substring = (minLength == stringOne.Length) ? stringTwo.Substring(minLength) : stringOne.Substring(minLength);
            for (int i = 0; i < minLength; i++)
            {
                mergeString = String.Concat(mergeString, stringOne[i].ToString(), stringTwo[i].ToString());
            }
            return String.Concat(mergeString, Substring);
        }
    }
}