using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string email = "¾ffd125@gmail.com";
            Console.WriteLine(FirstCharacterIsNumber(email));
            Console.WriteLine($"{SingleAtCharacterOne(email)}");
            Console.WriteLine($"{SingleAtCharacterTwo(email)}");
            Console.WriteLine($"{NumbersCharacterBeforeAtCharacterOne(email)}");
            Console.WriteLine($"{NumbersCharacterBeforeAtCharacterTwo(email)}");
            Console.WriteLine($"{SinglePointCharacterOne(email)}");
            Console.WriteLine($"{SinglePointCharacterTwo(email)}");
            Console.WriteLine($"{NumbersCharacterBeforePointOne(email)}");
            Console.WriteLine($"{NumbersCharacterBeforePointTwo(email)}");
            Console.WriteLine(PointCharacterIsAfterAtCharacterOne(email));
            Console.WriteLine(PointCharacterIsAfterAtCharacterOne(email));
            */
            Console.WriteLine($"Please enter your email address");
            string addressEmail;
            do
            {
                Console.Write($"Email address : ");
                addressEmail = Console.ReadLine();
                if (!String.IsNullOrEmpty(addressEmail))
                {
                    if (
                        !FirstCharacterIsNumber(addressEmail) &&
                        SingleAtCharacterTwo(addressEmail) &&
                        (NumbersCharacterBeforeAtCharacterTwo(addressEmail) >= 3) &&
                        SinglePointCharacterTwo(addressEmail) &&
                        (NumbersCharacterBeforePointTwo(addressEmail) >= 5) &&
                        PointCharacterIsAfterAtCharacterTwo(addressEmail)
                        )
                    {
                        Console.WriteLine($"This email is valid .");
                    }
                    else
                    {
                        Console.WriteLine($"This email isn't valid .");
                    }
                }
                else
                {
                    Console.WriteLine($"Please try to enter a new email again !");
                }

            } while (String.IsNullOrEmpty(addressEmail));
        }

        public static bool FirstCharacterIsNumber(string email)
        {
            if (Char.IsNumber(email[0]))
            {
                return true;
            }
            return false;
        }
        public static bool SingleAtCharacterOne(string email)
        {
            int counter = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                return true;
            }
            return false;
        }
        public static bool SingleAtCharacterTwo(string email)
        {
            int counter = 0;
            int startIndex = 0;
            while (email.IndexOf('@', startIndex) != -1)
            {
                counter++;
                startIndex = email.IndexOf('@', startIndex) + 1;
            }
            if (counter == 1)
            {
                return true;
            }
            return false;
        }
        public static int NumbersCharacterBeforeAtCharacterOne(string email)
        {
            if (SingleAtCharacterTwo(email))// Exist only one @ character
            {
                int index = 0;
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
            return -1;
        }
        public static int NumbersCharacterBeforeAtCharacterTwo(string email)
        {
            if (SingleAtCharacterTwo(email)) // Exist only one @ character
            {
                string subString = email.Substring(0, email.IndexOf('@'));
                return subString.Length;
            }
            return -1;
        }
        public static bool SinglePointCharacterOne(string email)
        {
            int counter = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '.')
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                return true;
            }
            return false;
        }
        public static bool SinglePointCharacterTwo(string email)
        {
            int counter = 0;
            int startIndex = 0;
            while (email.IndexOf('.', startIndex) != -1)
            {
                counter++;
                startIndex = email.IndexOf('.', startIndex) + 1;
            }
            if (counter == 1)
            {
                return true;
            }
            return false;
        }
        public static int NumbersCharacterBeforePointOne(string email)
        {
            if (SinglePointCharacterTwo(email))// Exist only one . character
            {
                int index = 0;
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '.')
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
            return -1;
        }
        public static int NumbersCharacterBeforePointTwo(string email)
        {
            if (SinglePointCharacterTwo(email)) // Exist only one . character
            {
                string subString = email.Substring(0, email.IndexOf('.'));
                return subString.Length;
            }
            return -1;
        }
        public static bool PointCharacterIsAfterAtCharacterOne(string email)
        {
            if (SingleAtCharacterTwo(email) && SinglePointCharacterTwo(email))
            {
                int indexPoint = 0;
                int indexAt = 0;
                for (int i = 0; i < email.Length; i++)
                {
                    switch (email[i])
                    {
                        case '.':
                            indexPoint = i;
                            break;
                        case '@':
                            indexAt = i;
                            break;
                        default:
                            break;
                    }
                }
                if (indexPoint > indexAt)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool PointCharacterIsAfterAtCharacterTwo(string email)
        {
            if (SingleAtCharacterTwo(email) && SinglePointCharacterOne(email))
            {
                if (email.IndexOf('.') > email.IndexOf('@'))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}