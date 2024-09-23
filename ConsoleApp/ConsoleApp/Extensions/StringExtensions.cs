using System;

namespace ExtensionMethodsDemo.Extensions
{
    public static class StringExtensions
    {
        // Метод для інверсії рядка
        public static string Invert(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Метод для підрахунку входжень символа
        public static int CountOccurrences(this string str, char c)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == c)
                    count++;
            }
            return count;
        }
    }
}
