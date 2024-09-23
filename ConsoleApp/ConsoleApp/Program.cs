using System;
using ExtensionMethodsDemo.Extensions;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine("Original string: " + str);
            Console.WriteLine("Inverted string: " + str.Invert());
            Console.WriteLine("Occurrences of 'l': " + str.CountOccurrences('l'));

            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine("Array: " + string.Join(", ", numbers));
            Console.WriteLine("Occurrences of 2: " + numbers.CountOccurrences(2));
            Console.WriteLine("Unique elements: " + string.Join(", ", numbers.GetUniqueElements()));

            string[] words = { "apple", "banana", "apple", "cherry", "banana" };
            Console.WriteLine("Words array: " + string.Join(", ", words));
            Console.WriteLine("Unique words: " + string.Join(", ", words.GetUniqueElements()));

            var extendedDict = new ExtendedDictionary<int, string, string>();
            extendedDict.Add(1, "John", "Doe");
            extendedDict.Add(2, "Jane", "Smith");
            extendedDict.Add(3, "Alice", "Johnson");

            Console.WriteLine($"Dictionary Count: {extendedDict.Count}");

            Console.WriteLine("Element with key 1: " + extendedDict[1]);

            Console.WriteLine($"Contains Key 2: {extendedDict.ContainsKey(2)}");
            Console.WriteLine($"Contains Value (Alice, Johnson): {extendedDict.ContainsValue("Alice", "Johnson")}");

            extendedDict.Remove(2);
            Console.WriteLine($"Dictionary Count after removal: {extendedDict.Count}");

            foreach (var element in extendedDict)
            {
                Console.WriteLine(element);
            }
        }
    }
}
