﻿using System;

namespace ExtensionMethodsDemo
{
    public class ExtendedDictionaryElement<T, U, V>
    {
        public T Key { get; set; }
        public U Value1 { get; set; }
        public V Value2 { get; set; }

        public ExtendedDictionaryElement(T key, U value1, V value2)
        {
            Key = key;
            Value1 = value1;
            Value2 = value2;
        }

        public override string ToString()
        {
            return $"Key: {Key}, Value1: {Value1}, Value2: {Value2}";
        }
    }
}
