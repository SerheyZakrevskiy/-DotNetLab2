﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtensionMethodsDemo
{
    public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
    {
        private List<ExtendedDictionaryElement<T, U, V>> elements;

        public ExtendedDictionary()
        {
            elements = new List<ExtendedDictionaryElement<T, U, V>>();
        }

        public void Add(T key, U value1, V value2)
        {
            elements.Add(new ExtendedDictionaryElement<T, U, V>(key, value1, value2));
        }

        public bool Remove(T key)
        {
            var element = elements.Find(e => e.Key.Equals(key));
            if (element != null)
            {
                elements.Remove(element);
                return true;
            }
            return false;
        }

        public bool ContainsKey(T key)
        {
            return elements.Exists(e => e.Key.Equals(key));
        }

        public bool ContainsValue(U value1, V value2)
        {
            return elements.Exists(e => e.Value1.Equals(value1) && e.Value2.Equals(value2));
        }

        public ExtendedDictionaryElement<T, U, V> this[T key]
        {
            get
            {
                return elements.Find(e => e.Key.Equals(key));
            }
        }

        public int Count => elements.Count;

        public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
