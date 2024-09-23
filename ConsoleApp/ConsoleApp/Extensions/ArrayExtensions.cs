using System;
using System.Collections.Generic;

namespace ExtensionMethodsDemo.Extensions
{
    public static class ArrayExtensions
    {
        public static int CountOccurrences<T>(this T[] array, T value) where T : IEquatable<T>
        {
            int count = 0;
            foreach (T item in array)
            {
                if (item.Equals(value))
                    count++;
            }
            return count;
        }

        public static T[] GetUniqueElements<T>(this T[] array) where T : IEquatable<T>
        {
            HashSet<T> uniqueElements = new HashSet<T>(array);
            return new List<T>(uniqueElements).ToArray();
        }
    }
}
